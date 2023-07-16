using DataModule;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Share;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace MisReportApp
{
    public partial class FrmMain : Form
    {
        private   List<SignOwner> _SignOwners;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            piLogo.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Reports\\RptLogo.png"));
            piLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            cmbSignOwners.Items.Clear();
            _SignOwners = DataContext.GetSignOwners().ToList();

            LoadSignOwners();
            Globals.CompanyName = DataContext.GetCompanyName();
            //(cmbSignOwners.SelectedItem as dynamic).Value;

            var param = new List<SqlParameter>() {
                new  SqlParameter
                {
                    ParameterName = "UserName",
                    DbType = System.Data.DbType.String,
                    Value = Globals.CommandLineVars[0],
                },
                new  SqlParameter
                {
                    ParameterName = "Password",
                    DbType = System.Data.DbType.String,
                    Value = Globals.CommandLineVars[1],
                },
                };
            if (!DataContext.Execute("Select top 1 UserId from ComUsers where UserName = @UserName and Password = @Password"
    , param))
            {
                MessageBox.Show("کاربر مجاز به ورود نمی باشد");

                this.Close();
            }


            foreach (var item in Globals.CommandLineVars)
            {
                lstMain.Items.Add(item);
            }
        }

  

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Trim().Equals(""))
            {
                MessageBox.Show("لطفا یک فایل را انتخاب نمایید");
                return;
            }
           if (Globals.SignId.Trim().Equals(""))
            {
                MessageBox.Show("لطفا یک امضا را انتخاب نمایید");
                return;
            }
           if (!grpType0.Checked && !grpType1.Checked)
            {
                MessageBox.Show("لطفا نوع گزارش را انتخاب نمایید");
                return;
            }
             var rptTitle = Path.GetFileNameWithoutExtension(txtFileName.Text);

            if (grpType0.Checked)
            {
             new FrmGeneralReportViewer(txtFileName.Text.Trim(), rptTitle ).Show();

            }
            else
            {
                Chart.Show(txtFileName.Text);
            }
            

        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "mrt Files (*.mrt)|*.mrt";
            fileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "Reports");
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                 
 
                txtFileName.Text =  fileDialog.FileName;

            }
        }

         private void LoadSignOwners(string searchKey = "")
        {
 
            var filteredItems = _SignOwners.FindAll( x => x.Dscp.Contains(searchKey) );
            if (filteredItems.Count == 0)
            {
                return;
            }
 
            cmbSignOwners.DisplayMember = "Dscp";
            cmbSignOwners.ValueMember = "Id";
 
            filteredItems.ForEach(s => cmbSignOwners.Items.Add(new { Id = s.Id, Dscp = s.Dscp }));

        }

        private void cmbSignOwners_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            string be = Convert.ToString(cmbSignOwners.SelectedItem);
            var x = be.Substring(be.IndexOf("=")+1, be.IndexOf(",") - be.IndexOf("=") -1);
            Globals.SignId = x;
         
 
        }
    }
}
