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
    public partial class create : Form
    {
         double bal;
         SqlConnection MyConnection = new SqlConnection(@"Data Source=DESKTOP-HCSTTAF;Initial Catalog=bank;Persist Security Info=True;User ID=sa;Password=azaanpc");
         SqlCommand MyCommand;
         SqlDataReader MyDataReader;
        string imgloc = "";
        public create()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            

            if (fname.Text != null && mname.Text != null && lname.Text != null && address.Text !=null && (male.Checked || female.Checked)
                && (married.Checked || single.Checked) && dob.Value != null && rescon.Text !=null &&
                city.Text != null && (pakistani.Checked || other.Checked) && nic1 != null &&
                exp.Value != null && (business.Checked || job.Checked) && balance.Text != null && exp.Value < DateTime.Today)
            {
                customer c = new customer();
                c.Fname = fname.Text;
                c.Mname = mname.Text;
                c.Lname = lname.Text;
                c.Address = address.Text;
                if (male.Checked)
                {
                    c.Gender = male.Text;
                }
                else
                {
                    if (female.Checked)
                        c.Gender = female.Text;
                }
                if (married.Checked)
                {
                    c.Marriagestat = married.Text;
                }
                else
                {
                    if (single.Checked)
                        c.Marriagestat = single.Text;
                }
                c.Dob = dob.Text;
                c.Country = rescon.Text;
                c.City = city.Text;
                if (pakistani.Checked)
                {
                    c.Nationality = pakistani.Text;
                }
                else
                {
                    if (other.Checked)
                        c.Nationality = other.Text;
                }
                c.Rescon = rescon.Text;
                c.Nic = nic1.Text;
                c.Nice = exp.Text;
                bal = double.Parse(balance.Text);
                c.Balance = bal;
               
                if(bal < 500)
                {
                     MessageBox.Show("Amount Should Be Greater Or equal To 500/=");
                     business.Checked = false;
                     job.Checked = false;
                }
                if (bal >= 500)
                {
                    if (business.Checked)
                    {
                        c.Occupation = business.Text;
                    }
                    else
                    {
                        if (job.Checked)
                            c.Occupation = job.Text;
                    }
                    try
                    {
                        string sql = "";
                        MyConnection.Open();
                        byte[] img = null;
                        FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);
                        sql = "Insert into bannnk(fname,mname,lname,address,gender,marriagestat,dobd,country,city,nationality,rescon,nice1,occupation,nic1,balance,image) values('" + c.Fname + "','" + c.Mname + "','" + c.Lname + "','" + c.Address + "','" + c.Gender + "','" + c.Marriagestat + "','" + c.Dob + "','" + c.Country + "','" + c.City + "','" + c.Nationality + "','" + c.Rescon + "','" + c.Nice + "','" + c.Occupation + "','" + c.Nic + "','" + c.Balance + "',@img)";
                        if (MyConnection.State != ConnectionState.Open)
                            MyConnection.Open();
                        MyCommand = new SqlCommand(sql, MyConnection);
                        MyCommand.Parameters.Add(new SqlParameter("@img", img));
                        int x = MyCommand.ExecuteNonQuery();
                        MyConnection.Close();
                        MessageBox.Show(x.ToString() + " record saved. ");
                    }
                    catch(Exception ex)
                    {
                        MyConnection.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    business.Checked = false;
                    job.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Fill All The Details Or Your Nic might be expired");
            }
        }

        private void nic1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch!= 8)// 8 means we can only use backspace key and !char to enter digits only other than that will not be
                //entertained
            {
                e.Handled = true;
            }

        }

        private void nic2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)// 8 means we can only use backspace key and !char to enter digits only other than that will not be
            //entertained
            {
                e.Handled = true;
            }

        }

        private void nic3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)// 8 means we can only use backspace key and !char to enter digits only other than that will not be
            //entertained
            {
                e.Handled = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)// 8 means we can only use backspace key and !char to enter digits only other than that will not be
            //entertained
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Picture";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgloc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void nic1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void exp_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void country_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (country.Text == "Pakistan")
            {
                city.Text = "Select";
                city.Items.Clear();
                city.Items.Add("Karachi");
                city.Items.Add("Multan");
                city.Items.Add("Islamabad");
                city.Items.Add("Lahore");

            }
            else if (country.Text == "India")
            {
                city.Text = "Select";
                city.Items.Clear();
                city.Items.Add("Mumbai");
                city.Items.Add("Goa");
                city.Items.Add("Chennai");
                city.Items.Add("Delhi");
            }
            
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            //address.Text = string.Concat(address.Text.Where(char.IsLetterOrDigit));
        }

        private void mname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
