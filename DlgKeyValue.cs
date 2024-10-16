using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psk33p
{
    public partial class DlgKeyValue : Form
    {
        public string Key
        {
            get => TBKey.Text;
            set => TBKey.Text = value;
        }

        public string Value
        {
            get => TBValue.Text;
            set => TBValue.Text = value;
        }

        public DlgKeyValue()
        {
            InitializeComponent();
        }

        private void DlgKeyValue_Load(object sender, EventArgs e)
        {
            if (TBKey.Enabled && !TBKey.ReadOnly) ActiveControl = TBKey;
            else ActiveControl = TBValue;
            AcceptButton = BtnOK;
            TBValue.UseSystemPasswordChar = !CBShow.Checked;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Key = "";
            Value = "";
            Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CBShow_CheckedChanged(object sender, EventArgs e)
        {
            TBValue.UseSystemPasswordChar = !CBShow.Checked;
        }
    }
}
