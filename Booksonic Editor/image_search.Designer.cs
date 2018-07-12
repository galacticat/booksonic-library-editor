namespace Booksonic_Editor
{
    partial class imgSearch
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
            this.imgSearch_text = new System.Windows.Forms.TextBox();
            this.imgSearch_Button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imgSearch_text
            // 
            this.imgSearch_text.Location = new System.Drawing.Point(12, 12);
            this.imgSearch_text.Name = "imgSearch_text";
            this.imgSearch_text.Size = new System.Drawing.Size(332, 20);
            this.imgSearch_text.TabIndex = 0;
            this.imgSearch_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // imgSearch_Button
            // 
            this.imgSearch_Button.Location = new System.Drawing.Point(350, 10);
            this.imgSearch_Button.Name = "imgSearch_Button";
            this.imgSearch_Button.Size = new System.Drawing.Size(75, 23);
            this.imgSearch_Button.TabIndex = 1;
            this.imgSearch_Button.Text = "Search";
            this.imgSearch_Button.UseVisualStyleBackColor = true;
            this.imgSearch_Button.Click += new System.EventHandler(this.imgSearch_Button_Click);
            // 
            // listView1
            // 
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(12, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(413, 532);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 582);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.imgSearch_Button);
            this.Controls.Add(this.imgSearch_text);
            this.Name = "imgSearch";
            this.Text = "Image Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imgSearch_text;
        private System.Windows.Forms.Button imgSearch_Button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}