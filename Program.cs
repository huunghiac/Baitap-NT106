namespace NT106_2._2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Modify modify = new Modify();

            bool ok = modify.CheckLogin("admin", "MyS3cr3t!");
            Console.WriteLine(ok ? "??ng nh?p th�nh c�ng" : "Sai m?t kh?u");
        }
    }
}