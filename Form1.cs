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

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

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
