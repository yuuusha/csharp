using CIAKOD24;

namespace PLWindows
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new PLCatalog());
        }
    }
}