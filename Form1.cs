namespace MousePLPL
{
    public partial class Form1 : Form
    {
        private MouseMover mouseMover = new();
        private System.Windows.Forms.Timer mouseMoveTimer = new System.Windows.Forms.Timer();

        private void StartMousePLPL()
        {
            // Properties.Settings.Default ����ݒ��ǂݍ���
            int interval = Properties.Settings.Default.Interval;
            int distance = Properties.Settings.Default.Distance;
            bool moveRight = true;

            // �^�C�}�[�̃C���^�[�o����ݒ�l�Ɋ�Â��Đݒ�
            mouseMoveTimer.Interval = interval * 1000; // ��: 3000�i3�b�j
            mouseMoveTimer.Tick += (sender, e) =>
            {
                int moveDistance = moveRight ? distance : -distance;
                mouseMover.MoveMouse(moveDistance, 0); // �ݒ�l�Ɋ�Â��Ĉړ�
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
            LoadSettings();
            StartMousePLPL();
        }
        private void LoadSettings()
        {
            // Properties.Settings.Default ����ݒ��ǂݍ���
            nph_interval.Value = Properties.Settings.Default.Interval;
            nph_distance.Value = Properties.Settings.Default.Distance;
        }

        private void SaveSettings()
        {
            // �V�����ݒ�l�� Properties.Settings.Default �ɕۑ�����
            Properties.Settings.Default.Interval = (int)nph_interval.Value;
            Properties.Settings.Default.Distance = (int)nph_distance.Value;
            Properties.Settings.Default.Save();
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
            StopMousePLPL();
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

        private void btn_ok_Click(object sender, EventArgs e)
        {
            StopMousePLPL();
            SaveSettings();
            StartMousePLPL();
            this.Close(); // OK����������t�H�[�������
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            StopMousePLPL();
            SaveSettings();
            // Apply����������t�H�[���͕����ɐݒ��K�p����
            StartMousePLPL();
        }
    }
}
