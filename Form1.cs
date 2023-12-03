namespace MousePLPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
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

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

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
