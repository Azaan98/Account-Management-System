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
    public partial class balanceshet : Form
    {

        SqlConnection MyConnection = new SqlConnection(@"Data Source=DESKTOP-HCSTTAF;Initial Catalog=bank;Persist Security Info=True;User ID=sa;Password=azaanpc");
        //IDbConnection conn = new IDbConnection("Data Source=DESKTOP-HCSTTAF;Initial Catalog=bank;Integrated Security=True");
        //SqlCommand MyCommand;
        //SqlDataReader MyDataReader;
        public balanceshet()
        {
            InitializeComponent();
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

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet3.transaction' table. You can move, or remove it, as needed.
            //this.transactionTableAdapter1.Fill(this.bankDataSet3.transaction);
            // TODO: This line of code loads data into the 'bankDataSet2.transsaction' table. You can move, or remove it, as needed.
           // this.transsactionTableAdapter.Fill(this.bankDataSet2.transsaction);
            // TODO: This line of code loads data into the 'bankDataSet1.transaction' table. You can move, or remove it, as needed.
          //  this.transactionTableAdapter.Fill(this.bankDataSet1.transaction);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command1 = new SqlCommand("Select * from [transaction] where sender_id = @idd", MyConnection);
                    
                            command1.Parameters.AddWithValue("@idd", textBox1.Text);
                            MyConnection.Open();
                            SqlDataReader rdr = command1.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(rdr);
                            dataGridView1.AutoGenerateColumns = true;
                            dataGridView1.DataSource = dt;
                    MyConnection.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
