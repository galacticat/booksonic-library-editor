using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Booksonic_Editor
{
    public partial class Editor : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public XmlDocument xmlLibrary;

        private string _strRootDirectory = string.Empty;
        public string strRootDirectory
        {
            get
            {
                _strRootDirectory = Properties.Settings.Default.libraryPath;
                return _strRootDirectory;
            }
            set
            {
                _strRootDirectory = value;
                callRootDirectoryChanged();
            }
        }
        protected void callRootDirectoryChanged()
        {
            tbLibraryPathValue.Text = _strRootDirectory;
            labelLibraryPathValue.Text = _strRootDirectory;
        }
        private void tbLibraryPathValue_TextChanged(object sender, EventArgs e)
        {
            if (tbLibraryPathValue.Text != Properties.Settings.Default.libraryPath)
            {
                buttonConfigSave.Enabled = true;
            }
        }
        private void buttonLibraryBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog choofldlog = new FolderBrowserDialog();
            DialogResult result = choofldlog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbLibraryPathValue.Text = choofldlog.SelectedPath;
            }
        }

        private string _strJavaPath = string.Empty;
        public string strJavaPath
        {
            get
            {
                _strJavaPath = Properties.Settings.Default.javaPath;
                return _strJavaPath;
            }
            set
            {
                _strJavaPath = value;
                callJavaPathChanged();
            }
        }
        protected void callJavaPathChanged()
        {
            tbJavaPathValue.Text = _strJavaPath;
            if (_strJavaPath != string.Empty && _strScriptPath != string.Empty)
            {
                script_button.Enabled = true;
            }
            else
            {
                script_button.Enabled = false;
            }
        }
        private void tbJavaPathValue_TextChanged(object sender, EventArgs e)
        {
            if (tbJavaPathValue.Text != Properties.Settings.Default.javaPath)
            {
                buttonConfigSave.Enabled = true;
            }
        }
        private void buttonJavaPathBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Executable (*.exe)|*.exe|All files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            DialogResult result = choofdlog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbJavaPathValue.Text = choofdlog.FileName;
            }
        }

        private string _strScriptPath = string.Empty;
        public string strScriptPath
        {
            get
            {
                _strScriptPath = Properties.Settings.Default.scriptPath;
                return _strScriptPath;
            }
            set
            {
                _strScriptPath = value;
                callScriptPathChanged();
            }
        }
        protected void callScriptPathChanged()
        {
            tbScriptPathValue.Text = _strScriptPath;
            if (_strJavaPath != string.Empty && _strScriptPath != string.Empty)
            {
                script_button.Enabled = true;
            }
            else
            {
                script_button.Enabled = false;
            }
        }
        private void tbScriptPathValue_TextChanged(object sender, EventArgs e)
        {
            if (tbScriptPathValue.Text != Properties.Settings.Default.scriptPath)
            {
                buttonConfigSave.Enabled = true;
            }
        }
        private void buttonScriptPathBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Java Script (*.jar)|*.jar|All files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            DialogResult result = choofdlog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbScriptPathValue.Text = choofdlog.FileName;
            }
        }

        private Encoding[] AvailableEncoding = { Encoding.UTF7, Encoding.UTF8, Encoding.Unicode, Encoding.BigEndianUnicode, Encoding.UTF32, Encoding.ASCII };
        private Encoding _defaultEncoding = Encoding.UTF8;
        private string _txtEncoding = "Unicode (UTF-8)";
        public string txtEncoding
        {
            get
            {
                _txtEncoding = Properties.Settings.Default.encoding;
                return _txtEncoding;
            }
            set
            {
                _txtEncoding = value;
                callTxtEncodingChanged();
            }
        }
        protected void callTxtEncodingChanged()
        {
            cbEncodings.SelectedIndex = cbEncodings.FindStringExact(_txtEncoding);
        }
        private void cbEncodings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEncodings.SelectedIndex != cbEncodings.FindStringExact(Properties.Settings.Default.encoding))
            {
                buttonConfigSave.Enabled = true;
            }
        }

        private bool _boolLibraryCheck = false;
        public bool boolLibraryCheck
        {
            get
            {
                _boolLibraryCheck = Properties.Settings.Default.libraryCheck;
                return _boolLibraryCheck;
            }
            set
            {
                _boolLibraryCheck = value;
                callLibraryCheckChanged();
            }
        }
        protected void callLibraryCheckChanged()
        {
            cbCheckLibraryStartup.Checked = _boolLibraryCheck;
        }
        private void cbCheckLibraryStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheckLibraryStartup.Checked != Properties.Settings.Default.libraryCheck)
            {
                buttonConfigSave.Enabled = true;
            }
        }

        private void buttonConfigSave_Click(object sender, EventArgs e)
        {
            try
            {
                _strRootDirectory = tbLibraryPathValue.Text;
                Properties.Settings.Default.libraryPath = _strRootDirectory;
                _strJavaPath = tbJavaPathValue.Text;
                Properties.Settings.Default.javaPath = _strJavaPath;
                _strScriptPath = tbScriptPathValue.Text;
                Properties.Settings.Default.scriptPath = _strScriptPath;
                _txtEncoding = cbEncodings.Text;
                Properties.Settings.Default.encoding = _txtEncoding;
                _boolLibraryCheck = cbCheckLibraryStartup.Checked;
                Properties.Settings.Default.libraryCheck = _boolLibraryCheck;
                Properties.Settings.Default.Save();
                buttonConfigSave.Enabled = false;
                Settings_Load();
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        private string _strSelectedPath = string.Empty;
        public string strSelectedPath
        {
            get
            {
                if (library_list.SelectedNode != null)
                {
                    _strSelectedPath = _strRootDirectory + "\\" + library_list.SelectedNode.FullPath;
                }
                return _strSelectedPath;
            }
            set
            {
                _strSelectedPath = _strRootDirectory + "\\" + value;
                callSelectedPathChanged();
            }
        }
        protected void callSelectedPathChanged()
        {
            labelBookPathValue.Text = _strSelectedPath;
            open_button.Enabled = true;
            int subCount = 0;
            try { subCount = Directory.GetDirectories(_strSelectedPath).Count(); }
            catch { }
            if (subCount == 0)
            {
                strBookTitle = Path.GetFileName(_strSelectedPath);
                strReaderTxtPath = _strSelectedPath;
                strDescTxtPath = _strSelectedPath;
                strCoverPath = _strSelectedPath;
                narrator_textBox.Enabled = true;
                cmsCoverImage.Enabled = true;
                coverPictureBox.Enabled = true;
                synopsis_textBox.Enabled = true;
                previousNode_button.Enabled = true;
                nextNode_button.Enabled = true;
            }
            else
            {
                strBookTitle = "No Selection";
                strReaderTxtPath = "No Selection";
                strDescTxtPath = "No Selection";
                strCoverPath = "No Selection";
                narrator_textBox.Enabled = false;
                cmsCoverImage.Enabled = false;
                coverPictureBox.Enabled = false;
                synopsis_textBox.Enabled = false;
                previousNode_button.Enabled = false;
                nextNode_button.Enabled = false;
                save_button.Enabled = false;
            }
        }

        private string _strBookTitle = string.Empty;
        public string strBookTitle
        {
            get
            {
                _strBookTitle = Path.GetFileName(Path.GetDirectoryName(_strSelectedPath));
                return _strBookTitle;
            }
            set
            {
                _strBookTitle = value;
                callBookTitleChanged();
            }
        }
        protected void callBookTitleChanged()
        {
            book_title.Text = _strBookTitle;
        }

        private string _strReaderTxtPath = string.Empty;
        public string strReaderTxtPath
        {
            get
            {
                _strReaderTxtPath = _strSelectedPath + @"\reader.txt";
                return _strReaderTxtPath;
            }
            set
            {
                if (value == "No Selection")
                {
                    _strReaderTxtPath = value;
                }
                else
                {
                    _strReaderTxtPath = value + @"\reader.txt";
                }
                callReaderTxtPathChanged();
            }
        }
        protected void callReaderTxtPathChanged()
        {
            if (File.Exists(_strReaderTxtPath) && _txtEncoding != null)
            {
                strNarrator = File.ReadAllText(_strReaderTxtPath, GetEncoding(_strReaderTxtPath));
            }
            else
            {
                strNarrator = string.Empty;
            }
        }

        private string _strNarrator = string.Empty;
        public string strNarrator
        {
            get
            {
                if (_txtEncoding != string.Empty && _strReaderTxtPath != string.Empty && File.Exists(_strReaderTxtPath))
                {
                    if (new FileInfo(_strReaderTxtPath).Length != 0)
                    {
                        _strNarrator = File.ReadAllText(_strReaderTxtPath, GetEncoding(_strReaderTxtPath));
                    }
                    else
                    {
                        _strNarrator = string.Empty;
                    }
                }
                return _strNarrator;
            }
            set
            {
                _strNarrator = value;
                callNarratorChanged();
            }
        }
        protected void callNarratorChanged()
        {
            narrator_textBox.Text = _strNarrator;
            if (strNarrator != _strNarrator)
            {
                save_button.Enabled = true;
            }
        }
        private void narrator_textBox_TextChanged(object sender, EventArgs e)
        {
            if (narrator_textBox.Text != _strNarrator)
            {
                save_button.Enabled = true;
            }
        }

        private string _strTempCoverPath = string.Empty;
        public string strTempCoverPath
        {
            get
            {
                return _strTempCoverPath;
            }
            set
            {
                _strTempCoverPath = value;
                callTempCoverPath();
            }
        }
        protected void callTempCoverPath()
        {
            if (_strTempCoverPath != _strCoverPath)
            {
                cover_image.Text = "Image to Save: " + _strTempCoverPath;
                cover_image.Font = new Font(cover_image.Font, FontStyle.Italic);
                coverPictureBox.ImageLocation = _strTempCoverPath;
                save_button.Enabled = true;
            }
        }

        private string _strCoverPath = string.Empty;
        public string strCoverPath
        {
            get
            {
                _strCoverPath = _strSelectedPath + @"\cover.jpg";
                return _strCoverPath;
            }
            set
            {
                _strCoverPath = value + @"\cover.jpg";
                callCoverPathChanged();
            }
        }
        protected void callCoverPathChanged()
        {
            if (System.IO.File.Exists(_strCoverPath))
            {
                cover_image.Text = _strCoverPath;
                cover_image.Font = new Font(cover_image.Font, FontStyle.Regular);
                coverPictureBox.ImageLocation = _strCoverPath;
            }
            else
            {
                cover_image.Text = String.Empty;
                coverPictureBox.ImageLocation = String.Empty;
            }
        }
        private void cover_textBox_TextChanged(object sender, EventArgs e)
        {
            if(cover_image.Text != _strCoverPath)
            {
                save_button.Enabled = true;
            }
        }

        private string _strDescTxtPath = string.Empty;
        public string strDescTxtPath
        {
            get
            {
                _strDescTxtPath = _strSelectedPath + @"\desc.txt";
                return _strDescTxtPath;
            }
            set
            {
                if(value == "No Selection")
                {
                    _strDescTxtPath = value;
                }
                else
                {
                    _strDescTxtPath = value + @"\desc.txt";
                }
                callDescTxtPathChanged();
            }
        }
        protected void callDescTxtPathChanged()
        {
            if (File.Exists(_strDescTxtPath))
            {
                strSynopsis = File.ReadAllText(_strDescTxtPath, GetEncoding(_strDescTxtPath));
            }
            else
            {
                strSynopsis = string.Empty;
            }
        }

        private string _strSynopsis = string.Empty;
        public string strSynopsis
        {
            get
            {
                if (_txtEncoding != string.Empty && _strDescTxtPath != string.Empty && File.Exists(_strDescTxtPath))
                {
                    if(new FileInfo(_strDescTxtPath).Length != 0)
                    {
                        _strSynopsis = File.ReadAllText(_strDescTxtPath, GetEncoding(_strDescTxtPath));
                    }
                    else
                    {
                        _strSynopsis = string.Empty;
                    }
                }
                return _strSynopsis;
            }
            set
            {
                _strSynopsis = value;
                callSynopsisChanged();
            }
        }
        protected void callSynopsisChanged()
        {
            synopsis_textBox.Text = _strSynopsis;
            if (strSynopsis != _strSynopsis)
            {
                save_button.Enabled = true;
            }
        }
        private void synopsis_textBox_TextChanged(object sender, EventArgs e)
        {
            if (synopsis_textBox.Text != strSynopsis)
            {
                save_button.Enabled = true;
            }
        }

        public Editor()
        {
            InitializeComponent();            
            //Enables hot keys handler
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);

            //Creates tooltips
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(search_button, "Applies the search filter" + Environment.NewLine + "Hotkey: Enter");
            toolTip1.SetToolTip(previousNode_button, "Selects the previous book from the tree" + Environment.NewLine + "Hotkey: Page Up");
            toolTip1.SetToolTip(nextNode_button, "Selects the next book from the tree" + Environment.NewLine + "Hotkey: Page Down");
            toolTip1.SetToolTip(save_button, "Saves the reader.txt and desc.txt" + Environment.NewLine + "Hotkey: Ctrl+S");
            toolTip1.SetToolTip(script_button, "Script Runs with the following syntax:" + Environment.NewLine + "<Java Path> -jar <Script Path> <Library Path>");
            toolTip1.SetToolTip(coverPictureBox, "Click to see full image");
            toolTip1.SetToolTip(refresh_button, "Reloads the Library Path");
            toolTip1.SetToolTip(open_button, "Opens the Book Path");
            toolTip1.SetToolTip(cbEncodings, "Encoding to use when saving the \"reader.txt\" and \"desc.text\" files");
            
            //Populates combo boxes
            SetComboBoxItems();
            //loads settings
            Settings_Load();
            log4net.Config.XmlConfigurator.Configure();
        }

        List<string> encodings = new List<string>();
        private void SetComboBoxItems()
        {
            try
            {
                cbEncodings.Items.Clear();
                foreach (var encodingInfo in AvailableEncoding)
                {
                    encodings.Add(encodingInfo.EncodingName);
                }
                encodings.Sort();
                cbEncodings.Items.AddRange(encodings.OrderBy(c => c).ToArray());
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        public void Editor_Load(object sender, EventArgs e)
        {
            try
            {
                log.Info("Booksonic Library Editor loaded");
                if (_boolLibraryCheck && (_strRootDirectory != string.Empty | _strRootDirectory != null))
                {
                    refresh_button.PerformClick();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        public void Settings_Load()
        {
            try
            {
                strRootDirectory = Properties.Settings.Default.libraryPath;
                strJavaPath = Properties.Settings.Default.javaPath;
                strScriptPath = Properties.Settings.Default.scriptPath;
                txtEncoding = Properties.Settings.Default.encoding;
                boolLibraryCheck = Properties.Settings.Default.libraryCheck;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
                
        public void refresh_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!backgroundWorker1.IsBusy)
                {
                    slProgressPercentage.Visible = true;
                    slProcessDirectory.Visible = true;
                    libraryLoad_progressbar.Visible = true;
                    tssCancel.Visible = true;
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(this, ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = library_list.SelectedNode;
                RichTextBox rich = new RichTextBox();
                _strNarrator = narrator_textBox.Text;
                if (_strReaderTxtPath != string.Empty)
                {
                    File.WriteAllText(_strReaderTxtPath, _strNarrator, _defaultEncoding);
                }
                if (_strTempCoverPath != string.Empty && File.Exists(_strTempCoverPath))
                {
                    if (File.Exists(_strCoverPath))
                    {
                        DialogResult results = MessageBox.Show("A cover.jpg already exists. Do you want to overwrite it?", "File Exists", MessageBoxButtons.YesNo);
                        if (results == DialogResult.Yes)
                        {
                            File.Copy(_strTempCoverPath, _strCoverPath, true);
                        }
                        else if (_strCoverPath != string.Empty)
                        {
                            strCoverPath = _strCoverPath;
                        }
                        else
                        {
                            strCoverPath = string.Empty;
                        }
                    }
                    else
                    {
                        File.Copy(_strTempCoverPath, _strCoverPath, false);
                    }
                }
                _strSynopsis = synopsis_textBox.Text;
                if (_strDescTxtPath != string.Empty)
                {
                    File.WriteAllText(_strDescTxtPath, _strSynopsis, _defaultEncoding);
                }
                library_list.SelectedNode = null;
                library_list.SelectedNode = node;
                save_button.Enabled = false;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(this, ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            try
            {
                string selectPath = library_list.SelectedNode.FullPath.ToString();
                string fullPath = Properties.Settings.Default.libraryPath + @"\" + selectPath;
                if (Directory.Exists(fullPath))
                {
                    System.Diagnostics.Process.Start(fullPath);
                }
                else
                {
                    MessageBox.Show(String.Concat("Can not find:", Environment.NewLine, fullPath));
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(this, ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<TreeNode> CurrentNodeMatches = new List<TreeNode>();
        private int LastNodeIndex = 0;
        private string LastSearchText;
        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = search_textBox.Text;
                if (string.IsNullOrEmpty(searchText))
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
                    library_list.SelectedNode = selectedNode;
                    library_list.SelectedNode.Expand();
                    library_list.Select();
                    slSearchResults.Text = String.Format("Search Results: {0} of {1}", LastNodeIndex, CurrentNodeMatches.Count);
                    slSearchResults.Visible = true;
                }
                else if (CurrentNodeMatches.Count > 0)
                {
                    LastNodeIndex = 0;
                    search_button.PerformClick();
                }
                else
                {
                    slSearchResults.Visible = true;
                    slSearchResults.Text = "Search Results: No matches found";
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(this, ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void expandAll_button_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(this, ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void collapseAll_button_Click(object sender, EventArgs e)
        {
            try
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
            catch(Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(this, ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void previousNode_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (library_list.SelectedNode != null && library_list.SelectedNode.PrevVisibleNode != null)
                {
                    library_list.SelectedNode = library_list.SelectedNode.PrevVisibleNode;
                    if (library_list.SelectedNode.Nodes.Count != 0)
                    {
                        previousNode_button_Click(sender, e);
                    }
                }
                else if (library_list.SelectedNode.PrevVisibleNode == null)
                {
                    library_list.SelectedNode = library_list.Nodes[library_list.Nodes.Count - 1];
                    if (library_list.SelectedNode.Nodes.Count != 0)
                    {
                        nextNode_button_Click(sender, e);
                    }
                }
            }
            catch(Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(this, ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nextNode_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (library_list.SelectedNode != null && library_list.SelectedNode.NextVisibleNode != null)
                {
                    library_list.SelectedNode = library_list.SelectedNode.NextVisibleNode;
                    if (library_list.SelectedNode.Nodes.Count != 0)
                    {
                        nextNode_button_Click(sender, e);
                    }
                }
                else if (library_list.SelectedNode.NextVisibleNode == null)
                {
                    library_list.SelectedNode = library_list.Nodes[0];
                    if (library_list.SelectedNode.Nodes.Count != 0)
                    {
                        nextNode_button_Click(sender, e);
                    }
                }
            }
            catch(Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(this, ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<TreeNode> getAllFolderNodes(string dir)
        {
            var dirs = Directory.GetDirectories(dir).ToArray();
            var nodes = new List<TreeNode>();
            foreach (string d in dirs)
            {
                _currentDirectory = d;
                BeginInvoke((Action)(() =>
                {
                    slProcessDirectory.Text = "Processing... " + _currentDirectory;
                }));
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
            return nodes;
        }

        private void library_list_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                //Clears search status on user select
                if (slSearchResults.Visible && !library_list.SelectedNode.Text.Contains(LastSearchText))
                {
                    slSearchResults.Text = "Search Results: ";
                    slSearchResults.Visible = false;
                }

                if (_strRootDirectory != string.Empty)
                {
                    strSelectedPath = library_list.SelectedNode.FullPath;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(this, ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static Encoding GetEncoding(string filename)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.ASCII;
        }

        private void SearchNodes(string SearchText, TreeNode StartNode)
        {
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

        private void coverPictureBox_Click(object sender, EventArgs e)
        {
            Image image = coverPictureBox.Image;
            if(image != null)
            {
                PictureBox b = new PictureBox();
                b.Image = image;
                b.Dock = DockStyle.Fill;
                b.BackColor = Color.FromArgb(50, Color.Transparent);
                b.SizeMode = PictureBoxSizeMode.CenterImage;
                b.Click += new EventHandler(pictureBox1_Click);
                ActiveForm.Controls.Add(b);
                b.BringToFront();
                tabControl1.SendToBack();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            (sender as Control).Dispose();
        }

        private void imgSearch_button_Click(object sender, EventArgs e)
        {

        }

        private static string _currentDirectory;
        private static List<TreeNode> nodes = new List<TreeNode>();
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                    if (slSearchResults.Visible)
                    {
                        slSearchResults.Visible = false;
                        search_textBox.Text = string.Empty;
                    }
                    if (System.IO.Directory.Exists(_strRootDirectory))
                    {
                        nodes.Clear();
                        var dirs = Directory.GetDirectories(_strRootDirectory).ToArray();
                        int folderCount = dirs.Count();
                        int i = 0;
                        foreach (string d in dirs)
                        {
                            if (!backgroundWorker1.CancellationPending)
                            {
                                _currentDirectory = d;
                                BeginInvoke((Action)(() =>
                                {
                                    slProcessDirectory.Text = "Processing... " + _currentDirectory;
                                }));
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
                                i++;
                                int percentage = (i) * 100 / folderCount;
                                backgroundWorker1.ReportProgress(percentage);
                            }
                        }
                    }
                    else
                    {
                        this.labelLibraryPathValue.Text = "Directory Not Found";
                    }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            libraryLoad_progressbar.Value = e.ProgressPercentage;
            slProgressPercentage.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            slProgressPercentage.Visible = false;
            slProcessDirectory.Visible = false;
            libraryLoad_progressbar.Visible = false;
            tssCancel.Visible = false;
            Cursor.Current = Cursors.WaitCursor;
            if (nodes != null)
            {
                this.library_list.Nodes.Clear();
                this.library_list.Nodes.AddRange(nodes.ToArray());
                this.library_list.Sort();
                search_textBox.Enabled = true;
                search_button.Enabled = true;
                expandAll_button.Enabled = true;
                collapseAll_button.Enabled = true;
            }
            else
            {
                search_textBox.Enabled = false;
                search_button.Enabled = false;
                expandAll_button.Enabled = false;
                collapseAll_button.Enabled = false;
                previousNode_button.Enabled = false;
                nextNode_button.Enabled = true;
            }
            Cursor.Current = Cursors.Default;
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

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Image (*.jpg)|*.jpg|All files (*.*)|*.*";
            choofdlog.InitialDirectory = strSelectedPath;
            choofdlog.RestoreDirectory = true;
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            DialogResult result = choofdlog.ShowDialog();
            if (result == DialogResult.OK)
            {
                strTempCoverPath = choofdlog.FileName;
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(coverPictureBox.Image != null)
            {
                DialogResult result = MessageBox.Show(this, "Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    File.Delete(coverPictureBox.ImageLocation);
                    strCoverPath = _strSelectedPath;
                }
            }
        }

        private void labelBookPathValue_Click(object sender, EventArgs e)
        {

        }

        private void tssCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Do you want to cancel the library refresh?", "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                backgroundWorker1.CancelAsync();
            }
        }
    }
}