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
    public partial class PwdForm : Form
    {
        public string Value {
            get => TBPwd.Text;
        }

        public PwdForm()
        {
            InitializeComponent();
        }

        private void PwdForm_Load(object sender, EventArgs e)
        {
            TBPwd.UseSystemPasswordChar = !CBShow.Checked;
            ActiveControl = TBPwd;
            AcceptButton = BtnOK;
        }

        private void CBPwdShow_CheckedChanged(object sender, EventArgs e)
        {
            TBPwd.UseSystemPasswordChar = !CBShow.Checked;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
