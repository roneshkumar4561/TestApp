using System;
using System.Windows.Forms;
using NLog;

namespace TestApp
{
    public static class Program
    {
        private static NLog.ILogger _logger;

        [STAThread]
        static void Main()
        {
            try
            {
                _logger = LogManager.GetCurrentClassLogger();
                _logger.Info($"{DateTime.Now:MM/dd/yy HH:mm:ss}: START");
                Application.EnableVisualStyles();
                Application.Run(new MainForm());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }                  
    }
}
