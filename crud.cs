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
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    public partial class crud : Form
    {
        SqlConnection MyConnection = new SqlConnection(@"Data Source=DESKTOP-HCSTTAF;Initial Catalog=bank;Persist Security Info=True;User ID=sa;Password=azaanpc");
        SqlCommand MyCommand;
        SqlDataReader MyDataReader;
        string imgloc = "";
        public crud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MyConnection.Open();
              
                //string query = "SELECT * FROM bannnk WHERE id = " + textBox1.Text;

                SqlCommand cmd = new SqlCommand("Select * from bannnk where id = @id", MyConnection);
                cmd.Parameters.AddWithValue("id", id.Text);
                SqlDataReader rdr = cmd.ExecuteReader();
                //SqlDataAdapter sda = new SqlDataAdapter(cmd, MyConnection);
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
                //MyConnection.Dispose();
                MyConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet.bannnk' table. You can move, or remove it, as needed.
           // this.bannnkTableAdapter.Fill(this.bankDataSet.bannnk);

        }

       // DbEntities db;

        private void button2_Click(object sender, EventArgs e)
        {
            /*try
            {
                MyConnection.Open();
                string query = "SELECT * FROM bannnk";
                SqlDataAdapter sda = new SqlDataAdapter(query, MyConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
                MyConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/

            try
            {
                MyConnection.Open();

                //string query = "SELECT * FROM bannnk WHERE id = " + textBox1.Text;

                SqlCommand cmd = new SqlCommand("Select * from bannnk", MyConnection);
                //cmd.Parameters.AddWithValue("id", id.Text);
                SqlDataReader rdr = cmd.ExecuteReader();
                //SqlDataAdapter sda = new SqlDataAdapter(cmd, MyConnection);
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
                //MyConnection.Dispose();
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void clear()
        {
            id.Text = "";
            fname.Text = "";
            mname.Text = "";
            lname.Text = "";
            address.Text = "";
            gender.Text = "";
            maritstat.Text = "";
            dob.Text = "";
            con.Text = "";
            city.Text = "";
            nat.Text = "";
            cr.Text = "";
            cnic.Text = "";
            datex.Text = "";
            occ.Text = "";
            bal.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                fname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                mname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                lname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                address.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                gender.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                maritstat.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                dob.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                con.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                city.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                nat.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                cr.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                datex.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                occ.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                cnic.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
                bal.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
                Byte[] data = new Byte[0];  
                data = (Byte[])(dataGridView1.SelectedRows[0].Cells[16].Value);  
                MemoryStream mem = new MemoryStream(data);  
                imgbox.Image= Image.FromStream(mem); 


               // imgbox.Image = (Image)dataGridView1.Rows[0].Cells[16].Value;
               // byte[] img = dataGridView1.SelectedRows[0].Cells[16].Value;
                //MemoryStream ms = new MemoryStream();
                //Bitmap img = (Bitmap)dataGridView1.SelectedRows[0].Cells[16].Value;
                //img.Save(ms, ImageFormat.Jpeg);
                //imgbox.Image = Image.FromStream(ms);
                // imgbox.Image = Image.FromFile(SelectedRows.Cells["afbeelding"].Value.ToString());

                // imgbox.Image = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();



               /*SqlCommand cmd = new SqlCommand("Select * from bannnk where id = @id", MyConnection);
                cmd.Parameters.AddWithValue("id", id.Text);
                SqlDataReader rdr = cmd.ExecuteReader();*/
            }
            catch
            {

            }
            //SqlDataAdapter sda = new SqlDataAdapter(cmd, MyConnection);
            
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void upd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("update bannnk set fname=@fname,mname=@mname,lname=@lname,address=@address,gender=@gender,marriagestat=@marriagestat,dobd=@dobd,country=@country,city=@city,nationality=@nationality,rescon=@rescon,nice1=@nice1,occupation=@occupation,nic1=@nic1,balance=@balance where id=@id", MyConnection);
                MyConnection.Open();
                cmd1.Parameters.AddWithValue("@id", Int32.Parse(id.Text));
                cmd1.Parameters.AddWithValue("@fname", fname.Text);
                cmd1.Parameters.AddWithValue("@mname", mname.Text);
                cmd1.Parameters.AddWithValue("@lname", lname.Text);
                cmd1.Parameters.AddWithValue("@address", address.Text);
                cmd1.Parameters.AddWithValue("@gender", gender.Text);
                cmd1.Parameters.AddWithValue("@marriagestat", maritstat.Text);
                cmd1.Parameters.AddWithValue("@dobd", dob.Text);
                cmd1.Parameters.AddWithValue("@country", con.Text);
                cmd1.Parameters.AddWithValue("@city", city.Text);
                cmd1.Parameters.AddWithValue("@nationality", nat.Text);
                cmd1.Parameters.AddWithValue("@rescon", cr.Text);
                cmd1.Parameters.AddWithValue("@nice1", datex.Text);
                cmd1.Parameters.AddWithValue("@occupation", occ.Text);
                cmd1.Parameters.AddWithValue("@nic1", cnic.Text);
                cmd1.Parameters.AddWithValue("@balance", bal.Text);
              //cmd1.Parameters.AddWithValue("@img", imgbox.Image);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("updated");
                clear();
               // upd_Click(sender, e);
                MyConnection.Close();

                //clear();
            

            /*finally
            {
                MyConnection.Close();
            }*/
        }

       

        private void delete_Click(object sender, EventArgs e)
        {
        
             // SqlConnection mycon = new SqlConnection(MyConnection);
            SqlCommand cmd1 = new SqlCommand("delete bannnk where id=@id", MyConnection);

            try
            {
                MyConnection.Open();
                cmd1.Parameters.AddWithValue("@id", Int16.Parse(id.Text));
                cmd1.ExecuteNonQuery();
                MessageBox.Show("deleted");
                clear();
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MyConnection.Close();
            }
        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    imgbox.ImageLocation = imgloc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            
    }
}
