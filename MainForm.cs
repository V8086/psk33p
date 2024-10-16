using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace psk33p
{
    public partial class MainForm : Form
    {
        private string Pwd = null;
        private uint NumPrefixBytes;
        private uint NumSuffixBytes;
        private Random Rnd = new Random();
        private string Psk33pFilePath = null;
        private List<KeyValuePair<string, string>> Psk33pItems = new List<KeyValuePair<string, string>> { };

        private const string RndDict = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public MainForm()
        {
            InitializeComponent();
        }

        private void RefreshPsk33pItems()
        {
            MainLBItems.Items.Clear();
            foreach (KeyValuePair<string, string> item in Psk33pItems)
            {
                MainLBItems.Items.Add(item.Key);
            }
        }

        private void AddPsk33pItem(string key, string value)
        {
            KeyValuePair<string, string> realitem = Psk33pItems.Find(
                delegate (KeyValuePair<string, string> entry) {
                    return entry.Key == key;
                }
            );

            if (!realitem.Equals(default(KeyValuePair<string, string>))) {
                MessageBox.Show("Item already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KeyValuePair<string, string> item = new KeyValuePair<string, string>(key, value);
            Psk33pItems.Add(item);
            RefreshPsk33pItems();
        }

        private void DeletePsk33pItem(string key)
        {
            KeyValuePair<string, string> realitem = Psk33pItems.First(
                item => item.Key.Equals(key)
            );

            if (realitem.Equals(default(KeyValuePair<string, string>)))
            {
                MessageBox.Show("Unknown item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Psk33pItems.Remove(realitem);
            RefreshPsk33pItems();
        }

        private void EnableCtrlsAfterOpen()
        {
            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
            MainBtnEdit.Enabled = true;
            MainBtnDelete.Enabled = true;
            MainBtnAdd.Enabled = true;
            MainBtnCopyValue.Enabled = true;
            closeToolStripMenuItem.Enabled = true;
        }

        private void DisableCtrlsAfterClose()
        {
            Psk33pFilePath = null;
            saveToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
            MainBtnEdit.Enabled = false;
            MainBtnDelete.Enabled = false;
            MainBtnAdd.Enabled = false;
            MainBtnCopyValue.Enabled = false;
            closeToolStripMenuItem.Enabled = false;
        }

        private void OpenPsk33pFile(string path)
        {
            PwdForm pwdForm = new PwdForm();
            pwdForm.ShowDialog();
            if (pwdForm.Value == "")
            {
                MessageBox.Show(
                    "Empty password!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            Pwd = pwdForm.Value;
            byte[] pwdBytes = System.Text.Encoding.UTF8.GetBytes(Pwd);
            byte[] pwdHashBytes = SHA256.Create().ComputeHash(pwdBytes);

            byte[] bytes = File.ReadAllBytes(path);
            byte[] decoded = Psk33pCoder.Decode(bytes, Pwd);
            string decodedstr = System.Text.Encoding.UTF8.GetString(decoded);
            string[] lines = decodedstr.Split(
                new string[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
            );

            uint numlines = (uint)lines.Length;
            if (numlines % 2 != 0)
            {
                MessageBox.Show(
                    "Invalid password or file!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            Psk33pItems.Clear();
            for (uint iline = 0; iline < numlines; iline += 2)
            {
                AddPsk33pItem(lines[iline], lines[iline + 1]);
            }

            Psk33pFilePath = path;
            EnableCtrlsAfterOpen();
        }

        private void SavePsk33pFile(string path)
        {
            if (path == null) return;
            if (Pwd == null)
            {
                PwdForm pwdForm = new PwdForm();
                pwdForm.ShowDialog();
                if (pwdForm.Value == "")
                {
                    MessageBox.Show(
                        "Empty password!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                    );

                    return;
                }

                Pwd = pwdForm.Value;
            }

            string str = "";
            if (Psk33pItems.Count != 0)
            {
                foreach (KeyValuePair<string, string> kvp in Psk33pItems)
                {
                    str += kvp.Key + '\n' + kvp.Value + '\n';
                }

                str = str.TrimEnd('\n');
            }

            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(str);
            byte[] encoded = Psk33pCoder.Encode(bytes, Pwd);
            File.WriteAllBytes(path, encoded);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select psk33p file (.p3k) ...";
            ofd.Filter = "Psk33p file (*.pk3)|*.pk3|All files (*.*)|*.*";
            ofd.DefaultExt = "pk3";
            ofd.AddExtension = true;
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.Cancel) return;
            OpenPsk33pFile(ofd.FileName);
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Create new psk33p file (.p3k) ...";
            sfd.Filter = "Psk33p file (*.pk3)|*.pk3|All files (*.*)|*.*";
            sfd.DefaultExt = "pk3";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.Cancel) return;

            closeToolStripMenuItem_Click(sender, e);
            Psk33pFilePath = sfd.FileName;
            Pwd = null;
            Psk33pItems.Clear();
            RefreshPsk33pItems();
            EnableCtrlsAfterOpen();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Psk33pFilePath != null) SavePsk33pFile(Psk33pFilePath);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save psk33p file (.p3k) ...";
            sfd.Filter = "Psk33p file (*.pk3)|*.pk3|All files (*.*)|*.*";
            sfd.DefaultExt = "pk3";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.Cancel) return;

            Psk33pFilePath = sfd.FileName;
            saveToolStripMenuItem_Click(sender, e);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableCtrlsAfterClose();
            Psk33pFilePath = null;
            MainLBItems.Items.Clear();
            Psk33pItems.Clear();
        }

        private void MainBtnEdit_Click(object sender, EventArgs e)
        {
            if (Psk33pFilePath == null || MainLBItems.SelectedItem == null) return;

            string key = MainLBItems.SelectedItem.ToString();
            KeyValuePair<string, string> kvp = Psk33pItems.Find(
                delegate (KeyValuePair<string, string> item) {
                    return item.Key == key;
                }
            );

            DlgKeyValue dlgKeyValue = new DlgKeyValue();
            dlgKeyValue.Text = "Edit item";
            dlgKeyValue.Key = kvp.Key;
            dlgKeyValue.Value = kvp.Value;
            dlgKeyValue.TBKey.ReadOnly = true;
            if (dlgKeyValue.ShowDialog(Owner) != DialogResult.OK) return;

            DeletePsk33pItem(dlgKeyValue.Key);
            AddPsk33pItem(dlgKeyValue.Key, dlgKeyValue.Value);
        }

        private void MainBtnDelete_Click(object sender, EventArgs e)
        {
            if (Psk33pFilePath == null || MainLBItems.SelectedItem == null) return;

            string key = MainLBItems.SelectedItem.ToString();
            string caption = $"Do you really want to delete `{key}` item?";
            DialogResult result = MessageBox.Show(caption, "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            DeletePsk33pItem(key);
        }

        private void MainBtnAdd_Click(object sender, EventArgs e)
        {
            if (Psk33pFilePath == null) return;

            DlgKeyValue dlgKeyValue = new DlgKeyValue();
            dlgKeyValue.Text = "Add item";
            dlgKeyValue.Key = "";
            dlgKeyValue.Value = "";
            if (dlgKeyValue.ShowDialog(Owner) != DialogResult.OK) return;

            if (dlgKeyValue.Key == "")
            {
                MessageBox.Show("Empty key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddPsk33pItem(dlgKeyValue.Key, dlgKeyValue.Value);
        }

        private void MainBtnCopyValue_Click(object sender, EventArgs e)
        {
            if (Psk33pFilePath == null || MainLBItems.SelectedItem == null) return;

            NumPrefixBytes = (uint)Rnd.Next(1, 9);
            NumSuffixBytes = (uint)Rnd.Next(1, 9);
            MainBtnCopyValue.Text = $"Copy value ({NumPrefixBytes}:{NumSuffixBytes})";

            string text = "";
            for (uint i = 0; i < NumPrefixBytes; ++i)
            {
                text += RndDict[Rnd.Next(0, RndDict.Length)];
            }

            text += Psk33pItems.First(
                item => item.Key.Equals(MainLBItems.SelectedItem.ToString())
            ).Value;

            for (uint i = 0; i < NumSuffixBytes; ++i)
            {
                text += RndDict[Rnd.Next(0, RndDict.Length)];
            }

            Clipboard.SetText(text);
        }
    }
}
