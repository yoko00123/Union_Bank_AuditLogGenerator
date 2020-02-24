using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsysAlphaList
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        public static string ServerNm;
        public static string UserNm;
        public static string Passwrd;
        public static string DatabaseNm;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
             ServerNm = ServerTxtbox.Text;
             UserNm = UsernameTxtbox.Text;
             Passwrd = PasswordTxtbox.Text;

            string ConnectionString = "Data Source=" + ServerNm + " ;  Persist Security Info=False; User ID=" + UserNm + ";Password=" + Passwrd + ";";

            List<string> list = new List<string>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    DatabaseCB.Enabled = true;
                    ConnectBtn.Enabled = true;
                    label1.Visible = false;
                    label1.Visible = true;
                    label1.Text = "Connection's Ready";
                    label1.ForeColor = System.Drawing.Color.Green;
                    CheckConnBtn.Enabled = false;
                }
                catch
                {
                    label1.Visible = true;
                    label1.Text = "*Invalid Username or Password";
                    label1.ForeColor = System.Drawing.Color.Red;
                    DatabaseCB.Enabled = false;
                    ConnectBtn.Enabled = false;
                    CheckConnBtn.Enabled = true;
                }
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases ORDER BY name", con))
                {
                    try
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                list.Add(dr[0].ToString());

                            }
                            foreach (string item in list)
                            {
                                DatabaseCB.Items.Add(item);
                            }
                            dr.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Database not found", ex);
                    }
                    cmd.Dispose();
                }
                con.Close();
            }
            //return String.List;
       //     CheckConnBtn.Enabled = false;
        }
        private void ServerTxtbox_Enter(object sender, EventArgs e)
        {
            if (ServerTxtbox.Text == "Server Name")
            {
                ServerTxtbox.Text = "";

                ServerTxtbox.ForeColor = Color.Black;
            }
        }
        private void ServerTxtbox_Leave(object sender, EventArgs e)
        {
            if (ServerTxtbox.Text == "")
            {
                ServerTxtbox.Text = "Server Name";

                ServerTxtbox.ForeColor = Color.Silver;
            }
        }
        private void UsernameTxtbox_Enter(object sender, EventArgs e)
        {
            if (UsernameTxtbox.Text == "Username")
            {
                UsernameTxtbox.Text = "";

                UsernameTxtbox.ForeColor = Color.Black;
            }
        }
        private void UsernameTxtbox_Leave(object sender, EventArgs e)
        {
            if (UsernameTxtbox.Text == "")
            {
                UsernameTxtbox.Text = "Username";

                UsernameTxtbox.ForeColor = Color.LightGray;
            }
        }
        private void PasswordTxtbox_Enter(object sender, EventArgs e)
        {
            if (PasswordTxtbox.Text == "Password")
            {
                PasswordTxtbox.Text = "";
                PasswordTxtbox.PasswordChar = '*';
                PasswordTxtbox.ForeColor = Color.Black;
            }
        }
        private void PasswordTxtbox_Leave(object sender, EventArgs e)
        {
            if (PasswordTxtbox.Text == "")
            {
                PasswordTxtbox.Text = "Password";
                PasswordTxtbox.ForeColor = Color.LightGray;
            }
        }
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if(DatabaseCB.SelectedIndex >= 0)
            { 
                DatabaseNm = DatabaseCB.GetItemText(DatabaseCB.SelectedItem);
                this.Hide();
                Main main = new Main();
                main.Closed += (s, args) => this.Close();
                main.Show();
            }
            else
            {
                MessageBox.Show("Please select database.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ServerTxtbox_Validating(object sender, CancelEventArgs e)
        {
            if (ServerTxtbox.Text == "Server Name")
            {
                //e.Cancel = true;
                //NameTxtbox.Focus();
                errorProvider1.SetError(ServerTxtbox, "Required field");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ServerTxtbox, "");
            }
        }

        private void UsernameTxtbox_Validating(object sender, CancelEventArgs e)
        {
            if (UsernameTxtbox.Text == "Username")
            {
                //e.Cancel = true;
                //NameTxtbox.Focus();
                errorProvider1.SetError(UsernameTxtbox, "Required field");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(UsernameTxtbox, "");
            }
        }
    }
}
