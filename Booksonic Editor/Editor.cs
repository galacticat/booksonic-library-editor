using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            toolTip1.SetToolTip(search_button, "Enter");

            toolTip1.SetToolTip(previousNode_button, "Page Up");
            toolTip1.SetToolTip(nextNode_button, "Page Down");
            toolTip1.SetToolTip(save_button, "Ctrl+S");

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
        }
                
        private void refresh_button_Click(object sender, EventArgs e)
        {
            Load_Library(e, e);
        }

        private void configure_button_Click(object sender, EventArgs e)
        {
            DialogResult result = LibraryBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.path = LibraryBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
                Load_Library(e, e);
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
            string fullPath = Properties.Settings.Default.path + @"\" + selectPath;
            string readerPath = fullPath + @"\reader.txt";
            string descPath = fullPath + @"\desc.txt";
            File.WriteAllText(readerPath, reader_textBox.Text);
            desc_textBox.SaveFile(descPath, RichTextBoxStreamType.PlainText);
            save_button.Enabled = false;
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            string selectPath = library_list.SelectedNode.FullPath.ToString();
            string fullPath = Properties.Settings.Default.path + @"\" + selectPath;
            System.Diagnostics.Process.Start(fullPath);
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

        private void Load_Library(object sender, EventArgs e)
        {
            libraryLoad_progressbar.Visible = true;
            libraryLoad_progressbar.Step = 1;
            library_list.Nodes.Clear();
            string yourRoot = Properties.Settings.Default.path;
            if (System.IO.Directory.Exists(yourRoot))
            {
                Cursor.Current = Cursors.WaitCursor;
                library_list.Nodes.AddRange(getAllFolderNodes(yourRoot).ToArray());
                libraryLoad_progressbar.PerformStep();
                library_list.Sort();
                libraryLoad_progressbar.PerformStep();
                Cursor.Current = Cursors.Default;
                LibraryPath_value.Text = Properties.Settings.Default.path;
            }
            else
            {
                LibraryPath_value.Text = "Directory Not Found";
            }
            libraryLoad_progressbar.Visible = false;
        }

        //private void library_list_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        //{
        //    TreeNode tn = e.Node.Nodes[0];
        //    if (tn.Text == "...")
        //    {
        //        e.Node.Nodes.AddRange(getFolderNodes(((DirectoryInfo)e.Node.Tag)
        //          .FullName, true).ToArray());
        //        if (tn.Text == "...") tn.Parent.Nodes.Remove(tn);
        //    }
        //}

        //List<TreeNode> getFolderNodes(string dir, bool expanded)
        //{
        //    var dirs = Directory.GetDirectories(dir).ToArray();
        //    var nodes = new List<TreeNode>();
        //    foreach (string d in dirs)
        //    {
        //        DirectoryInfo di = new DirectoryInfo(d);
        //        TreeNode tn = new TreeNode(di.Name);
        //        tn.Tag = di;
        //        int subCount = 0;
        //        try { subCount = Directory.GetDirectories(d).Count(); }
        //        catch { /* ignore accessdenied */  }
        //        if (subCount > 0) tn.Nodes.Add("...");
        //        if (expanded) tn.Expand();   //  **
        //        nodes.Add(tn);
        //    }
        //    return nodes;
        //}

        List<TreeNode> getAllFolderNodes(string dir)
        {
            var dirs = Directory.GetDirectories(dir).ToArray();
            libraryLoad_progressbar.Maximum = dirs.Count() + 2;
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
            libraryLoad_progressbar.PerformStep();
            return nodes;
        }

        private void library_list_AfterSelect(object sender, TreeViewEventArgs e)
        {
            open_button.Enabled = true;
            string selectPath = library_list.SelectedNode.FullPath.ToString();
            string fullPath = Properties.Settings.Default.path + @"\" + selectPath;
            string readerPath = fullPath + @"\reader.txt";
            string descPath = fullPath + @"\desc.txt";
            BookPath_value.Text = fullPath;
            if (library_list.SelectedNode.Nodes.Count == 0)
            {
                reader_textBox.Enabled = true;
                desc_textBox.Enabled = true;
                previousNode_button.Enabled = true;
                nextNode_button.Enabled = true;
                book_title.Text = library_list.SelectedNode.Text;
            }
            else
            {
                reader_textBox.Enabled = false;
                desc_textBox.Enabled = false;
                previousNode_button.Enabled = false;
                nextNode_button.Enabled = false;
                book_title.Text = "No Selection";
                save_button.Enabled = false;
            }
            if (System.IO.File.Exists(readerPath))
            {
                reader_textBox.Text = File.ReadAllText(readerPath);     //GetTxtValue(readerPath);
            }
            else
            {
                reader_textBox.Text = String.Empty;
            }
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
    }

}
