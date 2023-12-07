namespace MousePLPL
{
    public partial class Form1 : Form
    {
        private MouseMover mouseMover = new();
        private System.Windows.Forms.Timer mouseMoveTimer = new System.Windows.Forms.Timer();
        private bool moveRight = true; // �N���X�̃����o�ϐ��Ƃ��Ē�`

        private void StartMousePLPL()
        {
            // �����̃C�x���g�n���h�����폜
            mouseMoveTimer.Tick -= MouseMoveTimer_Tick;
            // �^�C�}�[�̐ݒ�
            mouseMoveTimer.Interval = Properties.Settings.Default.Interval * 1000;
            mouseMoveTimer.Tick += MouseMoveTimer_Tick;
            mouseMoveTimer.Start();
        }
        private void StopMousePLPL()
        {
            mouseMoveTimer.Stop();
            // �C�x���g�n���h�����폜
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
