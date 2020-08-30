namespace WindowsFormsApplication1
{
    partial class crud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bannnkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.Button();
            this.viewall = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bal = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.imgbox = new System.Windows.Forms.PictureBox();
            this.occ = new System.Windows.Forms.TextBox();
            this.cnic = new System.Windows.Forms.TextBox();
            this.cr = new System.Windows.Forms.TextBox();
            this.nat = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.con = new System.Windows.Forms.TextBox();
            this.maritstat = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datex = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannnkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bannnkBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 412);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1045, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // bannnkBindingSource
            // 
            this.bannnkBindingSource.DataMember = "bannnk";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(198, 20);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 1;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.Transparent;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.view.Location = new System.Drawing.Point(585, 320);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(89, 25);
            this.view.TabIndex = 2;
            this.view.Text = "VIEW";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewall
            // 
            this.viewall.BackColor = System.Drawing.Color.Transparent;
            this.viewall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewall.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewall.Location = new System.Drawing.Point(788, 320);
            this.viewall.Name = "viewall";
            this.viewall.Size = new System.Drawing.Size(104, 72);
            this.viewall.TabIndex = 3;
            this.viewall.Text = "VIEW ALL";
            this.viewall.UseVisualStyleBackColor = false;
            this.viewall.Click += new System.EventHandler(this.button2_Click);
            // 
            // browse
            // 
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.browse.Location = new System.Drawing.Point(760, 274);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(88, 23);
            this.browse.TabIndex = 67;
            this.browse.Text = "BROWSE";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(148, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 24);
            this.label14.TabIndex = 66;
            this.label14.Text = "/= RS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(337, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "OCCUPATION";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "DATE OF EXPIRY";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(384, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "CNIC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "COUNTRY OF RESIDENCE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "NATIONALITY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "CITY OF BIRTH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "COUNTRY OF BIRTH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "MARITAL STATUS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "GENDER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "ADDRESS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "LAST NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "MIDDLE NAME";
            // 
            // bal
            // 
            this.bal.Enabled = false;
            this.bal.Location = new System.Drawing.Point(18, 46);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(125, 29);
            this.bal.TabIndex = 53;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(680, 320);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(91, 23);
            this.update.TabIndex = 52;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.upd_Click);
            // 
            // imgbox
            // 
            this.imgbox.Enabled = false;
            this.imgbox.Location = new System.Drawing.Point(580, 23);
            this.imgbox.Name = "imgbox";
            this.imgbox.Size = new System.Drawing.Size(433, 236);
            this.imgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbox.TabIndex = 51;
            this.imgbox.TabStop = false;
            // 
            // occ
            // 
            this.occ.Location = new System.Drawing.Point(437, 239);
            this.occ.Name = "occ";
            this.occ.Size = new System.Drawing.Size(100, 20);
            this.occ.TabIndex = 50;
            // 
            // cnic
            // 
            this.cnic.Location = new System.Drawing.Point(439, 154);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(100, 20);
            this.cnic.TabIndex = 49;
            // 
            // cr
            // 
            this.cr.Location = new System.Drawing.Point(439, 115);
            this.cr.Name = "cr";
            this.cr.Size = new System.Drawing.Size(100, 20);
            this.cr.TabIndex = 48;
            // 
            // nat
            // 
            this.nat.Location = new System.Drawing.Point(439, 75);
            this.nat.Name = "nat";
            this.nat.Size = new System.Drawing.Size(100, 20);
            this.nat.TabIndex = 47;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(130, 386);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 46;
            // 
            // con
            // 
            this.con.Location = new System.Drawing.Point(130, 350);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(100, 20);
            this.con.TabIndex = 45;
            // 
            // maritstat
            // 
            this.maritstat.Location = new System.Drawing.Point(130, 274);
            this.maritstat.Name = "maritstat";
            this.maritstat.Size = new System.Drawing.Size(100, 20);
            this.maritstat.TabIndex = 44;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(130, 239);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(100, 20);
            this.gender.TabIndex = 43;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(130, 197);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 20);
            this.address.TabIndex = 42;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(132, 150);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(100, 20);
            this.lname.TabIndex = 41;
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(132, 112);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(100, 20);
            this.mname.TabIndex = 40;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(132, 75);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(100, 20);
            this.fname.TabIndex = 39;
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Location = new System.Drawing.Point(84, 78);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(38, 13);
            this.NAME.TabIndex = 38;
            this.NAME.Text = "NAME";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(130, 312);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(100, 20);
            this.dob.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "DATE OF BIRTH";
            // 
            // datex
            // 
            this.datex.Location = new System.Drawing.Point(437, 198);
            this.datex.Name = "datex";
            this.datex.Size = new System.Drawing.Size(100, 20);
            this.datex.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bal);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(341, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 104);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BALANCE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(47, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 22);
            this.label15.TabIndex = 76;
            this.label15.Text = "SEARCH BY ID";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.delete.Location = new System.Drawing.Point(585, 351);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(186, 43);
            this.delete.TabIndex = 77;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(WindowsFormsApplication1.customer);
            // 
            // crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1083, 685);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.imgbox);
            this.Controls.Add(this.occ);
            this.Controls.Add(this.cnic);
            this.Controls.Add(this.cr);
            this.Controls.Add(this.nat);
            this.Controls.Add(this.city);
            this.Controls.Add(this.con);
            this.Controls.Add(this.maritstat);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.mname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.viewall);
            this.Controls.Add(this.view);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "crud";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannnkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.BindingSource bannnkBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marriagestatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resconDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nice1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nic1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.Button viewall;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bal;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.PictureBox imgbox;
        private System.Windows.Forms.TextBox occ;
        private System.Windows.Forms.TextBox cnic;
        private System.Windows.Forms.TextBox cr;
        private System.Windows.Forms.TextBox nat;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox con;
        private System.Windows.Forms.TextBox maritstat;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.TextBox dob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox datex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button delete;
    }
}