using System;
using System.Windows.Forms;

namespace Analyzer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1_Main());
        }
        public static string TabSelect = "TabCPU";
    }
}