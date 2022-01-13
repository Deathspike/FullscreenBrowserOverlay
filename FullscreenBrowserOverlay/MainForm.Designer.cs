namespace FullscreenBrowserOverlay
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.ContextMenu;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuAdd,
            this.ContextMenuExit,
            this.ContextMenuSeparator});
            this.ContextMenu.Name = "contextMenuStrip1";
            this.ContextMenu.Size = new System.Drawing.Size(158, 54);
            this.ContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.OnContextMenuOpening);
            // 
            // ContextMenuAdd
            // 
            this.ContextMenuAdd.Name = "ContextMenuAdd";
            this.ContextMenuAdd.Size = new System.Drawing.Size(157, 22);
            this.ContextMenuAdd.Text = "Add New Item";
            this.ContextMenuAdd.Click += new System.EventHandler(this.OnContextMenuAdd);
            // 
            // ContextMenuExit
            // 
            this.ContextMenuExit.Name = "ContextMenuExit";
            this.ContextMenuExit.Size = new System.Drawing.Size(157, 22);
            this.ContextMenuExit.Text = "Exit Application";
            this.ContextMenuExit.Click += new System.EventHandler(this.OnContextMenuExit);
            // 
            // ContextMenuSeparator
            // 
            this.ContextMenuSeparator.Name = "ContextMenuSeparator";
            this.ContextMenuSeparator.Size = new System.Drawing.Size(154, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.LimeGreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon NotifyIcon;
        private ContextMenuStrip ContextMenu;
        private ToolStripMenuItem ContextMenuAdd;
        private ToolStripSeparator ContextMenuSeparator;
        private ToolStripMenuItem ContextMenuExit;
    }
}