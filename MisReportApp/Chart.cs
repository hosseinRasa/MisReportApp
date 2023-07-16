using Share;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Viewer;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Text;

namespace MisReportApp
{
    public class Chart
    {
        public static void Show(string rpt)
        {
            StiReport report = new StiReport();
            report.Load(rpt);
            report.Dictionary.Databases.Clear();
            report.Dictionary.Databases.Add(new StiSqlDatabase("Connection", DataModule.DataContext.ConnectionString));
 

            report.Show();
            

        }
    }
}
