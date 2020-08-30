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

namespace WindowsFormsApplication1
{
    public partial class update : Form
    {
        SqlConnection MyConnection = new SqlConnection(@"Data Source=DESKTOP-HCSTTAF;Initial Catalog=bank;User ID=sa;Password=azaanpc");
        SqlCommand MyCommand;
        SqlDataReader MyDataReader;
        public update()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*try
            {
                MyConnection.Open();

                //string query = "SELECT * FROM bannnk WHERE id = " + textBox1.Text;

                SqlCommand cmd = new SqlCommand("Select * from bannnk where id = @id", MyConnection);
                cmd.Parameters.AddWithValue("id", id.Text);
                SqlDataReader rdr = cmd.ExecuteReader();
                //SqlDataAdapter sda = new SqlDataAdapter(cmd, MyConnection);
                if(rdr.Read())
                {
                    fname.Text = rdr.GetString("fname");
                }
                
                DataTable dt = new DataTable();
                dt.Load(rdr);
                // sda.Fill(dt);'
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
                MyConnection.Dispose();
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (idtext.Text != null)
            {
                SqlConnection mycon = new SqlConnection(strCon);
                SqlCommand cmd1 = new SqlCommand("update data1 set name=@name,designation=@state,semester=@sem,address=@add where id=@id", mycon);
                try
                {
                    mycon.Open();
                    cmd1.Parameters.AddWithValue("@id", Int16.Parse(idtext.Text));
                    cmd1.Parameters.AddWithValue("@name", Nametext.Text);
                    cmd1.Parameters.AddWithValue("@state", designtext.Text);
                    cmd1.Parameters.AddWithValue("@add", addrichtext.Text);
                    cmd1.Parameters.AddWithValue("@sem", semcombo.SelectedItem.ToString());
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("updated");
                    button5_Click(sender, e);
                    clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    mycon.Close();
                }
            }
            else
            {
                MessageBox.Show("invalid id or null");
            }
        }*/
        }
    }
}
