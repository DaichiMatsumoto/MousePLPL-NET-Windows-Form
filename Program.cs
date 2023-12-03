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

            // Form1のインスタンスを作成しますが、表示はしません。
            _ = new Form1();

            // アプリケーションのメッセージループを開始します（フォームがない状態で）。
            Application.Run();
        }
    }
}