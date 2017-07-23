namespace Booksonic_Editor
{
    partial class Configuration
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
            this.libraryPath_label = new System.Windows.Forms.Label();
            this.javaPath_label = new System.Windows.Forms.Label();
            this.scriptPath_label = new System.Windows.Forms.Label();
            this.libraryPath_value = new System.Windows.Forms.TextBox();
            this.javaPath_value = new System.Windows.Forms.TextBox();
            this.scriptPath_value = new System.Windows.Forms.TextBox();
            this.libraryPath_button = new System.Windows.Forms.Button();
            this.javaPath_button = new System.Windows.Forms.Button();
            this.scriptPath_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // libraryPath_label
            // 
            this.libraryPath_label.AutoSize = true;
            this.libraryPath_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libraryPath_label.Location = new System.Drawing.Point(13, 13);
            this.libraryPath_label.Name = "libraryPath_label";
            this.libraryPath_label.Size = new System.Drawing.Size(75, 13);
            this.libraryPath_label.TabIndex = 0;
            this.libraryPath_label.Text = "Library Path";
            // 
            // javaPath_label
            // 
            this.javaPath_label.AutoSize = true;
            this.javaPath_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.javaPath_label.Location = new System.Drawing.Point(24, 41);
            this.javaPath_label.Name = "javaPath_label";
            this.javaPath_label.Size = new System.Drawing.Size(64, 13);
            this.javaPath_label.TabIndex = 0;
            this.javaPath_label.Text = "Java Path";
            // 
            // scriptPath_label
            // 
            this.scriptPath_label.AutoSize = true;
            this.scriptPath_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptPath_label.Location = new System.Drawing.Point(18, 71);
            this.scriptPath_label.Name = "scriptPath_label";
            this.scriptPath_label.Size = new System.Drawing.Size(70, 13);
            this.scriptPath_label.TabIndex = 0;
            this.scriptPath_label.Text = "Script Path";
            // 
            // libraryPath_value
            // 
            this.libraryPath_value.Location = new System.Drawing.Point(94, 10);
            this.libraryPath_value.Name = "libraryPath_value";
            this.libraryPath_value.Size = new System.Drawing.Size(307, 20);
            this.libraryPath_value.TabIndex = 1;
            this.libraryPath_value.TextChanged += new System.EventHandler(this.libraryPath_value_TextChanged);
            // 
            // javaPath_value
            // 
            this.javaPath_value.Location = new System.Drawing.Point(94, 38);
            this.javaPath_value.Name = "javaPath_value";
            this.javaPath_value.Size = new System.Drawing.Size(307, 20);
            this.javaPath_value.TabIndex = 1;
            this.javaPath_value.TextChanged += new System.EventHandler(this.javaPath_value_TextChanged);
            // 
            // scriptPath_value
            // 
            this.scriptPath_value.Location = new System.Drawing.Point(94, 68);
            this.scriptPath_value.Name = "scriptPath_value";
            this.scriptPath_value.Size = new System.Drawing.Size(307, 20);
            this.scriptPath_value.TabIndex = 1;
            this.scriptPath_value.TextChanged += new System.EventHandler(this.scriptPath_value_TextChanged);
            // 
            // libraryPath_button
            // 
            this.libraryPath_button.Location = new System.Drawing.Point(407, 8);
            this.libraryPath_button.Name = "libraryPath_button";
            this.libraryPath_button.Size = new System.Drawing.Size(75, 23);
            this.libraryPath_button.TabIndex = 2;
            this.libraryPath_button.Text = "Browse";
            this.libraryPath_button.UseVisualStyleBackColor = true;
            this.libraryPath_button.Click += new System.EventHandler(this.libraryPath_button_Click);
            // 
            // javaPath_button
            // 
            this.javaPath_button.Location = new System.Drawing.Point(407, 36);
            this.javaPath_button.Name = "javaPath_button";
            this.javaPath_button.Size = new System.Drawing.Size(75, 23);
            this.javaPath_button.TabIndex = 2;
            this.javaPath_button.Text = "Browse";
            this.javaPath_button.UseVisualStyleBackColor = true;
            this.javaPath_button.Click += new System.EventHandler(this.javaPath_button_Click);
            // 
            // scriptPath_button
            // 
            this.scriptPath_button.Location = new System.Drawing.Point(407, 66);
            this.scriptPath_button.Name = "scriptPath_button";
            this.scriptPath_button.Size = new System.Drawing.Size(75, 23);
            this.scriptPath_button.TabIndex = 2;
            this.scriptPath_button.Text = "Browse";
            this.scriptPath_button.UseVisualStyleBackColor = true;
            this.scriptPath_button.Click += new System.EventHandler(this.scriptPath_button_Click);
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.Location = new System.Drawing.Point(407, 97);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save_button.Location = new System.Drawing.Point(326, 97);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 132);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.scriptPath_button);
            this.Controls.Add(this.javaPath_button);
            this.Controls.Add(this.libraryPath_button);
            this.Controls.Add(this.scriptPath_value);
            this.Controls.Add(this.javaPath_value);
            this.Controls.Add(this.libraryPath_value);
            this.Controls.Add(this.scriptPath_label);
            this.Controls.Add(this.javaPath_label);
            this.Controls.Add(this.libraryPath_label);
            this.MinimumSize = new System.Drawing.Size(502, 171);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label libraryPath_label;
        private System.Windows.Forms.Label javaPath_label;
        private System.Windows.Forms.Label scriptPath_label;
        private System.Windows.Forms.TextBox libraryPath_value;
        private System.Windows.Forms.TextBox javaPath_value;
        private System.Windows.Forms.TextBox scriptPath_value;
        private System.Windows.Forms.Button libraryPath_button;
        private System.Windows.Forms.Button javaPath_button;
        private System.Windows.Forms.Button scriptPath_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button save_button;
    }
}