using System;
using System.Windows.Forms;

namespace BoardingHouseGUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.Run(new LoginForm());
        }
    }
}