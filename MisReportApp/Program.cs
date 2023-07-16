using Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisReportApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Globals.CommandLineVars = args;
            if (args.Length < 1)
            {
                MessageBox.Show("شما مجاز نیستید");
                return;
            }

            //Globals.CommandLineVars[3] = args[3];
            Globals.ServerAddress = args[2];
            Globals.DbName = args[3];
        
            Globals.Today = args[4];
            DataModule.DataContext.ConnectionString = $"Data Source={Globals.ServerAddress};" +
                $"Initial Catalog={Globals.DbName}; User Id={Globals.UserName}; Password={Globals.Password};TrustServerCertificate=True;";
                //System.Configuration.ConfigurationManager.AppSettings["AppConnectionString"];
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
