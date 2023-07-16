using Share;
using Stimulsoft.Database;
using Stimulsoft.Report;
using Stimulsoft.Report.Dialogs;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Viewer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace MisReportApp
{
    public static class Report
    {
        public static void Show(string rpt, ref StiViewerControl rptContainer, string rptName, string rptLogoPath )
        {
            StiReport report = new StiReport( );
            report.Load(rpt);
           var x= report.GetType();
            report.Dictionary.Databases.Clear();
            report.Dictionary.Databases.Add(new StiSqlDatabase("Connection", DataModule.DataContext.ConnectionString));


            foreach (var variable in report.Dictionary.Variables.Items)
            {
                switch (variable.Name.Trim())
                {
                    case "RptTitle":
                        report.Dictionary.Variables["RptTitle"].Value = rptName;
                        break;
                    case "CompanyName":
                        report.Dictionary.Variables["CompanyName"].Value = Globals.CompanyName;
                        break;
                    case "RptDate":
                        report.Dictionary.Variables["RptDate"].Value = Globals.Today;
                        break;
                    case "InputSignId":
                        report.Dictionary.Variables["InputSignId"].Value = Globals.SignId;
                        break;
                    case "InputRptLogo":
                        report.Compile();
                        report["InputRptLogo"] = Image.FromFile(rptLogoPath);
                        break;

                    default:
                        break;
                }
            }
            
 



            report.Render();
            rptContainer.Report = report;
           
        }
    }
}
