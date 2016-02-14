namespace Cheer.Utilities.GuidGen
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.usageLabel = new System.Windows.Forms.Label();
            this.newGuidButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBoxContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.selAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMostCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.formatGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsGroupBox.SuspendLayout();
            this.resultTextBoxContextMenuStrip.SuspendLayout();
            this.formatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // usageLabel
            // 
            this.usageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usageLabel.Location = new System.Drawing.Point(12, 9);
            this.usageLabel.Name = "usageLabel";
            this.usageLabel.Size = new System.Drawing.Size(380, 70);
            this.usageLabel.TabIndex = 0;
            this.usageLabel.Text = "usageLabel";
            // 
            // newGuidButton
            // 
            this.newGuidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newGuidButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.newGuidButton.Location = new System.Drawing.Point(302, 276);
            this.newGuidButton.Name = "newGuidButton";
            this.newGuidButton.Size = new System.Drawing.Size(90, 23);
            this.newGuidButton.TabIndex = 4;
            this.newGuidButton.Text = "newGuidButton";
            this.newGuidButton.UseVisualStyleBackColor = true;
            this.newGuidButton.Click += new System.EventHandler(this.newGuidButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.copyButton.Location = new System.Drawing.Point(206, 276);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(90, 23);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "copyButton";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // formatComboBox
            // 
            this.formatComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formatComboBox.DisplayMember = "Name";
            this.formatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Location = new System.Drawing.Point(6, 22);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(368, 23);
            this.formatComboBox.TabIndex = 3;
            this.formatComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsGroupBox.Controls.Add(this.resultTextBox);
            this.resultsGroupBox.Location = new System.Drawing.Point(12, 179);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(380, 91);
            this.resultsGroupBox.TabIndex = 2;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "resultsGroupBox";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.ContextMenuStrip = this.resultTextBoxContextMenuStrip;
            this.resultTextBox.DataBindings.Add(new System.Windows.Forms.Binding("WordWrap", global::Cheer.Utilities.GuidGen.Properties.Settings.Default, "MainFormResultTextBoxWordWrap", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.resultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(3, 19);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ShortcutsEnabled = false;
            this.resultTextBox.Size = new System.Drawing.Size(374, 69);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.WordWrap = global::Cheer.Utilities.GuidGen.Properties.Settings.Default.MainFormResultTextBoxWordWrap;
            // 
            // resultTextBoxContextMenuStrip
            // 
            this.resultTextBoxContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.copyAllToolStripMenuItem,
            this.toolStripMenuItem1,
            this.selAllToolStripMenuItem,
            this.toolStripMenuItem2,
            this.wordWrapToolStripMenuItem});
            this.resultTextBoxContextMenuStrip.Name = "resultTextBoxContextMenuStrip";
            this.resultTextBoxContextMenuStrip.Size = new System.Drawing.Size(264, 104);
            this.resultTextBoxContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.resultTextBoxContextMenuStrip_Opening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.copyToolStripMenuItem.Text = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.copyAllToolStripMenuItem.Text = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(260, 6);
            // 
            // selAllToolStripMenuItem
            // 
            this.selAllToolStripMenuItem.Name = "selAllToolStripMenuItem";
            this.selAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selAllToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.selAllToolStripMenuItem.Text = "selAllToolStripMenuItem";
            this.selAllToolStripMenuItem.Click += new System.EventHandler(this.selAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(260, 6);
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.CheckOnClick = true;
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.wordWrapToolStripMenuItem.Text = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // topMostCheckBox
            // 
            this.topMostCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topMostCheckBox.Checked = global::Cheer.Utilities.GuidGen.Properties.Settings.Default.MainFormTopMost;
            this.topMostCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Cheer.Utilities.GuidGen.Properties.Settings.Default, "MainFormTopMost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.topMostCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.topMostCheckBox.Location = new System.Drawing.Point(12, 276);
            this.topMostCheckBox.Name = "topMostCheckBox";
            this.topMostCheckBox.Size = new System.Drawing.Size(188, 23);
            this.topMostCheckBox.TabIndex = 6;
            this.topMostCheckBox.Text = "topMostCheckBox";
            this.topMostCheckBox.UseVisualStyleBackColor = true;
            this.topMostCheckBox.CheckedChanged += new System.EventHandler(this.topMostCheckBox_CheckedChanged);
            // 
            // formatGroupBox
            // 
            this.formatGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formatGroupBox.Controls.Add(this.formatComboBox);
            this.formatGroupBox.Location = new System.Drawing.Point(15, 82);
            this.formatGroupBox.Name = "formatGroupBox";
            this.formatGroupBox.Size = new System.Drawing.Size(380, 91);
            this.formatGroupBox.TabIndex = 1;
            this.formatGroupBox.TabStop = false;
            this.formatGroupBox.Text = "formatGroupBox";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(404, 311);
            this.Controls.Add(this.formatGroupBox);
            this.Controls.Add(this.topMostCheckBox);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.newGuidButton);
            this.Controls.Add(this.usageLabel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("TopMost", global::Cheer.Utilities.GuidGen.Properties.Settings.Default, "MainFormTopMost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 350);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUID Generator (Version 1.0)";
            this.TopMost = global::Cheer.Utilities.GuidGen.Properties.Settings.Default.MainFormTopMost;
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.resultTextBoxContextMenuStrip.ResumeLayout(false);
            this.formatGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usageLabel;
        private System.Windows.Forms.Button newGuidButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.CheckBox topMostCheckBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip resultTextBoxContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.GroupBox formatGroupBox;
    }
}

