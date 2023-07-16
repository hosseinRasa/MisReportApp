using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MisReportApp
{
    public partial class FrmGeneralReportViewer : Form
    {
        private readonly string _Report= string.Empty;
        public FrmGeneralReportViewer(string ReportPath, string rptTitle)
        {
            InitializeComponent();
            this.Text = rptTitle;
            this._Report = ReportPath;
        }

        private void FrmGeneralReportViewer_Load(object sender, EventArgs e)
        {
            Report.Show(_Report, ref stiVMain, this.Text, Path.Combine(Application.StartupPath, "Reports\\RptLogo.png"));

        }
    }
}
