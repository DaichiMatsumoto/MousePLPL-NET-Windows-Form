namespace MousePLPL
{
    public partial class Form1 : Form
    {
        private MouseMover mouseMover = new();
        private System.Windows.Forms.Timer mouseMoveTimer = new System.Windows.Forms.Timer();

        private void StartMousePLPL()
        {
            bool moveRight = true;

            mouseMoveTimer.Interval = 3000; // 3秒ごとに実行
            mouseMoveTimer.Tick += (sender, e) =>
            {
                if (moveRight)
                {
                    mouseMover.MoveMouse(20, 0); // 右に20ピクセル
                }
                else
                {
                    mouseMover.MoveMouse(-20, 0); // 左に20ピクセル
                }
                moveRight = !moveRight; // 方向を反転
            };
            mouseMoveTimer.Start();
        }

        private void StopMousePLPL()
        {
            mouseMoveTimer.Stop();
        }

        public Form1()
        {
            InitializeComponent();
            StartMousePLPL();
        }

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 既に開いているForm1を前面に表示する
                this.Show();
                this.WindowState = FormWindowState.Normal; // もし最小化されていたら通常状態に戻す
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // フォームがタスクバーに表示されないようにする
            this.ShowInTaskbar = false;
            // フォームがロードされたときにタスクトレイに隠す
            this.Hide();
            notifyIcon1.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // フォームがユーザーによって閉じられた場合は、アプリケーションを終了させずに隠す
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void 開始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartMousePLPL();
        }

        private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopMousePLPL();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Form1を表示状態にする
            this.Show();
            // ウィンドウ状態を通常に設定する
            this.WindowState = FormWindowState.Normal;
        }

    }
}
