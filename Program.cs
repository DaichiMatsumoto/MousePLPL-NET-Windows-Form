namespace MousePLPL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Form1�̃C���X�^���X���쐬���܂����A�\���͂��܂���B
            _ = new Form1();

            // �A�v���P�[�V�����̃��b�Z�[�W���[�v���J�n���܂��i�t�H�[�����Ȃ���ԂŁj�B
            Application.Run();
        }
    }
}