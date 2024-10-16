namespace psk33p
{
    partial class DlgKeyValue
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
            this.TLP = new System.Windows.Forms.TableLayoutPanel();
            this.GBValue = new System.Windows.Forms.GroupBox();
            this.TBValue = new System.Windows.Forms.TextBox();
            this.TLPOkCancel = new System.Windows.Forms.TableLayoutPanel();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CBShow = new System.Windows.Forms.CheckBox();
            this.GBKey = new System.Windows.Forms.GroupBox();
            this.TBKey = new System.Windows.Forms.TextBox();
            this.TLP.SuspendLayout();
            this.GBValue.SuspendLayout();
            this.TLPOkCancel.SuspendLayout();
            this.GBKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP
            // 
            this.TLP.ColumnCount = 1;
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.Controls.Add(this.GBValue, 0, 1);
            this.TLP.Controls.Add(this.TLPOkCancel, 0, 2);
            this.TLP.Controls.Add(this.GBKey, 0, 0);
            this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP.Location = new System.Drawing.Point(0, 0);
            this.TLP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TLP.Name = "TLP";
            this.TLP.RowCount = 3;
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.TLP.Size = new System.Drawing.Size(483, 168);
            this.TLP.TabIndex = 0;
            // 
            // GBValue
            // 
            this.GBValue.Controls.Add(this.TBValue);
            this.GBValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBValue.Location = new System.Drawing.Point(4, 65);
            this.GBValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBValue.Name = "GBValue";
            this.GBValue.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBValue.Size = new System.Drawing.Size(475, 53);
            this.GBValue.TabIndex = 3;
            this.GBValue.TabStop = false;
            this.GBValue.Text = "Value";
            // 
            // TBValue
            // 
            this.TBValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBValue.Location = new System.Drawing.Point(4, 24);
            this.TBValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBValue.Name = "TBValue";
            this.TBValue.Size = new System.Drawing.Size(467, 27);
            this.TBValue.TabIndex = 1;
            this.TBValue.WordWrap = false;
            // 
            // TLPOkCancel
            // 
            this.TLPOkCancel.ColumnCount = 3;
            this.TLPOkCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPOkCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPOkCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPOkCancel.Controls.Add(this.BtnOK, 2, 0);
            this.TLPOkCancel.Controls.Add(this.BtnCancel, 1, 0);
            this.TLPOkCancel.Controls.Add(this.CBShow, 0, 0);
            this.TLPOkCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPOkCancel.Location = new System.Drawing.Point(4, 126);
            this.TLPOkCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TLPOkCancel.Name = "TLPOkCancel";
            this.TLPOkCancel.RowCount = 1;
            this.TLPOkCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPOkCancel.Size = new System.Drawing.Size(475, 38);
            this.TLPOkCancel.TabIndex = 0;
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOK.Location = new System.Drawing.Point(320, 4);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(151, 30);
            this.BtnOK.TabIndex = 8;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Location = new System.Drawing.Point(162, 4);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(150, 30);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // CBShow
            // 
            this.CBShow.AutoSize = true;
            this.CBShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBShow.Location = new System.Drawing.Point(4, 4);
            this.CBShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBShow.Name = "CBShow";
            this.CBShow.Size = new System.Drawing.Size(150, 30);
            this.CBShow.TabIndex = 0;
            this.CBShow.Text = "Show";
            this.CBShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CBShow.UseVisualStyleBackColor = true;
            this.CBShow.CheckedChanged += new System.EventHandler(this.CBShow_CheckedChanged);
            // 
            // GBKey
            // 
            this.GBKey.Controls.Add(this.TBKey);
            this.GBKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBKey.Location = new System.Drawing.Point(4, 4);
            this.GBKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBKey.Name = "GBKey";
            this.GBKey.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBKey.Size = new System.Drawing.Size(475, 53);
            this.GBKey.TabIndex = 1;
            this.GBKey.TabStop = false;
            this.GBKey.Text = "Key";
            // 
            // TBKey
            // 
            this.TBKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBKey.Location = new System.Drawing.Point(4, 24);
            this.TBKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBKey.Name = "TBKey";
            this.TBKey.Size = new System.Drawing.Size(467, 27);
            this.TBKey.TabIndex = 0;
            this.TBKey.WordWrap = false;
            // 
            // DlgKeyValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 168);
            this.Controls.Add(this.TLP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DlgKeyValue";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DlgKeyValue_Load);
            this.TLP.ResumeLayout(false);
            this.GBValue.ResumeLayout(false);
            this.GBValue.PerformLayout();
            this.TLPOkCancel.ResumeLayout(false);
            this.TLPOkCancel.PerformLayout();
            this.GBKey.ResumeLayout(false);
            this.GBKey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP;
        private System.Windows.Forms.TableLayoutPanel TLPOkCancel;
        private System.Windows.Forms.GroupBox GBKey;
        private System.Windows.Forms.GroupBox GBValue;
        public System.Windows.Forms.TextBox TBKey;
        public System.Windows.Forms.TextBox TBValue;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.CheckBox CBShow;
    }
}