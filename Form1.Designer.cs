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
            btn_ok = new Button();
            btn_apply = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            nph_interval = new NumericUpDown();
            nph_distance = new NumericUpDown();
            label3 = new Label();
            groupBox1 = new GroupBox();
            toolTip1 = new ToolTip(components);
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nph_interval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nph_distance).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(notifyIcon1, "notifyIcon1");
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.MouseClick += NotifyIcon1_MouseClick;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { コントロールToolStripMenuItem, 設定ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            toolTip1.SetToolTip(contextMenuStrip1, resources.GetString("contextMenuStrip1.ToolTip"));
            // 
            // コントロールToolStripMenuItem
            // 
            resources.ApplyResources(コントロールToolStripMenuItem, "コントロールToolStripMenuItem");
            コントロールToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 再起動ToolStripMenuItem, 停止ToolStripMenuItem, 開始ToolStripMenuItem, 終了ToolStripMenuItem });
            コントロールToolStripMenuItem.Name = "コントロールToolStripMenuItem";
            // 
            // 再起動ToolStripMenuItem
            // 
            resources.ApplyResources(再起動ToolStripMenuItem, "再起動ToolStripMenuItem");
            再起動ToolStripMenuItem.Name = "再起動ToolStripMenuItem";
            再起動ToolStripMenuItem.Click += 再起動ToolStripMenuItem_Click;
            // 
            // 停止ToolStripMenuItem
            // 
            resources.ApplyResources(停止ToolStripMenuItem, "停止ToolStripMenuItem");
            停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            停止ToolStripMenuItem.Click += 停止ToolStripMenuItem_Click;
            // 
            // 開始ToolStripMenuItem
            // 
            resources.ApplyResources(開始ToolStripMenuItem, "開始ToolStripMenuItem");
            開始ToolStripMenuItem.Name = "開始ToolStripMenuItem";
            開始ToolStripMenuItem.Click += 開始ToolStripMenuItem_Click;
            // 
            // 終了ToolStripMenuItem
            // 
            resources.ApplyResources(終了ToolStripMenuItem, "終了ToolStripMenuItem");
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.Click += 終了ToolStripMenuItem_Click;
            // 
            // 設定ToolStripMenuItem
            // 
            resources.ApplyResources(設定ToolStripMenuItem, "設定ToolStripMenuItem");
            設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            設定ToolStripMenuItem.Click += 設定ToolStripMenuItem_Click;
            // 
            // btn_ok
            // 
            resources.ApplyResources(btn_ok, "btn_ok");
            btn_ok.Name = "btn_ok";
            toolTip1.SetToolTip(btn_ok, resources.GetString("btn_ok.ToolTip"));
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_apply
            // 
            resources.ApplyResources(btn_apply, "btn_apply");
            btn_apply.Name = "btn_apply";
            toolTip1.SetToolTip(btn_apply, resources.GetString("btn_apply.ToolTip"));
            btn_apply.UseVisualStyleBackColor = true;
            btn_apply.Click += btn_apply_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            toolTip1.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            toolTip1.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            toolTip1.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // nph_interval
            // 
            resources.ApplyResources(nph_interval, "nph_interval");
            nph_interval.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nph_interval.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nph_interval.Name = "nph_interval";
            toolTip1.SetToolTip(nph_interval, resources.GetString("nph_interval.ToolTip"));
            nph_interval.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // nph_distance
            // 
            resources.ApplyResources(nph_distance, "nph_distance");
            nph_distance.Maximum = new decimal(new int[] { 2160, 0, 0, 0 });
            nph_distance.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nph_distance.Name = "nph_distance";
            toolTip1.SetToolTip(nph_distance, resources.GetString("nph_distance.ToolTip"));
            nph_distance.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            toolTip1.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nph_distance);
            groupBox1.Controls.Add(nph_interval);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            toolTip1.SetToolTip(groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(groupBox1);
            Controls.Add(btn_apply);
            Controls.Add(btn_ok);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            FormClosing += Form1_FormClosing;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nph_interval).EndInit();
            ((System.ComponentModel.ISupportInitialize)nph_distance).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btn_ok;
        private Button btn_apply;
        private Label label4;
        private Label label1;
        private Label label2;
        private NumericUpDown nph_interval;
        private NumericUpDown nph_distance;
        private Label label3;
        private GroupBox groupBox1;
        private ToolTip toolTip1;
    }
}
