using System;
using System.Windows.Forms;

namespace WinFormUI
{
    //// Good Luck for us ;)
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}