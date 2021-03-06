﻿namespace SortForm_v1
{
    partial class frmSort
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
            this.lstSorted = new System.Windows.Forms.ListBox();
            this.grSorted = new System.Windows.Forms.GroupBox();
            this.grpUnsorted = new System.Windows.Forms.GroupBox();
            this.lstUnsorted = new System.Windows.Forms.ListBox();
            this.grpTools = new System.Windows.Forms.GroupBox();
            this.rdDsc = new System.Windows.Forms.RadioButton();
            this.rdAsc = new System.Windows.Forms.RadioButton();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.btnData = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblListSize = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grSorted.SuspendLayout();
            this.grpUnsorted.SuspendLayout();
            this.grpTools.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSorted
            // 
            this.lstSorted.FormattingEnabled = true;
            this.lstSorted.Location = new System.Drawing.Point(6, 19);
            this.lstSorted.Name = "lstSorted";
            this.lstSorted.Size = new System.Drawing.Size(281, 407);
            this.lstSorted.TabIndex = 1;
            // 
            // grSorted
            // 
            this.grSorted.Controls.Add(this.lstSorted);
            this.grSorted.Location = new System.Drawing.Point(311, 2);
            this.grSorted.Name = "grSorted";
            this.grSorted.Size = new System.Drawing.Size(293, 485);
            this.grSorted.TabIndex = 3;
            this.grSorted.TabStop = false;
            this.grSorted.Text = "groupSorted";
            // 
            // grpUnsorted
            // 
            this.grpUnsorted.Controls.Add(this.lstUnsorted);
            this.grpUnsorted.Location = new System.Drawing.Point(12, 2);
            this.grpUnsorted.Name = "grpUnsorted";
            this.grpUnsorted.Size = new System.Drawing.Size(293, 485);
            this.grpUnsorted.TabIndex = 4;
            this.grpUnsorted.TabStop = false;
            this.grpUnsorted.Text = "groupUnsorted";
            // 
            // lstUnsorted
            // 
            this.lstUnsorted.FormattingEnabled = true;
            this.lstUnsorted.Location = new System.Drawing.Point(6, 19);
            this.lstUnsorted.Name = "lstUnsorted";
            this.lstUnsorted.Size = new System.Drawing.Size(281, 407);
            this.lstUnsorted.TabIndex = 1;
            // 
            // grpTools
            // 
            this.grpTools.Controls.Add(this.lblListSize);
            this.grpTools.Controls.Add(this.rdDsc);
            this.grpTools.Controls.Add(this.rdAsc);
            this.grpTools.Controls.Add(this.btnFile);
            this.grpTools.Controls.Add(this.btnClear);
            this.grpTools.Controls.Add(this.btnDone);
            this.grpTools.Controls.Add(this.cmbSort);
            this.grpTools.Controls.Add(this.btnData);
            this.grpTools.Controls.Add(this.txtData);
            this.grpTools.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpTools.Location = new System.Drawing.Point(610, 12);
            this.grpTools.Name = "grpTools";
            this.grpTools.Size = new System.Drawing.Size(238, 289);
            this.grpTools.TabIndex = 5;
            this.grpTools.TabStop = false;
            this.grpTools.Text = "Tools";
            // 
            // rdDsc
            // 
            this.rdDsc.AutoSize = true;
            this.rdDsc.Location = new System.Drawing.Point(114, 107);
            this.rdDsc.Name = "rdDsc";
            this.rdDsc.Size = new System.Drawing.Size(82, 17);
            this.rdDsc.TabIndex = 7;
            this.rdDsc.TabStop = true;
            this.rdDsc.Text = "Descending";
            this.rdDsc.UseVisualStyleBackColor = true;
            // 
            // rdAsc
            // 
            this.rdAsc.AutoSize = true;
            this.rdAsc.Checked = true;
            this.rdAsc.Location = new System.Drawing.Point(9, 107);
            this.rdAsc.Name = "rdAsc";
            this.rdAsc.Size = new System.Drawing.Size(75, 17);
            this.rdAsc.TabIndex = 6;
            this.rdAsc.TabStop = true;
            this.rdAsc.Text = "Ascending";
            this.rdAsc.UseVisualStyleBackColor = true;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(68, 215);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 5;
            this.btnFile.Text = "Open File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(7, 141);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(197, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.Enabled = false;
            this.btnDone.Location = new System.Drawing.Point(6, 173);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(198, 23);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cmbSort
            // 
            this.cmbSort.BackColor = System.Drawing.SystemColors.Window;
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(6, 61);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(198, 21);
            this.cmbSort.TabIndex = 2;
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(112, 19);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(92, 20);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "Enter";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(6, 19);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // lblListSize
            // 
            this.lblListSize.AutoSize = true;
            this.lblListSize.ForeColor = System.Drawing.Color.DarkRed;
            this.lblListSize.Location = new System.Drawing.Point(6, 273);
            this.lblListSize.Name = "lblListSize";
            this.lblListSize.Size = new System.Drawing.Size(10, 13);
            this.lblListSize.TabIndex = 8;
            this.lblListSize.Text = " ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(860, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(712, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Lincoln Gachagua";
            // 
            // frmSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 464);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpTools);
            this.Controls.Add(this.grpUnsorted);
            this.Controls.Add(this.grSorted);
            this.Name = "frmSort";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSort_Load);
            this.grSorted.ResumeLayout(false);
            this.grpUnsorted.ResumeLayout(false);
            this.grpTools.ResumeLayout(false);
            this.grpTools.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstSorted;
        private System.Windows.Forms.GroupBox grSorted;
        private System.Windows.Forms.GroupBox grpUnsorted;
        private System.Windows.Forms.ListBox lstUnsorted;
        private System.Windows.Forms.GroupBox grpTools;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rdDsc;
        private System.Windows.Forms.RadioButton rdAsc;
        private System.Windows.Forms.Label lblListSize;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

