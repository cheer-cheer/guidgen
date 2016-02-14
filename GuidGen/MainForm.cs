using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cheer.Utilities.GuidGen.Core;
using Cheer.Utilities.GuidGen.Core.Formatters;
using Cheer.Utilities.GuidGen.Properties;
using System.Globalization;
using Cheer.Utilities.GuidGen.Localization;

namespace Cheer.Utilities.GuidGen
{
    public partial class MainForm : Form
    {
        private GuidManager guidManager;

        public MainForm()
        {
            guidManager = new GuidManager();

            InitializeComponent();

            Localize();
            LoadFormatters();

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            LoadSettings();
        }

        private void Localize()
        {
            Text = SR.ApplicationTitle;
            usageLabel.Text = SR.MainForm_UsageLabelText;
            formatGroupBox.Text = SR.MainForm_FormatGroupBoxText;
            resultsGroupBox.Text = SR.MainForm_ResultsGroupBoxText;
            topMostCheckBox.Text = SR.MainForm_TopMostCheckBoxText;
            copyButton.Text = SR.MainForm_CopyButtonText;
            newGuidButton.Text = SR.MainForm_NewGuidButtonText;
            copyToolStripMenuItem.Text = SR.MainForm_CopyToolStripMenuItemText;
            copyAllToolStripMenuItem.Text = SR.MainForm_CopyAllToolStipMenuItemText;
            selAllToolStripMenuItem.Text = SR.MainForm_SelAllToolStripMenuItemText;
            wordWrapToolStripMenuItem.Text = SR.MainForm_WordWrapToolStripMenuItemText;

            toolTip.SetToolTip(topMostCheckBox, SR.MainForm_TopMostCheckBoxToolTip);
        }

        private void LoadSettings()
        {
            var settings = Settings.Default;

            var size = settings.MainFormSize;
            Size = size;
            int i = settings.MainFormFormatComboBoxSelectedIndex;
            if (i > 0 && i < formatComboBox.Items.Count)
            {
                formatComboBox.SelectedIndex = i;
            }
            
            var location = settings.MainFormLocation;
            if (location != null)
            {
                Location = location.Value;
            }
        }
        private void SaveSettings()
        {
            var settings = Settings.Default;
            settings.MainFormTopMost = TopMost;
            settings.MainFormResultTextBoxWordWrap = resultTextBox.WordWrap;
            settings.MainFormSize = Size;
            settings.MainFormLocation = Location;
            settings.MainFormFormatComboBoxSelectedIndex = formatComboBox.SelectedIndex;
            settings.Save();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            SaveSettings();
        }

        private void LoadFormatters()
        {
            formatComboBox.SuspendLayout();
            foreach (var formatter in guidManager.Formatters)
            {
                formatComboBox.Items.Add(formatter);
            }
            if (formatComboBox.Items.Count > 0)
            {
                formatComboBox.SelectedIndex = 0;
            }
            formatComboBox.ResumeLayout();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGuidFormatResult();
        }
        private void RefreshGuidFormatResult()
        {
            var formatter = formatComboBox.SelectedItem as IGuidFormatter;
            if (formatter != null)
            {
                resultTextBox.Text = guidManager.Format(formatter);
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            var result = resultTextBox.Text;
            if (!string.IsNullOrEmpty(result))
            {
                Clipboard.SetText(result, TextDataFormat.UnicodeText);
            }
        }

        private void newGuidButton_Click(object sender, EventArgs e)
        {
            guidManager.NewGuid();
            RefreshGuidFormatResult();
        }

        private void topMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void resultTextBoxContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            resultTextBox.Focus();

            var selectionLength =  resultTextBox.SelectionLength;
            copyToolStripMenuItem.Enabled = selectionLength > 0;
            selAllToolStripMenuItem.Enabled = selectionLength != resultTextBox.TextLength;
            wordWrapToolStripMenuItem.Checked = resultTextBox.WordWrap;
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultTextBox.WordWrap = wordWrapToolStripMenuItem.Checked;
        }

        private void selAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultTextBox.SelectAll();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var text = resultTextBox.SelectedText;
            if (!string.IsNullOrEmpty(text))
            {
                Clipboard.SetText(text, TextDataFormat.UnicodeText);
            }
        }

        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyButton.PerformClick();
        }
    }
}
