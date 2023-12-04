namespace MousePLPL
{
    public partial class Form1 : Form
    {
        private MouseMover mouseMover = new();
        private System.Windows.Forms.Timer mouseMoveTimer = new System.Windows.Forms.Timer();

        private void StartMousePLPL()
        {
            bool moveRight = true;

            mouseMoveTimer.Interval = 3000; // 3�b���ƂɎ��s
            mouseMoveTimer.Tick += (sender, e) =>
            {
                if (moveRight)
                {
                    mouseMover.MoveMouse(20, 0); // �E��20�s�N�Z��
                }
                else
                {
                    mouseMover.MoveMouse(-20, 0); // ����20�s�N�Z��
                }
                moveRight = !moveRight; // �����𔽓]
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
                // ���ɊJ���Ă���Form1��O�ʂɕ\������
                this.Show();
                this.WindowState = FormWindowState.Normal; // �����ŏ�������Ă�����ʏ��Ԃɖ߂�
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // �t�H�[�����^�X�N�o�[�ɕ\������Ȃ��悤�ɂ���
            this.ShowInTaskbar = false;
            // �t�H�[�������[�h���ꂽ�Ƃ��Ƀ^�X�N�g���C�ɉB��
            this.Hide();
            notifyIcon1.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // �t�H�[�������[�U�[�ɂ���ĕ���ꂽ�ꍇ�́A�A�v���P�[�V�������I���������ɉB��
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void �J�nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartMousePLPL();
        }

        private void ��~ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopMousePLPL();
        }

        private void �I��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void �ݒ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Form1��\����Ԃɂ���
            this.Show();
            // �E�B���h�E��Ԃ�ʏ�ɐݒ肷��
            this.WindowState = FormWindowState.Normal;
        }

    }
}
