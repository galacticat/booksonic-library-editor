using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Booksonic_Editor
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            libraryPath_value.Text = Properties.Settings.Default.libraryPath;
            javaPath_value.Text = Properties.Settings.Default.javaPath;
            scriptPath_value.Text = Properties.Settings.Default.scriptPath;
            save_button.Enabled = false;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.libraryPath = libraryPath_value.Text;
            Properties.Settings.Default.javaPath = javaPath_value.Text;
            Properties.Settings.Default.scriptPath = scriptPath_value.Text;
            Properties.Settings.Default.Save();
            save_button.Enabled = false;
        }

        private void libraryPath_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog choofldlog = new FolderBrowserDialog();
            DialogResult result = choofldlog.ShowDialog();
            if (result == DialogResult.OK)
            {
                libraryPath_value.Text = choofldlog.SelectedPath;
                save_button.Enabled = true;
            }
        }

        private void javaPath_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Executable (*.exe)|*.exe|All files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            DialogResult result = choofdlog.ShowDialog();
            if (result == DialogResult.OK)
            {
                javaPath_value.Text = choofdlog.FileName;
                save_button.Enabled = true;
            }
        }

        private void scriptPath_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Java Script (*.jar)|*.jar|All files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            DialogResult result = choofdlog.ShowDialog();
            if (result == DialogResult.OK)
            {
                scriptPath_value.Text = choofdlog.FileName;
                save_button.Enabled = true;
            }
        }

        private void libraryPath_value_TextChanged(object sender, EventArgs e)
        {
            save_button.Enabled = true;
        }

        private void javaPath_value_TextChanged(object sender, EventArgs e)
        {
            save_button.Enabled = true;
        }

        private void scriptPath_value_TextChanged(object sender, EventArgs e)
        {
            save_button.Enabled = true;
        }
    }
}
