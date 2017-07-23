using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Booksonic_Editor
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();            
            //Enables hot keys handler
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(search_button, "Applies the search filter" + Environment.NewLine + "Hotkey: Enter");
            toolTip1.SetToolTip(previousNode_button, "Selects the previous book from the tree" + Environment.NewLine + "Hotkey: Page Up");
            toolTip1.SetToolTip(nextNode_button, "Selects the next book from the tree" + Environment.NewLine + "Hotkey: Page Down");
            toolTip1.SetToolTip(save_button, "Saves the reader.txt and desc.txt" + Environment.NewLine + "Hotkey: Ctrl+S");
            toolTip1.SetToolTip(script_button, "Script Runs with the following syntax:" + Environment.NewLine + "<Java Path> -jar <Script Path> <Library Path>");
            toolTip1.SetToolTip(coverPath_button, "Select the image to be used as the cover");
            toolTip1.SetToolTip(coverPictureBox, "Click to see full image");
            toolTip1.SetToolTip(refresh_button, "Reloads the Library Path");
            toolTip1.SetToolTip(open_button, "Opens the Book Path");
            toolTip1.SetToolTip(configure_button, "Set the path to the Library, Java Executable, and Script");
        }

        // Hot keys handler
        void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S && save_button.Enabled)       // Ctrl-S Save
            {
                save_button.PerformClick();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }

            else if (e.KeyCode == Keys.Enter && (search_textBox.Focused || library_list.Focused) && search_textBox.Text != String.Empty)
            {
                search_button.PerformClick();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }

            else if (e.KeyCode == Keys.PageDown)
            {
                nextNode_button.PerformClick();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }

            else if (e.KeyCode == Keys.PageUp)
            {
                previousNode_button.PerformClick();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }
        }

        //Load Scripts
        public void Editor_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
            timer1.Start();
            Properties.Settings.Default.tempCoverPath = String.Empty;
            Properties.Settings.Default.Save();
            imageToLoad_value.Visible = false;
            if (Properties.Settings.Default.scriptPath != String.Empty)
            {
                this.script_button.Enabled = true;
            }
            else
            {
                this.script_button.Enabled = false;
            }
        }
                
        public void refresh_button_Click(object sender, EventArgs e)
        {
            Load_Library(e, e);
        }

        private void configure_button_Click(object sender, EventArgs e)
        {
            Booksonic_Editor.Configuration settingsForm = new Configuration();
            Configuration yeniform = new Configuration();
            yeniform.FormClosing += new FormClosingEventHandler(this.Configuration_FormClosing);
            yeniform.Show();
        }

        private void Configuration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Load_Library(e, e);
            if (Properties.Settings.Default.scriptPath != String.Empty)
            {
                this.script_button.Enabled = true;
            }
            else
            {
                this.script_button.Enabled = false;
            }
        }

        private void BookData_textBox_TextChanged(object sender, EventArgs e)
        {
            if ((reader_textBox.Text != String.Empty|| reader_textBox.Text !=null) && (desc_textBox.Text != String.Empty||desc_textBox.Text != null) && (library_list.SelectedNode.Nodes.Count == 0))
            {
                save_button.Enabled = true;
            }
            else { 
            save_button.Enabled = false;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string selectPath = library_list.SelectedNode.FullPath.ToString();
            string fullPath = Properties.Settings.Default.libraryPath + @"\" + selectPath;
            string readerPath = fullPath + @"\reader.txt";
            string tempCoverPath = Properties.Settings.Default.tempCoverPath;
            string descPath = fullPath + @"\desc.txt";
            File.WriteAllText(readerPath, reader_textBox.Text);
            desc_textBox.SaveFile(descPath, RichTextBoxStreamType.PlainText);
            if (tempCoverPath != String.Empty)
            { 
                System.IO.File.Copy(tempCoverPath,cover_textBox.Text);
                Properties.Settings.Default.tempCoverPath = String.Empty;
                Properties.Settings.Default.Save();
                imageToLoad_value.Visible = false;
            }
            save_button.Enabled = false;
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            string selectPath = library_list.SelectedNode.FullPath.ToString();
            string fullPath = Properties.Settings.Default.libraryPath + @"\" + selectPath;
            if (Directory.Exists(fullPath))
            {
                System.Diagnostics.Process.Start(fullPath);
            }
            else
            {
                MessageBox.Show(String.Concat("Can not find:",Environment.NewLine,fullPath));
            }
        }

        private List<TreeNode> CurrentNodeMatches = new List<TreeNode>();

        private int LastNodeIndex = 0;

        private string LastSearchText;

        private void search_button_Click(object sender, EventArgs e)
        {
            string searchText = search_textBox.Text;
            if (String.IsNullOrEmpty(searchText))
            {
                return;
            };

            if (LastSearchText != searchText)
            {
                //It's a new Search
                CurrentNodeMatches.Clear();
                LastSearchText = searchText;
                LastNodeIndex = 0;
                SearchNodes(searchText, library_list.Nodes[0]);
            }

            if (LastNodeIndex >= 0 && CurrentNodeMatches.Count > 0 && LastNodeIndex < CurrentNodeMatches.Count)
            {
                TreeNode selectedNode = CurrentNodeMatches[LastNodeIndex];
                LastNodeIndex++;
                this.library_list.SelectedNode = selectedNode;
                this.library_list.SelectedNode.Expand();
                this.library_list.Select();
            }
        }

        private void expandAll_button_Click(object sender, EventArgs e)
        {
            library_list.Select();
            if (library_list.SelectedNode != null)
            {
                var tempNode = library_list.SelectedNode;
                library_list.ExpandAll();
                library_list.SelectedNode = tempNode;
                library_list.SelectedNode.EnsureVisible();
            }
        }

        private void collapseAll_button_Click(object sender, EventArgs e)
        {
            library_list.Select();
            if (library_list.SelectedNode != null)
            {
                var tempNode = library_list.SelectedNode;
                library_list.CollapseAll();
                library_list.SelectedNode = tempNode;
                library_list.SelectedNode.EnsureVisible();
            }
        }

        private void previousNode_button_Click(object sender, EventArgs e)
        {
            if (library_list.SelectedNode != null && library_list.SelectedNode.PrevVisibleNode != null)
            {
                library_list.SelectedNode = library_list.SelectedNode.PrevVisibleNode;
                if (library_list.SelectedNode.Nodes.Count != 0)
                {
                    previousNode_button_Click(e, e);
                }
            }
        }

        private void nextNode_button_Click(object sender, EventArgs e)
        {
            if (library_list.SelectedNode != null && library_list.SelectedNode.NextVisibleNode != null)
            {
                library_list.SelectedNode = library_list.SelectedNode.NextVisibleNode;
                if (library_list.SelectedNode.Nodes.Count != 0)
                {
                    nextNode_button_Click(e, e);
                }
            }

        }

        public void Load_Library(object sender, EventArgs e)
        {
            this.libraryLoad_progressbar.Visible = true;
            this.libraryLoad_progressbar.Step = 1;
            this.library_list.Nodes.Clear();
            string yourRoot = Properties.Settings.Default.libraryPath;
            if (System.IO.Directory.Exists(yourRoot))
            {
                Cursor.Current = Cursors.WaitCursor;
                this.library_list.Nodes.AddRange(getAllFolderNodes(yourRoot).ToArray());
                this.libraryLoad_progressbar.PerformStep();
                this.library_list.Sort();
                this.libraryLoad_progressbar.PerformStep();
                Cursor.Current = Cursors.Default;
                this.LibraryPath_value.Text = Properties.Settings.Default.libraryPath;
            }
            else
            {
                this.LibraryPath_value.Text = "Directory Not Found";
            }
            this.libraryLoad_progressbar.Visible = false;
        }

        List<TreeNode> getAllFolderNodes(string dir)
        {
            var dirs = Directory.GetDirectories(dir).ToArray();
            this.libraryLoad_progressbar.Maximum = dirs.Count() + 2;
            var nodes = new List<TreeNode>();
            foreach (string d in dirs)
            {
                DirectoryInfo di = new DirectoryInfo(d);
                TreeNode tn = new TreeNode(di.Name);
                tn.Tag = di;
                int subCount = 0;
                try { subCount = Directory.GetDirectories(d).Count(); }
                catch { /* ignore accessdenied */  }
                if (subCount > 0)
                {
                    var subNodes = getAllFolderNodes(di.FullName);
                    tn.Nodes.AddRange(subNodes.ToArray());
                }
                nodes.Add(tn);
            }
            this.libraryLoad_progressbar.PerformStep();
            return nodes;
        }

        private void library_list_AfterSelect(object sender, TreeViewEventArgs e)
        {
            open_button.Enabled = true;
            string selectPath = library_list.SelectedNode.FullPath.ToString();
            string fullPath = Properties.Settings.Default.libraryPath + @"\" + selectPath;
            string readerPath = fullPath + @"\reader.txt";
            string coverPath = fullPath + @"\cover.jpg";
            string descPath = fullPath + @"\desc.txt";
            BookPath_value.Text = fullPath;
            if (library_list.SelectedNode.Nodes.Count == 0)
            {
                reader_textBox.Enabled = true;
                cover_textBox.Enabled = true;
                coverPictureBox.Enabled = true;
                desc_textBox.Enabled = true;
                previousNode_button.Enabled = true;
                nextNode_button.Enabled = true;
                book_title.Text = library_list.SelectedNode.Text;
            }
            else
            {
                reader_textBox.Enabled = false;
                cover_textBox.Enabled = false;
                coverPictureBox.Enabled = false;
                desc_textBox.Enabled = false;
                previousNode_button.Enabled = false;
                nextNode_button.Enabled = false;
                book_title.Text = "No Selection";
                save_button.Enabled = false;
            }
            Properties.Settings.Default.tempCoverPath = String.Empty;
            Properties.Settings.Default.Save();
            imageToLoad_value.Visible = false;
            //loads the reader.txt value
            if (System.IO.File.Exists(readerPath))
            {
                reader_textBox.Text = File.ReadAllText(readerPath);     //GetTxtValue(readerPath);
            }
            else
            {
                reader_textBox.Text = String.Empty;
            }
            //loads the cover.jpg
            if (System.IO.File.Exists(coverPath))
            {
                cover_textBox.Text = coverPath;     //Sets path to cover.jpg;
                coverPictureBox.ImageLocation = coverPath;
            }
            else
            {
                cover_textBox.Text = String.Empty;
                coverPictureBox.ImageLocation = String.Empty;
            }
            //loads the desc.txt value
            if (System.IO.File.Exists(descPath))
            {
                desc_textBox.Text = File.ReadAllText(descPath);     //GetTxtValue(descPath);
            }
            else
            {
                desc_textBox.Text = String.Empty;
            }
        }

        public string GetTxtValue(string incPath)
        {
            StringBuilder sb = new StringBuilder();
            string headerLine = string.Empty;
            int currentLine = 0;
            using (StreamReader sr = new StreamReader(incPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    currentLine++;
                    if (currentLine == 1)
                    {
                        headerLine = line;
                        continue;
                    }
                    sb.Append(line);
                }
                return headerLine;
            }
        }

        private void SearchNodes(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    CurrentNodeMatches.Add(StartNode);
                };
                if (StartNode.Nodes.Count != 0)
                {
                    SearchNodes(SearchText, StartNode.Nodes[0]);//Recursive Search 
                };
                StartNode = StartNode.NextNode;
            };

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            refresh_button.PerformClick();
        }

        private void script_button_Click(object sender, EventArgs e)
        {
            string strCmdText = String.Concat("-jar ", "\"", Properties.Settings.Default.scriptPath, "\"", " ", "\"", Properties.Settings.Default.libraryPath, "\""); 
            string output;
            string error;
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = Properties.Settings.Default.javaPath;
            p.StartInfo.Arguments = strCmdText;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.Start();
            output = p.StandardOutput.ReadToEnd();
            error = p.StandardError.ReadToEnd();
            p.WaitForExit();
            if (String.IsNullOrEmpty(output))
            {
                output = "No Files Processed";
            }
            if (String.IsNullOrEmpty(error))
            {
                error = "No Errors";
            }
            MessageBox.Show(String.Concat("Output:",Environment.NewLine,Environment.NewLine, output, Environment.NewLine, "Errors:",Environment.NewLine, Environment.NewLine, error, Environment.NewLine,Environment.NewLine,"Press Ctrl+C to copy this dialog"),"Script Complete");
        }

        private void coverPath_button_Click(object sender, EventArgs e)
        {
            string selectPath = library_list.SelectedNode.FullPath.ToString();
            string fullPath = Properties.Settings.Default.libraryPath + @"\" + selectPath;
            string coverPath = fullPath + @"\cover.jpg";
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Image (*.jpg)|*.jpg|All files (*.*)|*.*";
            choofdlog.InitialDirectory = fullPath;
            choofdlog.RestoreDirectory = true;
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            DialogResult result = choofdlog.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectPath = library_list.SelectedNode.FullPath.ToString();
                //fullPath = Properties.Settings.Default.libraryPath + @"\" + selectPath;
                coverPath = fullPath + @"\cover.jpg";
                cover_textBox.Text = coverPath;
                Properties.Settings.Default.tempCoverPath = choofdlog.FileName;
                Properties.Settings.Default.Save();
                imageToLoad_value.Text = "Image to Load: "+ Properties.Settings.Default.tempCoverPath;
                imageToLoad_value.Visible = true;
                //MessageBox.Show(Properties.Settings.Default.tempCoverPath);
                coverPictureBox.ImageLocation = choofdlog.FileName;
                //string strFileName = System.IO.Path.GetFileName(coverPath);
                //string newName = choofdlog.FileName.Replace(System.IO.Path.GetFileName(choofdlog.FileName), strFileName);
                save_button.Enabled = true;
                
            }
        }

        private void coverPictureBox_Click(object sender, EventArgs e)
        {
            Form imageForm = new Form();
            imageForm.AutoSize = true;
            imageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.AutoSize = true;
            pictureBox1.ImageLocation = coverPictureBox.ImageLocation;
            imageForm.Controls.Add(pictureBox1);
            imageForm.Show();
        }
    }

}
