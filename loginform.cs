using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace WindowsFormsApplication1
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HCSTTAF;Initial Catalog=bank;Persist Security Info=True;User ID=sa;Password=azaanpc");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from login where username = @usr and password = @pswd",con);
            SqlParameter[] param = new SqlParameter[2]; 
            param[0] = new SqlParameter("@usr", username.Text);
            param[1] = new SqlParameter("@pswd", pswd.Text);
            cmd.Parameters.Add(param[0]);
            cmd.Parameters.Add(param[1]);
            //con.Open();
            object res = cmd.ExecuteScalar();
            con.Close();
            if (Convert.ToInt32(res) > 0) 
            {
                this.Hide();
                menuu f7 = new menuu();
                f7.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
                return;
            }  
            con.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if(showpass.Checked)
            {
                pswd.UseSystemPasswordChar = false;
            }
            else
            {
                pswd.UseSystemPasswordChar = true;
            }
        }
    }
}
