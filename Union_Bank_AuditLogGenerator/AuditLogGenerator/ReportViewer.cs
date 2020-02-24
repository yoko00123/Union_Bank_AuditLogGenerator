using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace InsysAlphaList
{
    
    public partial class ReportViewer : Form
    {
        string server = Login.ServerNm;
        string uname = Login.UserNm;
        string pass = Login.Passwrd;
        string DBName = Login.DatabaseNm;
        int PrintCB = Main.PrintCB;
        int alphalistID = Main.alphaID;
        string year = Main.Year;
        public ReportViewer()
        {
            InitializeComponent();
        }
        
        private void ReportViewer_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=" + server + " ; Initial Catalog= " + DBName + ";  Persist Security Info=False; User ID=" + uname + ";Password=" + pass + ";";
            SqlConnection conn = new SqlConnection(connString);
            ReportDocument rpt = new ReportDocument();
            DataSet ds = new DataSet();
            string systempath = System.Windows.Forms.Application.StartupPath;
            crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            if (PrintCB == 2)
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM vz2316New where ID_Alphalist = " + alphalistID + "", "server = " + server + "; database = " + DBName + "; UID = " + uname + "; password = " + pass + "");
                    sda.SelectCommand.CommandTimeout = 180;
                    rpt.Load(@"" + systempath + "\\Contents\\2316Printable.rpt");
                    sda.Fill(ds, "vz2316New");
                    rpt.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = rpt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (PrintCB == 3)
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM vz2316New where ID_Alphalist = " + alphalistID + "", "server = " + server + "; database = " + DBName + "; UID = " + uname + "; password = " + pass + "");
                    sda.SelectCommand.CommandTimeout = 180;
                    rpt.Load(@"" + systempath + "\\Contents\\2316Latest2.rpt");
                    sda.Fill(ds, "vz2316New");
                    rpt.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = rpt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (PrintCB == 4)
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM vz1601ReportNew WHERE Year2 = " + year +"", "server = " + server + "; database = " + DBName + "; UID = " + uname + "; password = " + pass + "");
                    sda.SelectCommand.CommandTimeout = 180;
                    rpt.Load(@"" + systempath + "\\Contents\\1601.rpt");
                    sda.Fill(ds, "vz1601ReportNew");
                    rpt.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = rpt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
