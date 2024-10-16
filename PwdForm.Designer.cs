namespace psk33p
{
    partial class PwdForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TLPPwd = new System.Windows.Forms.TableLayoutPanel();
            this.TLPPwdActs = new System.Windows.Forms.TableLayoutPanel();
            this.BtnOK = new System.Windows.Forms.Button();
            this.CBShow = new System.Windows.Forms.CheckBox();
            this.TBPwd = new System.Windows.Forms.TextBox();
            this.TLPPwd.SuspendLayout();
            this.TLPPwdActs.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPPwd
            // 
            this.TLPPwd.ColumnCount = 1;
            this.TLPPwd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPPwd.Controls.Add(this.TLPPwdActs, 0, 1);
            this.TLPPwd.Controls.Add(this.TBPwd, 0, 0);
            this.TLPPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPPwd.Location = new System.Drawing.Point(0, 0);
            this.TLPPwd.Name = "TLPPwd";
            this.TLPPwd.RowCount = 2;
            this.TLPPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.TLPPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.28571F));
            this.TLPPwd.Size = new System.Drawing.Size(438, 77);
            this.TLPPwd.TabIndex = 0;
            // 
            // TLPPwdActs
            // 
            this.TLPPwdActs.ColumnCount = 2;
            this.TLPPwdActs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPPwdActs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPPwdActs.Controls.Add(this.BtnOK, 1, 0);
            this.TLPPwdActs.Controls.Add(this.CBShow, 0, 0);
            this.TLPPwdActs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPPwdActs.Location = new System.Drawing.Point(3, 30);
            this.TLPPwdActs.Name = "TLPPwdActs";
            this.TLPPwdActs.RowCount = 1;
            this.TLPPwdActs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPPwdActs.Size = new System.Drawing.Size(432, 44);
            this.TLPPwdActs.TabIndex = 2;
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOK.Location = new System.Drawing.Point(219, 3);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(210, 38);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // CBShow
            // 
            this.CBShow.AutoSize = true;
            this.CBShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBShow.Location = new System.Drawing.Point(3, 3);
            this.CBShow.Name = "CBShow";
            this.CBShow.Size = new System.Drawing.Size(210, 38);
            this.CBShow.TabIndex = 1;
            this.CBShow.Text = "Show";
            this.CBShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CBShow.UseVisualStyleBackColor = true;
            this.CBShow.CheckedChanged += new System.EventHandler(this.CBPwdShow_CheckedChanged);
            // 
            // TBPwd
            // 
            this.TBPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBPwd.Location = new System.Drawing.Point(3, 3);
            this.TBPwd.Name = "TBPwd";
            this.TBPwd.Size = new System.Drawing.Size(432, 22);
            this.TBPwd.TabIndex = 3;
            this.TBPwd.WordWrap = false;
            // 
            // PwdForm
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 77);
            this.Controls.Add(this.TLPPwd);
            this.Name = "PwdForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter password:";
            this.Load += new System.EventHandler(this.PwdForm_Load);
            this.TLPPwd.ResumeLayout(false);
            this.TLPPwd.PerformLayout();
            this.TLPPwdActs.ResumeLayout(false);
            this.TLPPwdActs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPPwd;
        private System.Windows.Forms.TableLayoutPanel TLPPwdActs;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.CheckBox CBShow;
        private System.Windows.Forms.TextBox TBPwd;
    }
}