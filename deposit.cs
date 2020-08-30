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

namespace WindowsFormsApplication1
{
    public partial class Form8 : Form
    {
        SqlConnection MyConnection = new SqlConnection(@"Data Source=DESKTOP-HCSTTAF;Initial Catalog=bank;Persist Security Info=True;User ID=sa;Password=azaanpc");
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //deposit.Enabled = true;
            try
            {
                MyConnection.Open();
                SqlCommand command1 = new SqlCommand("Select fname,balance from bannnk where id = @id", MyConnection);
                command1.Parameters.AddWithValue("@id", idnum.Text);
                
                SqlDataReader rdr = command1.ExecuteReader();
                rdr.Read();
                nme.Text = rdr["fname"].ToString();
                balnce.Text = rdr["balance"].ToString();
                
                MyConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void clear()
        {
            nme.Text = "";
            idnum.Text = "";
            balnce.Text = "";
            amnt.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double blnc = double.Parse(balnce.Text);
                double amts = double.Parse(amnt.Text);
                double total = (blnc + amts);
                double tax = (amts - 0.10);
                double ttotal = (blnc + tax);
                if (amts >= 50000)
                {
                    DialogResult d = MessageBox.Show("10 % TAX will be deduct from your amount", "MessageBox Title", MessageBoxButtons.OKCancel);
                    if (d == DialogResult.OK)
                    {
                        MyConnection.Open();
                        using (SqlCommand command3 = new SqlCommand("update bannnk set balance=@amount where id=@id2", MyConnection))
                        {
                            command3.Parameters.AddWithValue("@id2", idnum.Text);
                            command3.Parameters.AddWithValue("@amount", ttotal);
                            command3.ExecuteNonQuery();
                            MessageBox.Show("Successfully Transferred");
                        }
                        MyConnection.Close();
                    }
                    else
                    {
                        this.Close();
                    }

                }
                else
                {
                    MyConnection.Open();
                    using (SqlCommand command3 = new SqlCommand("update bannnk set balance=@amount where id=@id2", MyConnection))
                    {
                        command3.Parameters.AddWithValue("@id2", idnum.Text);
                        command3.Parameters.AddWithValue("@amount", total);
                        command3.ExecuteNonQuery();
                        MessageBox.Show("Successfully Transferred");
                    }
                    clear();
                    MyConnection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void amnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void idnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            check.Enabled = true;
        }

        private void amnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            deposit.Enabled = true;
        }
    }
}
