using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace InsysAlphaList
{
    public partial class Main : Form
    {
        string server = Login.ServerNm;
        string uname = Login.UserNm;
        string pass = Login.Passwrd;
        string DBName = Login.DatabaseNm;
        public static int PrintCB;
        public static int alphaID;
        public static string Year;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=" + server + " ; Initial Catalog= " + DBName + ";  Persist Security Info=False; User ID=" + uname + ";Password=" + pass + ";";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT ID, NAME FROM tCompany", conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    DataRow row = dt.NewRow();
                    CompanyCB.DataSource = dt;
                    CompanyCB.DisplayMember = "Name";
                    CompanyCB.ValueMember = "ID";
                }
            }
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
        }


        private void ToExcel(DataGridView dGV, string filename)
        {
            string stOutput = "";
            string sHeaders = "";
            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";

            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length);
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "Audit Log.xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //ToCsV(dataGridView1, @"c:\AlphalistDetails.xls");
                    ToExcel(dataGridView1, sfd.FileName);
                    MessageBox.Show("File Downloaded!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                try
                {
                    string csv = string.Empty;
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        csv += column.HeaderText + ',' + " ";
                    }
                    csv += "\r\n";


                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                csv += cell.Value.ToString().TrimEnd(',').Replace(",", "") + "," + " ";
                            }
                        }
                        csv += "\r\n";
                    }
                    //string folderPath = "C:\\Users\\"+ Environment.UserName +"\\Desktop\\";
                    string path = Path.GetPathRoot(Environment.SystemDirectory);
                    string folderPath = "" + path + "Users\\" + Environment.UserName + "\\Desktop\\";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    System.Guid guid = System.Guid.NewGuid();
                    string gid = guid.ToString();
                    File.WriteAllText(folderPath + "AlphaListDetailed_" + gid + ".csv", csv);
                    MessageBox.Show("File Downloaded!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Failed to Download!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                ReportViewer rv = new ReportViewer();
                rv.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != null)
            {
                button1.Enabled = true;
            }
            PrintCB = comboBox1.SelectedIndex;
        }

        private void Main_Activated(object sender, EventArgs e)
        {

            try
            {
             //   alphaID = Convert.ToInt32(ReferenceTxtbox.Text);
                //Year = YearTxtbox.Text;
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vzAuditTrailCDC ORDER BY DateTimeModified DESC", "server = " + server + "; database = " + DBName + "; UID = " + uname + "; password = " + pass + "");
                DataSet ds = new DataSet();
                da.Fill(ds, "tAuditTrail");
                dataGridView1.DataSource = ds.Tables["tAuditTrail"].DefaultView;
              //  dataGridView1.Columns["ID_Alphalist"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
    
}
