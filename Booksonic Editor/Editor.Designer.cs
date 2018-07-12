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
            this.reader_textBox = new System.Windows.Forms.TextBox();
            this.library_groupBox = new System.Windows.Forms.GroupBox();
            this.script_button = new System.Windows.Forms.Button();
            this.nextNode_button = new System.Windows.Forms.Button();
            this.previousNode_button = new System.Windows.Forms.Button();
            this.collapseAll_button = new System.Windows.Forms.Button();
            this.expandAll_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.LibraryPath_value = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.LibraryPath_label = new System.Windows.Forms.Label();
            this.search_label = new System.Windows.Forms.Label();
            this.configure_button = new System.Windows.Forms.Button();
            this.library_list = new System.Windows.Forms.TreeView();
            this.refresh_button = new System.Windows.Forms.Button();
            this.bookdata_groupBox = new System.Windows.Forms.GroupBox();
            this.imgSearch_button = new System.Windows.Forms.Button();
            this.imageToLoad_value = new System.Windows.Forms.Label();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.coverPath_button = new System.Windows.Forms.Button();
            this.book_title = new System.Windows.Forms.Label();
            this.bookTitle_label = new System.Windows.Forms.Label();
            this.desc_textBox = new System.Windows.Forms.RichTextBox();
            this.open_button = new System.Windows.Forms.Button();
            this.BookPath_value = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.BookPath_label = new System.Windows.Forms.Label();
            this.desc_label = new System.Windows.Forms.Label();
            this.cover_label = new System.Windows.Forms.Label();
            this.reader_label = new System.Windows.Forms.Label();
            this.cover_textBox = new System.Windows.Forms.TextBox();
            this.libraryLoad_progressbar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.library_groupBox.SuspendLayout();
            this.bookdata_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // reader_textBox
            // 
            this.reader_textBox.Enabled = false;
            this.reader_textBox.Location = new System.Drawing.Point(69, 99);
            this.reader_textBox.Name = "reader_textBox";
            this.reader_textBox.Size = new System.Drawing.Size(250, 20);
            this.reader_textBox.TabIndex = 1;
            this.reader_textBox.TextChanged += new System.EventHandler(this.BookData_textBox_TextChanged);
            // 
            // library_groupBox
            // 
            this.library_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.library_groupBox.Controls.Add(this.script_button);
            this.library_groupBox.Controls.Add(this.nextNode_button);
            this.library_groupBox.Controls.Add(this.previousNode_button);
            this.library_groupBox.Controls.Add(this.collapseAll_button);
            this.library_groupBox.Controls.Add(this.expandAll_button);
            this.library_groupBox.Controls.Add(this.search_button);
            this.library_groupBox.Controls.Add(this.LibraryPath_value);
            this.library_groupBox.Controls.Add(this.search_textBox);
            this.library_groupBox.Controls.Add(this.LibraryPath_label);
            this.library_groupBox.Controls.Add(this.search_label);
            this.library_groupBox.Controls.Add(this.configure_button);
            this.library_groupBox.Controls.Add(this.library_list);
            this.library_groupBox.Controls.Add(this.refresh_button);
            this.library_groupBox.Location = new System.Drawing.Point(12, 12);
            this.library_groupBox.Name = "library_groupBox";
            this.library_groupBox.Size = new System.Drawing.Size(352, 537);
            this.library_groupBox.TabIndex = 3;
            this.library_groupBox.TabStop = false;
            this.library_groupBox.Text = "Library";
            // 
            // script_button
            // 
            this.script_button.Location = new System.Drawing.Point(280, 248);
            this.script_button.Name = "script_button";
            this.script_button.Size = new System.Drawing.Size(69, 46);
            this.script_button.TabIndex = 14;
            this.script_button.Text = "Run Script";
            this.script_button.UseVisualStyleBackColor = true;
            this.script_button.Click += new System.EventHandler(this.script_button_Click);
            // 
            // nextNode_button
            // 
            this.nextNode_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextNode_button.Location = new System.Drawing.Point(280, 199);
            this.nextNode_button.Margin = new System.Windows.Forms.Padding(0);
            this.nextNode_button.Name = "nextNode_button";
            this.nextNode_button.Size = new System.Drawing.Size(69, 46);
            this.nextNode_button.TabIndex = 14;
            this.nextNode_button.Text = "Next Book";
            this.nextNode_button.UseVisualStyleBackColor = true;
            this.nextNode_button.Click += new System.EventHandler(this.nextNode_button_Click);
            // 
            // previousNode_button
            // 
            this.previousNode_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousNode_button.Location = new System.Drawing.Point(280, 151);
            this.previousNode_button.Margin = new System.Windows.Forms.Padding(0);
            this.previousNode_button.Name = "previousNode_button";
            this.previousNode_button.Size = new System.Drawing.Size(69, 46);
            this.previousNode_button.TabIndex = 13;
            this.previousNode_button.Text = "Prev Book";
            this.previousNode_button.UseVisualStyleBackColor = true;
            this.previousNode_button.Click += new System.EventHandler(this.previousNode_button_Click);
            // 
            // collapseAll_button
            // 
            this.collapseAll_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collapseAll_button.Location = new System.Drawing.Point(280, 102);
            this.collapseAll_button.Margin = new System.Windows.Forms.Padding(0);
            this.collapseAll_button.Name = "collapseAll_button";
            this.collapseAll_button.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.collapseAll_button.Size = new System.Drawing.Size(69, 46);
            this.collapseAll_button.TabIndex = 12;
            this.collapseAll_button.Text = "Collapse All";
            this.collapseAll_button.UseVisualStyleBackColor = true;
            this.collapseAll_button.Click += new System.EventHandler(this.collapseAll_button_Click);
            // 
            // expandAll_button
            // 
            this.expandAll_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandAll_button.Location = new System.Drawing.Point(280, 53);
            this.expandAll_button.Margin = new System.Windows.Forms.Padding(0);
            this.expandAll_button.Name = "expandAll_button";
            this.expandAll_button.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.expandAll_button.Size = new System.Drawing.Size(69, 46);
            this.expandAll_button.TabIndex = 11;
            this.expandAll_button.Text = "Expand All";
            this.expandAll_button.UseVisualStyleBackColor = true;
            this.expandAll_button.Click += new System.EventHandler(this.expandAll_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(280, 25);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(69, 23);
            this.search_button.TabIndex = 10;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // LibraryPath_value
            // 
            this.LibraryPath_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LibraryPath_value.AutoSize = true;
            this.LibraryPath_value.Location = new System.Drawing.Point(84, 518);
            this.LibraryPath_value.Name = "LibraryPath_value";
            this.LibraryPath_value.Size = new System.Drawing.Size(102, 13);
            this.LibraryPath_value.TabIndex = 9;
            this.LibraryPath_value.Text = "Directory Not Found";
            // 
            // search_textBox
            // 
            this.search_textBox.AcceptsReturn = true;
            this.search_textBox.Location = new System.Drawing.Point(63, 27);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(214, 20);
            this.search_textBox.TabIndex = 8;
            // 
            // LibraryPath_label
            // 
            this.LibraryPath_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LibraryPath_label.AutoSize = true;
            this.LibraryPath_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryPath_label.Location = new System.Drawing.Point(6, 518);
            this.LibraryPath_label.Name = "LibraryPath_label";
            this.LibraryPath_label.Size = new System.Drawing.Size(79, 13);
            this.LibraryPath_label.TabIndex = 3;
            this.LibraryPath_label.Text = "Library Path:";
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_label.Location = new System.Drawing.Point(6, 30);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(51, 13);
            this.search_label.TabIndex = 3;
            this.search_label.Text = "Search:";
            // 
            // configure_button
            // 
            this.configure_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.configure_button.Location = new System.Drawing.Point(87, 492);
            this.configure_button.Name = "configure_button";
            this.configure_button.Size = new System.Drawing.Size(75, 23);
            this.configure_button.TabIndex = 6;
            this.configure_button.Text = "Configure";
            this.configure_button.UseVisualStyleBackColor = true;
            this.configure_button.Click += new System.EventHandler(this.configure_button_Click);
            // 
            // library_list
            // 
            this.library_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.library_list.HideSelection = false;
            this.library_list.Location = new System.Drawing.Point(6, 53);
            this.library_list.Name = "library_list";
            this.library_list.Size = new System.Drawing.Size(271, 433);
            this.library_list.TabIndex = 5;
            this.library_list.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.library_list_AfterSelect);
            // 
            // refresh_button
            // 
            this.refresh_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refresh_button.Location = new System.Drawing.Point(6, 492);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 23);
            this.refresh_button.TabIndex = 1;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // bookdata_groupBox
            // 
            this.bookdata_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookdata_groupBox.Controls.Add(this.imgSearch_button);
            this.bookdata_groupBox.Controls.Add(this.imageToLoad_value);
            this.bookdata_groupBox.Controls.Add(this.coverPictureBox);
            this.bookdata_groupBox.Controls.Add(this.coverPath_button);
            this.bookdata_groupBox.Controls.Add(this.book_title);
            this.bookdata_groupBox.Controls.Add(this.bookTitle_label);
            this.bookdata_groupBox.Controls.Add(this.desc_textBox);
            this.bookdata_groupBox.Controls.Add(this.open_button);
            this.bookdata_groupBox.Controls.Add(this.BookPath_value);
            this.bookdata_groupBox.Controls.Add(this.save_button);
            this.bookdata_groupBox.Controls.Add(this.BookPath_label);
            this.bookdata_groupBox.Controls.Add(this.desc_label);
            this.bookdata_groupBox.Controls.Add(this.cover_label);
            this.bookdata_groupBox.Controls.Add(this.reader_label);
            this.bookdata_groupBox.Controls.Add(this.cover_textBox);
            this.bookdata_groupBox.Controls.Add(this.reader_textBox);
            this.bookdata_groupBox.Location = new System.Drawing.Point(370, 12);
            this.bookdata_groupBox.Name = "bookdata_groupBox";
            this.bookdata_groupBox.Size = new System.Drawing.Size(486, 537);
            this.bookdata_groupBox.TabIndex = 4;
            this.bookdata_groupBox.TabStop = false;
            this.bookdata_groupBox.Text = "Book Data";
            // 
            // imgSearch_button
            // 
            this.imgSearch_button.Location = new System.Drawing.Point(406, 129);
            this.imgSearch_button.Name = "imgSearch_button";
            this.imgSearch_button.Size = new System.Drawing.Size(75, 23);
            this.imgSearch_button.TabIndex = 17;
            this.imgSearch_button.Text = "Search";
            this.imgSearch_button.UseVisualStyleBackColor = true;
            this.imgSearch_button.Click += new System.EventHandler(this.imgSearch_button_Click);
            // 
            // imageToLoad_value
            // 
            this.imageToLoad_value.AutoSize = true;
            this.imageToLoad_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageToLoad_value.Location = new System.Drawing.Point(66, 155);
            this.imageToLoad_value.Name = "imageToLoad_value";
            this.imageToLoad_value.Size = new System.Drawing.Size(105, 13);
            this.imageToLoad_value.TabIndex = 16;
            this.imageToLoad_value.Text = "!ImageToLoadLabel!";
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coverPictureBox.Enabled = false;
            this.coverPictureBox.Location = new System.Drawing.Point(373, 15);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(100, 100);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 15;
            this.coverPictureBox.TabStop = false;
            this.coverPictureBox.Click += new System.EventHandler(this.coverPictureBox_Click);
            // 
            // coverPath_button
            // 
            this.coverPath_button.Location = new System.Drawing.Point(325, 130);
            this.coverPath_button.Name = "coverPath_button";
            this.coverPath_button.Size = new System.Drawing.Size(75, 23);
            this.coverPath_button.TabIndex = 14;
            this.coverPath_button.Text = "Browse";
            this.coverPath_button.UseVisualStyleBackColor = true;
            this.coverPath_button.Click += new System.EventHandler(this.coverPath_button_Click);
            // 
            // book_title
            // 
            this.book_title.AutoSize = true;
            this.book_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_title.Location = new System.Drawing.Point(45, 30);
            this.book_title.Name = "book_title";
            this.book_title.Size = new System.Drawing.Size(68, 13);
            this.book_title.TabIndex = 13;
            this.book_title.Text = "No Selection";
            // 
            // bookTitle_label
            // 
            this.bookTitle_label.AutoSize = true;
            this.bookTitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitle_label.Location = new System.Drawing.Point(6, 30);
            this.bookTitle_label.Name = "bookTitle_label";
            this.bookTitle_label.Size = new System.Drawing.Size(40, 13);
            this.bookTitle_label.TabIndex = 12;
            this.bookTitle_label.Text = "Book:";
            // 
            // desc_textBox
            // 
            this.desc_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desc_textBox.Enabled = false;
            this.desc_textBox.Location = new System.Drawing.Point(6, 184);
            this.desc_textBox.Name = "desc_textBox";
            this.desc_textBox.Size = new System.Drawing.Size(472, 302);
            this.desc_textBox.TabIndex = 11;
            this.desc_textBox.Text = "";
            this.desc_textBox.TextChanged += new System.EventHandler(this.BookData_textBox_TextChanged);
            // 
            // open_button
            // 
            this.open_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.open_button.Enabled = false;
            this.open_button.Location = new System.Drawing.Point(87, 492);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(98, 23);
            this.open_button.TabIndex = 10;
            this.open_button.Text = "Open Location";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // BookPath_value
            // 
            this.BookPath_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BookPath_value.AutoSize = true;
            this.BookPath_value.Location = new System.Drawing.Point(75, 518);
            this.BookPath_value.Name = "BookPath_value";
            this.BookPath_value.Size = new System.Drawing.Size(68, 13);
            this.BookPath_value.TabIndex = 9;
            this.BookPath_value.Text = "No Selection";
            // 
            // save_button
            // 
            this.save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save_button.Enabled = false;
            this.save_button.Location = new System.Drawing.Point(6, 492);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // BookPath_label
            // 
            this.BookPath_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BookPath_label.AutoSize = true;
            this.BookPath_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPath_label.Location = new System.Drawing.Point(6, 518);
            this.BookPath_label.Name = "BookPath_label";
            this.BookPath_label.Size = new System.Drawing.Size(70, 13);
            this.BookPath_label.TabIndex = 3;
            this.BookPath_label.Text = "Book Path:";
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_label.Location = new System.Drawing.Point(6, 168);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(90, 13);
            this.desc_label.TabIndex = 3;
            this.desc_label.Text = "Book Synopsis";
            // 
            // cover_label
            // 
            this.cover_label.AutoSize = true;
            this.cover_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cover_label.Location = new System.Drawing.Point(6, 135);
            this.cover_label.Name = "cover_label";
            this.cover_label.Size = new System.Drawing.Size(44, 13);
            this.cover_label.TabIndex = 3;
            this.cover_label.Text = "Cover:";
            // 
            // reader_label
            // 
            this.reader_label.AutoSize = true;
            this.reader_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reader_label.Location = new System.Drawing.Point(6, 102);
            this.reader_label.Name = "reader_label";
            this.reader_label.Size = new System.Drawing.Size(57, 13);
            this.reader_label.TabIndex = 3;
            this.reader_label.Text = "Narrator:";
            // 
            // cover_textBox
            // 
            this.cover_textBox.Enabled = false;
            this.cover_textBox.Location = new System.Drawing.Point(69, 132);
            this.cover_textBox.Name = "cover_textBox";
            this.cover_textBox.Size = new System.Drawing.Size(250, 20);
            this.cover_textBox.TabIndex = 1;
            this.cover_textBox.TextChanged += new System.EventHandler(this.BookData_textBox_TextChanged);
            // 
            // libraryLoad_progressbar
            // 
            this.libraryLoad_progressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.libraryLoad_progressbar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.libraryLoad_progressbar.Location = new System.Drawing.Point(0, 549);
            this.libraryLoad_progressbar.Name = "libraryLoad_progressbar";
            this.libraryLoad_progressbar.Size = new System.Drawing.Size(868, 12);
            this.libraryLoad_progressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.libraryLoad_progressbar.TabIndex = 5;
            this.libraryLoad_progressbar.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 561);
            this.Controls.Add(this.libraryLoad_progressbar);
            this.Controls.Add(this.bookdata_groupBox);
            this.Controls.Add(this.library_groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(835, 600);
            this.Name = "Editor";
            this.Text = "Booksonic Library Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.library_groupBox.ResumeLayout(false);
            this.library_groupBox.PerformLayout();
            this.bookdata_groupBox.ResumeLayout(false);
            this.bookdata_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox reader_textBox;
        private System.Windows.Forms.GroupBox library_groupBox;
        private System.Windows.Forms.Button configure_button;
        private System.Windows.Forms.TreeView library_list;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.GroupBox bookdata_groupBox;
        private System.Windows.Forms.Label desc_label;
        private System.Windows.Forms.Label reader_label;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Label LibraryPath_value;
        private System.Windows.Forms.Label LibraryPath_label;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label BookPath_value;
        private System.Windows.Forms.Label BookPath_label;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button expandAll_button;
        private System.Windows.Forms.Button collapseAll_button;
        private System.Windows.Forms.RichTextBox desc_textBox;
        private System.Windows.Forms.Label bookTitle_label;
        private System.Windows.Forms.Label book_title;
        private System.Windows.Forms.Button nextNode_button;
        private System.Windows.Forms.Button previousNode_button;
        private System.Windows.Forms.ProgressBar libraryLoad_progressbar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button script_button;
        private System.Windows.Forms.Label cover_label;
        private System.Windows.Forms.TextBox cover_textBox;
        private System.Windows.Forms.Button coverPath_button;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Label imageToLoad_value;
        private System.Windows.Forms.Button imgSearch_button;
    }
}

