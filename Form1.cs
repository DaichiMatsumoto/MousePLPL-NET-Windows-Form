namespace MousePLPL
{
    public partial class Form1 : Form
    {
        private MouseMover mouseMover = new();
        private System.Windows.Forms.Timer mouseMoveTimer = new System.Windows.Forms.Timer();
        private bool moveRight = true; // クラスのメンバ変数として定義

        private void StartMousePLPL()
        {
            // 既存のイベントハンドラを削除
            mouseMoveTimer.Tick -= MouseMoveTimer_Tick;
            // タイマーの設定
            mouseMoveTimer.Interval = Properties.Settings.Default.Interval * 1000;
            mouseMoveTimer.Tick += MouseMoveTimer_Tick;
            mouseMoveTimer.Start();
        }
        private void StopMousePLPL()
        {
            mouseMoveTimer.Stop();
            // イベントハンドラを削除
            mouseMoveTimer.Tick -= MouseMoveTimer_Tick;
        }
        private void MouseMoveTimer_Tick(object sender, EventArgs e)
        {
            int distance = Properties.Settings.Default.Distance;
            int moveDistance = moveRight ? distance : -distance;
            mouseMover.MoveMouse(moveDistance, 0);
            moveRight = !moveRight;
        }

        public Form1()
        {
            InitializeComponent();
            LoadSettings();
            StartMousePLPL();
        }
        private void LoadSettings()
        {
            // Properties.Settings.Default から設定を読み込む
            nph_interval.Value = Properties.Settings.Default.Interval;
            nph_distance.Value = Properties.Settings.Default.Distance;
        }

        private void SaveSettings()
        {
            // 新しい設定値を Properties.Settings.Default に保存する
            Properties.Settings.Default.Interval = (int)nph_interval.Value;
            Properties.Settings.Default.Distance = (int)nph_distance.Value;
            Properties.Settings.Default.Save();
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
            StopMousePLPL();
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

        private void btn_ok_Click(object sender, EventArgs e)
        {
            StopMousePLPL();
            SaveSettings();
            StartMousePLPL();
            this.Close(); // OKを押したらフォームを閉じる
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            StopMousePLPL();
            SaveSettings();
            // Applyを押したらフォームは閉じずに設定を適用する
            StartMousePLPL();
        }
    }
}
