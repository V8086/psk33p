namespace psk33p
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTS = new System.Windows.Forms.ToolStrip();
            this.MainTSDD = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainSCItems = new System.Windows.Forms.SplitContainer();
            this.MainGBItems = new System.Windows.Forms.GroupBox();
            this.MainLBItems = new System.Windows.Forms.ListBox();
            this.MainGBManage = new System.Windows.Forms.GroupBox();
            this.MainTLPManage = new System.Windows.Forms.TableLayoutPanel();
            this.MainBtnCopyValue = new System.Windows.Forms.Button();
            this.MainBtnAdd = new System.Windows.Forms.Button();
            this.MainBtnDelete = new System.Windows.Forms.Button();
            this.MainBtnEdit = new System.Windows.Forms.Button();
            this.MainTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSCItems)).BeginInit();
            this.MainSCItems.Panel1.SuspendLayout();
            this.MainSCItems.Panel2.SuspendLayout();
            this.MainSCItems.SuspendLayout();
            this.MainGBItems.SuspendLayout();
            this.MainGBManage.SuspendLayout();
            this.MainTLPManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTS
            // 
            this.MainTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainTS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainTSDD});
            this.MainTS.Location = new System.Drawing.Point(0, 0);
            this.MainTS.Name = "MainTS";
            this.MainTS.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainTS.Size = new System.Drawing.Size(284, 31);
            this.MainTS.TabIndex = 0;
            // 
            // MainTSDD
            // 
            this.MainTSDD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainTSDD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MainTSDD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.createToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.MainTSDD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainTSDD.Name = "MainTSDD";
            this.MainTSDD.Size = new System.Drawing.Size(48, 25);
            this.MainTSDD.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.saveAsToolStripMenuItem.Text = "Save as ...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // MainSCItems
            // 
            this.MainSCItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSCItems.Location = new System.Drawing.Point(0, 31);
            this.MainSCItems.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MainSCItems.Name = "MainSCItems";
            this.MainSCItems.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSCItems.Panel1
            // 
            this.MainSCItems.Panel1.Controls.Add(this.MainGBItems);
            // 
            // MainSCItems.Panel2
            // 
            this.MainSCItems.Panel2.Controls.Add(this.MainGBManage);
            this.MainSCItems.Size = new System.Drawing.Size(284, 325);
            this.MainSCItems.SplitterDistance = 169;
            this.MainSCItems.SplitterWidth = 5;
            this.MainSCItems.TabIndex = 1;
            // 
            // MainGBItems
            // 
            this.MainGBItems.Controls.Add(this.MainLBItems);
            this.MainGBItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGBItems.Location = new System.Drawing.Point(0, 0);
            this.MainGBItems.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MainGBItems.Name = "MainGBItems";
            this.MainGBItems.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MainGBItems.Size = new System.Drawing.Size(284, 169);
            this.MainGBItems.TabIndex = 1;
            this.MainGBItems.TabStop = false;
            this.MainGBItems.Text = "Items";
            // 
            // MainLBItems
            // 
            this.MainLBItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainLBItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLBItems.FormattingEnabled = true;
            this.MainLBItems.ItemHeight = 20;
            this.MainLBItems.Location = new System.Drawing.Point(4, 22);
            this.MainLBItems.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MainLBItems.Name = "MainLBItems";
            this.MainLBItems.Size = new System.Drawing.Size(276, 145);
            this.MainLBItems.TabIndex = 0;
            // 
            // MainGBManage
            // 
            this.MainGBManage.Controls.Add(this.MainTLPManage);
            this.MainGBManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGBManage.Location = new System.Drawing.Point(0, 0);
            this.MainGBManage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MainGBManage.Name = "MainGBManage";
            this.MainGBManage.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MainGBManage.Size = new System.Drawing.Size(284, 151);
            this.MainGBManage.TabIndex = 2;
            this.MainGBManage.TabStop = false;
            this.MainGBManage.Text = "Manage";
            // 
            // MainTLPManage
            // 
            this.MainTLPManage.ColumnCount = 1;
            this.MainTLPManage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTLPManage.Controls.Add(this.MainBtnCopyValue, 0, 3);
            this.MainTLPManage.Controls.Add(this.MainBtnAdd, 0, 2);
            this.MainTLPManage.Controls.Add(this.MainBtnDelete, 0, 1);
            this.MainTLPManage.Controls.Add(this.MainBtnEdit, 0, 0);
            this.MainTLPManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTLPManage.Location = new System.Drawing.Point(4, 22);
            this.MainTLPManage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MainTLPManage.Name = "MainTLPManage";
            this.MainTLPManage.RowCount = 4;
            this.MainTLPManage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTLPManage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTLPManage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTLPManage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTLPManage.Size = new System.Drawing.Size(276, 127);
            this.MainTLPManage.TabIndex = 0;
            // 
            // MainBtnCopyValue
            // 
            this.MainBtnCopyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBtnCopyValue.Enabled = false;
            this.MainBtnCopyValue.Location = new System.Drawing.Point(4, 95);
            this.MainBtnCopyValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MainBtnCopyValue.Name = "MainBtnCopyValue";
            this.MainBtnCopyValue.Size = new System.Drawing.Size(268, 30);
            this.MainBtnCopyValue.TabIndex = 3;
            this.MainBtnCopyValue.Text = "Copy value";
            this.MainBtnCopyValue.UseVisualStyleBackColor = true;
            this.MainBtnCopyValue.Click += new System.EventHandler(this.MainBtnCopyValue_Click);
            // 
            // MainBtnAdd
            // 
            this.MainBtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBtnAdd.Enabled = false;
            this.MainBtnAdd.Location = new System.Drawing.Point(4, 64);
            this.MainBtnAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MainBtnAdd.Name = "MainBtnAdd";
            this.MainBtnAdd.Size = new System.Drawing.Size(268, 27);
            this.MainBtnAdd.TabIndex = 2;
            this.MainBtnAdd.Text = "Add";
            this.MainBtnAdd.UseVisualStyleBackColor = true;
            this.MainBtnAdd.Click += new System.EventHandler(this.MainBtnAdd_Click);
            // 
            // MainBtnDelete
            // 
            this.MainBtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBtnDelete.Enabled = false;
            this.MainBtnDelete.Location = new System.Drawing.Point(4, 33);
            this.MainBtnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MainBtnDelete.Name = "MainBtnDelete";
            this.MainBtnDelete.Size = new System.Drawing.Size(268, 27);
            this.MainBtnDelete.TabIndex = 1;
            this.MainBtnDelete.Text = "Delete";
            this.MainBtnDelete.UseVisualStyleBackColor = true;
            this.MainBtnDelete.Click += new System.EventHandler(this.MainBtnDelete_Click);
            // 
            // MainBtnEdit
            // 
            this.MainBtnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBtnEdit.Enabled = false;
            this.MainBtnEdit.Location = new System.Drawing.Point(4, 2);
            this.MainBtnEdit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MainBtnEdit.Name = "MainBtnEdit";
            this.MainBtnEdit.Size = new System.Drawing.Size(268, 27);
            this.MainBtnEdit.TabIndex = 0;
            this.MainBtnEdit.Text = "Edit";
            this.MainBtnEdit.UseVisualStyleBackColor = true;
            this.MainBtnEdit.Click += new System.EventHandler(this.MainBtnEdit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 356);
            this.Controls.Add(this.MainSCItems);
            this.Controls.Add(this.MainTS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P.Keeper (psk33p)";
            this.MainTS.ResumeLayout(false);
            this.MainTS.PerformLayout();
            this.MainSCItems.Panel1.ResumeLayout(false);
            this.MainSCItems.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSCItems)).EndInit();
            this.MainSCItems.ResumeLayout(false);
            this.MainGBItems.ResumeLayout(false);
            this.MainGBManage.ResumeLayout(false);
            this.MainTLPManage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainTS;
        private System.Windows.Forms.ToolStripDropDownButton MainTSDD;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer MainSCItems;
        private System.Windows.Forms.GroupBox MainGBItems;
        private System.Windows.Forms.ListBox MainLBItems;
        private System.Windows.Forms.GroupBox MainGBManage;
        private System.Windows.Forms.TableLayoutPanel MainTLPManage;
        private System.Windows.Forms.Button MainBtnCopyValue;
        private System.Windows.Forms.Button MainBtnAdd;
        private System.Windows.Forms.Button MainBtnDelete;
        private System.Windows.Forms.Button MainBtnEdit;
    }
}

