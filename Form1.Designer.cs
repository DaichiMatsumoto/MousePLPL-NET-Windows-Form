namespace MousePLPL
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            コントロールToolStripMenuItem = new ToolStripMenuItem();
            再起動ToolStripMenuItem = new ToolStripMenuItem();
            停止ToolStripMenuItem = new ToolStripMenuItem();
            開始ToolStripMenuItem = new ToolStripMenuItem();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            設定ToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { コントロールToolStripMenuItem, 設定ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // コントロールToolStripMenuItem
            // 
            コントロールToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 再起動ToolStripMenuItem, 停止ToolStripMenuItem, 開始ToolStripMenuItem, 終了ToolStripMenuItem });
            コントロールToolStripMenuItem.Name = "コントロールToolStripMenuItem";
            コントロールToolStripMenuItem.Size = new Size(180, 22);
            コントロールToolStripMenuItem.Text = "コントロール";
            // 
            // 再起動ToolStripMenuItem
            // 
            再起動ToolStripMenuItem.Name = "再起動ToolStripMenuItem";
            再起動ToolStripMenuItem.Size = new Size(110, 22);
            再起動ToolStripMenuItem.Text = "再起動";
            // 
            // 停止ToolStripMenuItem
            // 
            停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            停止ToolStripMenuItem.Size = new Size(110, 22);
            停止ToolStripMenuItem.Text = "停止";
            // 
            // 開始ToolStripMenuItem
            // 
            開始ToolStripMenuItem.Name = "開始ToolStripMenuItem";
            開始ToolStripMenuItem.Size = new Size(110, 22);
            開始ToolStripMenuItem.Text = "開始";
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.Size = new Size(110, 22);
            終了ToolStripMenuItem.Text = "終了";
            終了ToolStripMenuItem.Click += 終了ToolStripMenuItem_Click;
            // 
            // 設定ToolStripMenuItem
            // 
            設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            設定ToolStripMenuItem.Size = new Size(180, 22);
            設定ToolStripMenuItem.Text = "設定";
            設定ToolStripMenuItem.Click += 設定ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 333);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 設定ToolStripMenuItem;
        private ToolStripMenuItem コントロールToolStripMenuItem;
        private ToolStripMenuItem 再起動ToolStripMenuItem;
        private ToolStripMenuItem 停止ToolStripMenuItem;
        private ToolStripMenuItem 開始ToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
    }
}
