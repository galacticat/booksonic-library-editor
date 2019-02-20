namespace Booksonic_Editor
{
    partial class Editor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.library_groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.search_label = new System.Windows.Forms.Label();
            this.library_list = new System.Windows.Forms.TreeView();
            this.labelLibraryPathValue = new System.Windows.Forms.Label();
            this.script_button = new System.Windows.Forms.Button();
            this.LibraryPath_label = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.nextNode_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.previousNode_button = new System.Windows.Forms.Button();
            this.expandAll_button = new System.Windows.Forms.Button();
            this.collapseAll_button = new System.Windows.Forms.Button();
            this.bookdata_groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bookTitle_label = new System.Windows.Forms.Label();
            this.labelBookPathValue = new System.Windows.Forms.Label();
            this.BookPath_label = new System.Windows.Forms.Label();
            this.synopsis_textBox = new System.Windows.Forms.RichTextBox();
            this.cover_image = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.reader_label = new System.Windows.Forms.Label();
            this.desc_label = new System.Windows.Forms.Label();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.cover_label = new System.Windows.Forms.Label();
            this.open_button = new System.Windows.Forms.Button();
            this.book_title = new System.Windows.Forms.Label();
            this.narrator_textBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLibraryPathValue = new System.Windows.Forms.TextBox();
            this.tbScriptPathValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbJavaPathValue = new System.Windows.Forms.TextBox();
            this.buttonScriptPathBrowse = new System.Windows.Forms.Button();
            this.buttonJavaPathBrowse = new System.Windows.Forms.Button();
            this.buttonLibraryBrowse = new System.Windows.Forms.Button();
            this.buttonConfigSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEncodings = new System.Windows.Forms.ComboBox();
            this.cbCheckLibraryStartup = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.libraryLoad_progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.slProgressPercentage = new System.Windows.Forms.ToolStripStatusLabel();
            this.slProcessDirectory = new System.Windows.Forms.ToolStripStatusLabel();
            this.slSearchResults = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmsCoverImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssCancel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.library_groupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bookdata_groupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cmsCoverImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 536);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1001, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.library_groupBox);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bookdata_groupBox);
            this.splitContainer1.Panel2MinSize = 250;
            this.splitContainer1.Size = new System.Drawing.Size(995, 504);
            this.splitContainer1.SplitterDistance = 504;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 1;
            // 
            // library_groupBox
            // 
            this.library_groupBox.Controls.Add(this.tableLayoutPanel1);
            this.library_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.library_groupBox.Location = new System.Drawing.Point(0, 0);
            this.library_groupBox.Name = "library_groupBox";
            this.library_groupBox.Size = new System.Drawing.Size(504, 504);
            this.library_groupBox.TabIndex = 4;
            this.library_groupBox.TabStop = false;
            this.library_groupBox.Text = "Library";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.search_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.library_list, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.script_button, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.search_textBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nextNode_button, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.search_button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.previousNode_button, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.expandAll_button, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.collapseAll_button, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.LibraryPath_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BookPath_label, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelBookPathValue, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelLibraryPathValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.refresh_button, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 485);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // search_label
            // 
            this.search_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_label.Location = new System.Drawing.Point(43, 9);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(51, 13);
            this.search_label.TabIndex = 3;
            this.search_label.Text = "Search:";
            // 
            // library_list
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.library_list, 2);
            this.library_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.library_list.HideSelection = false;
            this.library_list.Location = new System.Drawing.Point(3, 54);
            this.library_list.Name = "library_list";
            this.tableLayoutPanel1.SetRowSpan(this.library_list, 7);
            this.library_list.Size = new System.Drawing.Size(411, 409);
            this.library_list.TabIndex = 5;
            this.library_list.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.library_list_AfterSelect);
            // 
            // labelLibraryPathValue
            // 
            this.labelLibraryPathValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLibraryPathValue.AutoSize = true;
            this.labelLibraryPathValue.Location = new System.Drawing.Point(100, 34);
            this.labelLibraryPathValue.Margin = new System.Windows.Forms.Padding(3);
            this.labelLibraryPathValue.Name = "labelLibraryPathValue";
            this.labelLibraryPathValue.Size = new System.Drawing.Size(102, 13);
            this.labelLibraryPathValue.TabIndex = 9;
            this.labelLibraryPathValue.Text = "Directory Not Found";
            // 
            // script_button
            // 
            this.script_button.Enabled = false;
            this.script_button.Location = new System.Drawing.Point(420, 313);
            this.script_button.MinimumSize = new System.Drawing.Size(75, 45);
            this.script_button.Name = "script_button";
            this.script_button.Size = new System.Drawing.Size(75, 46);
            this.script_button.TabIndex = 14;
            this.script_button.Text = "Run Script";
            this.script_button.UseVisualStyleBackColor = true;
            this.script_button.Click += new System.EventHandler(this.script_button_Click);
            // 
            // LibraryPath_label
            // 
            this.LibraryPath_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LibraryPath_label.AutoSize = true;
            this.LibraryPath_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryPath_label.Location = new System.Drawing.Point(15, 34);
            this.LibraryPath_label.Margin = new System.Windows.Forms.Padding(3);
            this.LibraryPath_label.Name = "LibraryPath_label";
            this.LibraryPath_label.Size = new System.Drawing.Size(79, 13);
            this.LibraryPath_label.TabIndex = 3;
            this.LibraryPath_label.Text = "Library Path:";
            // 
            // search_textBox
            // 
            this.search_textBox.AcceptsReturn = true;
            this.search_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.search_textBox.Enabled = false;
            this.search_textBox.Location = new System.Drawing.Point(100, 5);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(314, 20);
            this.search_textBox.TabIndex = 8;
            // 
            // nextNode_button
            // 
            this.nextNode_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nextNode_button.Enabled = false;
            this.nextNode_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextNode_button.Location = new System.Drawing.Point(420, 261);
            this.nextNode_button.MinimumSize = new System.Drawing.Size(75, 45);
            this.nextNode_button.Name = "nextNode_button";
            this.nextNode_button.Size = new System.Drawing.Size(75, 46);
            this.nextNode_button.TabIndex = 14;
            this.nextNode_button.Text = "Next Book";
            this.nextNode_button.UseVisualStyleBackColor = true;
            this.nextNode_button.Click += new System.EventHandler(this.nextNode_button_Click);
            // 
            // search_button
            // 
            this.search_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.search_button.Enabled = false;
            this.search_button.Location = new System.Drawing.Point(420, 3);
            this.search_button.MinimumSize = new System.Drawing.Size(75, 25);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 25);
            this.search_button.TabIndex = 10;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refresh_button.Location = new System.Drawing.Point(420, 54);
            this.refresh_button.MinimumSize = new System.Drawing.Size(75, 45);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 45);
            this.refresh_button.TabIndex = 1;
            this.refresh_button.Text = "Refresh Library";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // previousNode_button
            // 
            this.previousNode_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.previousNode_button.Enabled = false;
            this.previousNode_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousNode_button.Location = new System.Drawing.Point(420, 209);
            this.previousNode_button.MinimumSize = new System.Drawing.Size(75, 45);
            this.previousNode_button.Name = "previousNode_button";
            this.previousNode_button.Size = new System.Drawing.Size(75, 46);
            this.previousNode_button.TabIndex = 13;
            this.previousNode_button.Text = "Prev Book";
            this.previousNode_button.UseVisualStyleBackColor = true;
            this.previousNode_button.Click += new System.EventHandler(this.previousNode_button_Click);
            // 
            // expandAll_button
            // 
            this.expandAll_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.expandAll_button.Enabled = false;
            this.expandAll_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandAll_button.Location = new System.Drawing.Point(420, 105);
            this.expandAll_button.MinimumSize = new System.Drawing.Size(75, 45);
            this.expandAll_button.Name = "expandAll_button";
            this.expandAll_button.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.expandAll_button.Size = new System.Drawing.Size(75, 46);
            this.expandAll_button.TabIndex = 11;
            this.expandAll_button.Text = "Expand All";
            this.expandAll_button.UseVisualStyleBackColor = true;
            this.expandAll_button.Click += new System.EventHandler(this.expandAll_button_Click);
            // 
            // collapseAll_button
            // 
            this.collapseAll_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.collapseAll_button.Enabled = false;
            this.collapseAll_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collapseAll_button.Location = new System.Drawing.Point(420, 157);
            this.collapseAll_button.MinimumSize = new System.Drawing.Size(75, 45);
            this.collapseAll_button.Name = "collapseAll_button";
            this.collapseAll_button.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.collapseAll_button.Size = new System.Drawing.Size(75, 46);
            this.collapseAll_button.TabIndex = 12;
            this.collapseAll_button.Text = "Collapse All";
            this.collapseAll_button.UseVisualStyleBackColor = true;
            this.collapseAll_button.Click += new System.EventHandler(this.collapseAll_button_Click);
            // 
            // bookdata_groupBox
            // 
            this.bookdata_groupBox.Controls.Add(this.tableLayoutPanel2);
            this.bookdata_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookdata_groupBox.Location = new System.Drawing.Point(0, 0);
            this.bookdata_groupBox.Name = "bookdata_groupBox";
            this.bookdata_groupBox.Size = new System.Drawing.Size(481, 504);
            this.bookdata_groupBox.TabIndex = 5;
            this.bookdata_groupBox.TabStop = false;
            this.bookdata_groupBox.Text = "Book Data";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.bookTitle_label, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.synopsis_textBox, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.save_button, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.desc_label, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.coverPictureBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.open_button, 2, 11);
            this.tableLayoutPanel2.Controls.Add(this.cover_label, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.reader_label, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.cover_image, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.book_title, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.narrator_textBox, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 13;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(475, 485);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // bookTitle_label
            // 
            this.bookTitle_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bookTitle_label.AutoSize = true;
            this.bookTitle_label.CausesValidation = false;
            this.bookTitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitle_label.Location = new System.Drawing.Point(20, 186);
            this.bookTitle_label.Margin = new System.Windows.Forms.Padding(3);
            this.bookTitle_label.Name = "bookTitle_label";
            this.bookTitle_label.Size = new System.Drawing.Size(40, 13);
            this.bookTitle_label.TabIndex = 12;
            this.bookTitle_label.Text = "Book:";
            // 
            // labelBookPathValue
            // 
            this.labelBookPathValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBookPathValue.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelBookPathValue, 2);
            this.labelBookPathValue.Location = new System.Drawing.Point(100, 469);
            this.labelBookPathValue.Margin = new System.Windows.Forms.Padding(3);
            this.labelBookPathValue.Name = "labelBookPathValue";
            this.labelBookPathValue.Size = new System.Drawing.Size(395, 13);
            this.labelBookPathValue.TabIndex = 9;
            this.labelBookPathValue.Text = "No Selection";
            this.labelBookPathValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBookPathValue.Click += new System.EventHandler(this.labelBookPathValue_Click);
            // 
            // BookPath_label
            // 
            this.BookPath_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BookPath_label.AutoSize = true;
            this.BookPath_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPath_label.Location = new System.Drawing.Point(3, 469);
            this.BookPath_label.Margin = new System.Windows.Forms.Padding(3);
            this.BookPath_label.Name = "BookPath_label";
            this.BookPath_label.Size = new System.Drawing.Size(91, 13);
            this.BookPath_label.TabIndex = 3;
            this.BookPath_label.Text = "Selected Path:";
            // 
            // synopsis_textBox
            // 
            this.synopsis_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.synopsis_textBox, 3);
            this.synopsis_textBox.Enabled = false;
            this.synopsis_textBox.Location = new System.Drawing.Point(3, 250);
            this.synopsis_textBox.Name = "synopsis_textBox";
            this.synopsis_textBox.Size = new System.Drawing.Size(469, 203);
            this.synopsis_textBox.TabIndex = 11;
            this.synopsis_textBox.Text = "";
            this.synopsis_textBox.TextChanged += new System.EventHandler(this.synopsis_textBox_TextChanged);
            // 
            // cover_image
            // 
            this.cover_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cover_image.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.cover_image, 2);
            this.cover_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cover_image.Location = new System.Drawing.Point(66, 166);
            this.cover_image.Margin = new System.Windows.Forms.Padding(3);
            this.cover_image.Name = "cover_image";
            this.cover_image.Size = new System.Drawing.Size(406, 13);
            this.cover_image.TabIndex = 16;
            this.cover_image.Text = "No Selection";
            this.cover_image.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // save_button
            // 
            this.save_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.save_button.Enabled = false;
            this.save_button.Location = new System.Drawing.Point(305, 459);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // reader_label
            // 
            this.reader_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.reader_label.AutoSize = true;
            this.reader_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reader_label.Location = new System.Drawing.Point(3, 208);
            this.reader_label.Margin = new System.Windows.Forms.Padding(3);
            this.reader_label.Name = "reader_label";
            this.reader_label.Size = new System.Drawing.Size(57, 13);
            this.reader_label.TabIndex = 3;
            this.reader_label.Text = "Narrator:";
            // 
            // desc_label
            // 
            this.desc_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.desc_label.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.desc_label, 3);
            this.desc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_label.Location = new System.Drawing.Point(3, 231);
            this.desc_label.Margin = new System.Windows.Forms.Padding(3);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(469, 13);
            this.desc_label.TabIndex = 3;
            this.desc_label.Text = "Book Synopsis";
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.coverPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.coverPictureBox, 3);
            this.coverPictureBox.ContextMenuStrip = this.cmsCoverImage;
            this.coverPictureBox.Enabled = false;
            this.coverPictureBox.Location = new System.Drawing.Point(10, 10);
            this.coverPictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.coverPictureBox.MaximumSize = new System.Drawing.Size(143, 143);
            this.coverPictureBox.MinimumSize = new System.Drawing.Size(143, 143);
            this.coverPictureBox.Name = "coverPictureBox";
            this.tableLayoutPanel2.SetRowSpan(this.coverPictureBox, 2);
            this.coverPictureBox.Size = new System.Drawing.Size(143, 143);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 15;
            this.coverPictureBox.TabStop = false;
            this.coverPictureBox.Click += new System.EventHandler(this.coverPictureBox_Click);
            // 
            // cover_label
            // 
            this.cover_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cover_label.AutoSize = true;
            this.cover_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cover_label.Location = new System.Drawing.Point(16, 166);
            this.cover_label.Margin = new System.Windows.Forms.Padding(3);
            this.cover_label.Name = "cover_label";
            this.cover_label.Size = new System.Drawing.Size(44, 13);
            this.cover_label.TabIndex = 3;
            this.cover_label.Text = "Cover:";
            // 
            // open_button
            // 
            this.open_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.open_button.Enabled = false;
            this.open_button.Location = new System.Drawing.Point(386, 459);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(86, 23);
            this.open_button.TabIndex = 10;
            this.open_button.Text = "Open Location";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // book_title
            // 
            this.book_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.book_title.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.book_title, 2);
            this.book_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_title.Location = new System.Drawing.Point(66, 186);
            this.book_title.Margin = new System.Windows.Forms.Padding(3);
            this.book_title.Name = "book_title";
            this.book_title.Size = new System.Drawing.Size(406, 13);
            this.book_title.TabIndex = 13;
            this.book_title.Text = "No Selection";
            this.book_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // narrator_textBox
            // 
            this.narrator_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.narrator_textBox, 2);
            this.narrator_textBox.Enabled = false;
            this.narrator_textBox.Location = new System.Drawing.Point(66, 205);
            this.narrator_textBox.Name = "narrator_textBox";
            this.narrator_textBox.Size = new System.Drawing.Size(406, 20);
            this.narrator_textBox.TabIndex = 1;
            this.narrator_textBox.TextChanged += new System.EventHandler(this.narrator_textBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1001, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configure";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbLibraryPathValue, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbScriptPathValue, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbJavaPathValue, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.buttonScriptPathBrowse, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.buttonJavaPathBrowse, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.buttonLibraryBrowse, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonConfigSave, 2, 10);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.cbEncodings, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.cbCheckLibraryStartup, 0, 8);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 11;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(995, 504);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Path";
            // 
            // tbLibraryPathValue
            // 
            this.tbLibraryPathValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLibraryPathValue.Location = new System.Drawing.Point(3, 23);
            this.tbLibraryPathValue.Name = "tbLibraryPathValue";
            this.tbLibraryPathValue.Size = new System.Drawing.Size(298, 20);
            this.tbLibraryPathValue.TabIndex = 1;
            this.tbLibraryPathValue.TextChanged += new System.EventHandler(this.tbLibraryPathValue_TextChanged);
            // 
            // tbScriptPathValue
            // 
            this.tbScriptPathValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScriptPathValue.Location = new System.Drawing.Point(3, 119);
            this.tbScriptPathValue.Name = "tbScriptPathValue";
            this.tbScriptPathValue.Size = new System.Drawing.Size(298, 20);
            this.tbScriptPathValue.TabIndex = 1;
            this.tbScriptPathValue.TextChanged += new System.EventHandler(this.tbScriptPathValue_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Script Path";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Java Path";
            // 
            // tbJavaPathValue
            // 
            this.tbJavaPathValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJavaPathValue.Location = new System.Drawing.Point(3, 71);
            this.tbJavaPathValue.Name = "tbJavaPathValue";
            this.tbJavaPathValue.Size = new System.Drawing.Size(298, 20);
            this.tbJavaPathValue.TabIndex = 1;
            this.tbJavaPathValue.TextChanged += new System.EventHandler(this.tbJavaPathValue_TextChanged);
            // 
            // buttonScriptPathBrowse
            // 
            this.buttonScriptPathBrowse.Location = new System.Drawing.Point(307, 118);
            this.buttonScriptPathBrowse.Name = "buttonScriptPathBrowse";
            this.buttonScriptPathBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonScriptPathBrowse.TabIndex = 2;
            this.buttonScriptPathBrowse.Text = "Browse";
            this.buttonScriptPathBrowse.UseVisualStyleBackColor = true;
            this.buttonScriptPathBrowse.Click += new System.EventHandler(this.buttonScriptPathBrowse_Click);
            // 
            // buttonJavaPathBrowse
            // 
            this.buttonJavaPathBrowse.Location = new System.Drawing.Point(307, 70);
            this.buttonJavaPathBrowse.Name = "buttonJavaPathBrowse";
            this.buttonJavaPathBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonJavaPathBrowse.TabIndex = 2;
            this.buttonJavaPathBrowse.Text = "Browse";
            this.buttonJavaPathBrowse.UseVisualStyleBackColor = true;
            this.buttonJavaPathBrowse.Click += new System.EventHandler(this.buttonJavaPathBrowse_Click);
            // 
            // buttonLibraryBrowse
            // 
            this.buttonLibraryBrowse.Location = new System.Drawing.Point(307, 22);
            this.buttonLibraryBrowse.Name = "buttonLibraryBrowse";
            this.buttonLibraryBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonLibraryBrowse.TabIndex = 2;
            this.buttonLibraryBrowse.Text = "Browse";
            this.buttonLibraryBrowse.UseVisualStyleBackColor = true;
            this.buttonLibraryBrowse.Click += new System.EventHandler(this.buttonLibraryBrowse_Click);
            // 
            // buttonConfigSave
            // 
            this.buttonConfigSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigSave.Enabled = false;
            this.buttonConfigSave.Location = new System.Drawing.Point(917, 478);
            this.buttonConfigSave.Name = "buttonConfigSave";
            this.buttonConfigSave.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigSave.TabIndex = 3;
            this.buttonConfigSave.Text = "Save";
            this.buttonConfigSave.UseVisualStyleBackColor = true;
            this.buttonConfigSave.Click += new System.EventHandler(this.buttonConfigSave_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 144);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Save File Encodings";
            // 
            // cbEncodings
            // 
            this.cbEncodings.FormattingEnabled = true;
            this.cbEncodings.Location = new System.Drawing.Point(3, 166);
            this.cbEncodings.Name = "cbEncodings";
            this.cbEncodings.Size = new System.Drawing.Size(121, 21);
            this.cbEncodings.TabIndex = 4;
            this.cbEncodings.SelectedIndexChanged += new System.EventHandler(this.cbEncodings_SelectedIndexChanged);
            // 
            // cbCheckLibraryStartup
            // 
            this.cbCheckLibraryStartup.AutoSize = true;
            this.cbCheckLibraryStartup.Location = new System.Drawing.Point(3, 193);
            this.cbCheckLibraryStartup.Name = "cbCheckLibraryStartup";
            this.cbCheckLibraryStartup.Padding = new System.Windows.Forms.Padding(3);
            this.cbCheckLibraryStartup.Size = new System.Drawing.Size(155, 23);
            this.cbCheckLibraryStartup.TabIndex = 5;
            this.cbCheckLibraryStartup.Text = "Refresh Library on Startup";
            this.cbCheckLibraryStartup.UseVisualStyleBackColor = true;
            this.cbCheckLibraryStartup.CheckedChanged += new System.EventHandler(this.cbCheckLibraryStartup_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libraryLoad_progressbar,
            this.tssCancel,
            this.slProgressPercentage,
            this.slProcessDirectory,
            this.slSearchResults});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1009, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // libraryLoad_progressbar
            // 
            this.libraryLoad_progressbar.Name = "libraryLoad_progressbar";
            this.libraryLoad_progressbar.Size = new System.Drawing.Size(500, 18);
            this.libraryLoad_progressbar.Visible = false;
            // 
            // slProgressPercentage
            // 
            this.slProgressPercentage.BackColor = System.Drawing.Color.Transparent;
            this.slProgressPercentage.Name = "slProgressPercentage";
            this.slProgressPercentage.Size = new System.Drawing.Size(105, 19);
            this.slProgressPercentage.Text = "Process Progress%";
            this.slProgressPercentage.Visible = false;
            // 
            // slProcessDirectory
            // 
            this.slProcessDirectory.BackColor = System.Drawing.Color.Transparent;
            this.slProcessDirectory.Name = "slProcessDirectory";
            this.slProcessDirectory.Size = new System.Drawing.Size(98, 19);
            this.slProcessDirectory.Text = "Process Directory";
            this.slProcessDirectory.Visible = false;
            // 
            // slSearchResults
            // 
            this.slSearchResults.BackColor = System.Drawing.Color.Transparent;
            this.slSearchResults.Name = "slSearchResults";
            this.slSearchResults.Size = new System.Drawing.Size(85, 19);
            this.slSearchResults.Text = "Search Results:";
            this.slSearchResults.Visible = false;
            // 
            // cmsCoverImage
            // 
            this.cmsCoverImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.cmsCoverImage.Name = "cmsCoverImage";
            this.cmsCoverImage.Size = new System.Drawing.Size(118, 48);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.changeToolStripMenuItem.Text = "Change";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // tssCancel
            // 
            this.tssCancel.BackColor = System.Drawing.SystemColors.Control;
            this.tssCancel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssCancel.ForeColor = System.Drawing.Color.Red;
            this.tssCancel.Name = "tssCancel";
            this.tssCancel.Size = new System.Drawing.Size(47, 19);
            this.tssCancel.Text = "Cancel";
            this.tssCancel.Visible = false;
            this.tssCancel.Click += new System.EventHandler(this.tssCancel_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1009, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(835, 600);
            this.Name = "Editor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Booksonic Library Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.library_groupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.bookdata_groupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cmsCoverImage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox library_groupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.TreeView library_list;
        private System.Windows.Forms.Label labelLibraryPathValue;
        private System.Windows.Forms.Label LibraryPath_label;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.GroupBox bookdata_groupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label bookTitle_label;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Label BookPath_label;
        private System.Windows.Forms.RichTextBox synopsis_textBox;
        private System.Windows.Forms.Label cover_image;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label book_title;
        private System.Windows.Forms.Label desc_label;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.TextBox narrator_textBox;
        private System.Windows.Forms.Label cover_label;
        private System.Windows.Forms.Label labelBookPathValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLibraryPathValue;
        private System.Windows.Forms.Button buttonLibraryBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJavaPathValue;
        private System.Windows.Forms.Button buttonJavaPathBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbScriptPathValue;
        private System.Windows.Forms.Button buttonScriptPathBrowse;
        private System.Windows.Forms.Button buttonConfigSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ToolStripProgressBar libraryLoad_progressbar;
        protected System.Windows.Forms.ToolStripStatusLabel slProgressPercentage;
        public System.Windows.Forms.ToolStripStatusLabel slProcessDirectory;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label reader_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEncodings;
        private System.Windows.Forms.ToolStripStatusLabel slSearchResults;
        private System.Windows.Forms.Button script_button;
        private System.Windows.Forms.Button nextNode_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button previousNode_button;
        private System.Windows.Forms.Button expandAll_button;
        private System.Windows.Forms.Button collapseAll_button;
        private System.Windows.Forms.CheckBox cbCheckLibraryStartup;
        private System.Windows.Forms.ContextMenuStrip cmsCoverImage;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tssCancel;
    }
}

