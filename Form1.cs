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
                // �ݒ�t�H�[����\������R�[�h
                Form1 settingsForm = new();
                settingsForm.Show();
            }
        }
    }
}
