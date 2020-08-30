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
using System.Data.OleDb;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class transfer : Form
    {
        SqlConnection MyConnection = new SqlConnection(@"Data Source=DESKTOP-HCSTTAF;Initial Catalog=bank;Persist Security Info=True;User ID=sa;Password=azaanpc");
        //IDbConnection conn = new IDbConnection("Data Source=DESKTOP-HCSTTAF;Initial Catalog=bank;Integrated Security=True");
        SqlCommand MyCommand;
        SqlDataReader MyDataReader;

        public transfer()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)// 8 means we can only use backspace key and !char for to enter digits only other than that will not be
            //entertained
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection MyConnection = new SqlConnection(@"Data Source=DESKTOP-HCSTTAF;Initial Catalog=bank;Persist Security Info=True;User ID=sa;Password=azaanpc"))
                {
                    MyConnection.Open();
                    using (SqlCommand command1 = new SqlCommand("select balance from bannnk where id=@id", MyConnection))
                    {
                            command1.Parameters.AddWithValue("@id", balfrom.Text);
                            SqlDataReader rdr = command1.ExecuteReader();
                            rdr.Read();
                            label4.Text = rdr["balance"].ToString();
                            rdr.Close();
                    }
                    using (SqlCommand command2 = new SqlCommand("select balance from bannnk where id=@id1", MyConnection))
                    {
                        command2.Parameters.AddWithValue("@id1", to.Text);
                            SqlDataReader rdr1 = command2.ExecuteReader();
                            rdr1.Read();
                            label5.Text = rdr1["balance"].ToString();
                            rdr1.Close();
                    }
                    int amtfrom = Int32.Parse(label4.Text);
                    int amount = Int32.Parse(money.Text);
                    int amtto = Int32.Parse(label5.Text);
                    int tpls = (amtto + amount);
                    int tmin = (amtfrom - amount);
                    if (amtfrom < amount)
                    {
                        DialogResult d = MessageBox.Show("Low Balance", "MessageBox Title", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                    {
                        return;
                    }

                    }
                    else
                    {
                        using (SqlCommand command3 = new SqlCommand("update bannnk set balance=@ammt where id=@id2", MyConnection))
                        {
                            command3.Parameters.AddWithValue("@id2", to.Text);
                            command3.Parameters.AddWithValue("@ammt", tpls);
                            command3.ExecuteNonQuery();
                            MessageBox.Show("1st");
                        }
                        using (SqlCommand command4 = new SqlCommand("update bannnk set balance=@ammt where id=@id2", MyConnection))
                        {
                            command4.Parameters.AddWithValue("@id2", balfrom.Text);
                            command4.Parameters.AddWithValue("@ammt", tmin);
                            command4.ExecuteNonQuery();
                            MessageBox.Show("2nd");
                        }
                    }
                    MyConnection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            using (SqlConnection MyConnection1 = new SqlConnection(@"Data Source=DESKTOP-HCSTTAF;Initial Catalog=bank;Persist Security Info=True;User ID=sa;Password=azaanpc"))
            {
                MyConnection1.Open();
                string sql = "";
                sql = "Insert into [transaction] (sender_id,reciever_id,Sender_Balance,Reciever_Balance,Amount,DateTime)values(@id1,@id2,@sender,@rcvr,@amt,@dtt)";
                SqlCommand myCommand = new SqlCommand(sql, MyConnection1);
                myCommand.Parameters.AddWithValue("@id1",balfrom.Text);
                myCommand.Parameters.AddWithValue("@id2", to.Text);
                myCommand.Parameters.AddWithValue("@sender", label4.Text);
                myCommand.Parameters.AddWithValue("@rcvr", label5.Text);
                myCommand.Parameters.AddWithValue("@amt", money.Text);
                myCommand.Parameters.AddWithValue("@dtt", Date.Text);
                // ... other parameters
                myCommand.ExecuteNonQuery();
                MessageBox.Show("inserted");
                MyConnection1.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            Date.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString();
        }

        private void money_TextChanged(object sender, EventArgs e)
        {
            send.Enabled = true;
        }

        private void to_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)// 8 means we can only use backspace key and !char to enter digits only other than that will not be
            //entertained
            {
                e.Handled = true;
            }
        }

        private void money_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)// 8 means we can only use backspace key and !char to enter digits only other than that will not be
            //entertained
            {
                e.Handled = true;
            }
        }
    }
}
