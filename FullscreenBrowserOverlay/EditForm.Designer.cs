namespace FullscreenBrowserOverlay
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.CssLabel = new System.Windows.Forms.Label();
            this.CssBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(47, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name *";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 27);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(480, 23);
            this.NameBox.TabIndex = 1;
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Location = new System.Drawing.Point(12, 53);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(36, 15);
            this.UrlLabel.TabIndex = 2;
            this.UrlLabel.Text = "URL *";
            // 
            // UrlBox
            // 
            this.UrlBox.Location = new System.Drawing.Point(12, 71);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(480, 23);
            this.UrlBox.TabIndex = 3;
            // 
            // CssLabel
            // 
            this.CssLabel.AutoSize = true;
            this.CssLabel.Location = new System.Drawing.Point(12, 97);
            this.CssLabel.Name = "CssLabel";
            this.CssLabel.Size = new System.Drawing.Size(72, 15);
            this.CssLabel.TabIndex = 4;
            this.CssLabel.Text = "Custom CSS";
            // 
            // CssBox
            // 
            this.CssBox.Location = new System.Drawing.Point(12, 115);
            this.CssBox.Multiline = true;
            this.CssBox.Name = "CssBox";
            this.CssBox.Size = new System.Drawing.Size(480, 128);
            this.CssBox.TabIndex = 5;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(417, 249);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 281);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.CssBox);
            this.Controls.Add(this.CssLabel);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.UrlLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabel;
        private TextBox NameBox;
        private Label UrlLabel;
        private TextBox UrlBox;
        private Label CssLabel;
        private TextBox CssBox;
        private Button Save;
    }
}