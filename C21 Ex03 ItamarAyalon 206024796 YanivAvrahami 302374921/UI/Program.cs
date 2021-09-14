using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace UI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}