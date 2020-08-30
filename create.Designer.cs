namespace WindowsFormsApplication1
{
    partial class create
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
            this.label1 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.single = new System.Windows.Forms.RadioButton();
            this.married = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.city = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.other = new System.Windows.Forms.RadioButton();
            this.pakistani = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rescon = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.exp = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.nic1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.job = new System.Windows.Forms.RadioButton();
            this.business = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browser = new System.Windows.Forms.Button();
            this.createacc = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.bannnkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bannnkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIRST NAME";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(119, 19);
            this.fname.MaxLength = 30;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(100, 20);
            this.fname.TabIndex = 1;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            this.fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MIDDLE NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "LAST NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DATE OF BIRTH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "COUNTRY";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lname);
            this.groupBox1.Controls.Add(this.mname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NAME";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(72, 121);
            this.address.MaxLength = 50;
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(216, 41);
            this.address.TabIndex = 7;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "ADDRESS";
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(119, 88);
            this.lname.MaxLength = 30;
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(100, 20);
            this.lname.TabIndex = 5;
            this.lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lname_KeyPress);
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(119, 53);
            this.mname.MaxLength = 30;
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(100, 20);
            this.mname.TabIndex = 4;
            this.mname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mname_KeyPress);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(31, 26);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(54, 17);
            this.male.TabIndex = 10;
            this.male.TabStop = true;
            this.male.Text = "MALE";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(119, 27);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(67, 17);
            this.female.TabIndex = 11;
            this.female.TabStop = true;
            this.female.Text = "FEMALE";
            this.female.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.male);
            this.groupBox2.Controls.Add(this.female);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 58);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SEX";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.single);
            this.groupBox3.Controls.Add(this.married);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 64);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Marital Status";
            // 
            // single
            // 
            this.single.AutoSize = true;
            this.single.Location = new System.Drawing.Point(101, 30);
            this.single.Name = "single";
            this.single.Size = new System.Drawing.Size(64, 17);
            this.single.TabIndex = 13;
            this.single.TabStop = true;
            this.single.Text = "SINGLE";
            this.single.UseVisualStyleBackColor = true;
            // 
            // married
            // 
            this.married.AutoSize = true;
            this.married.Location = new System.Drawing.Point(10, 30);
            this.married.Name = "married";
            this.married.Size = new System.Drawing.Size(75, 17);
            this.married.TabIndex = 12;
            this.married.TabStop = true;
            this.married.Text = "MARRIED";
            this.married.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dob);
            this.groupBox4.Controls.Add(this.city);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.country);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(12, 322);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 79);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Birht Information";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(6, 50);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(180, 20);
            this.dob.TabIndex = 17;
            // 
            // city
            // 
            this.city.FormattingEnabled = true;
            this.city.Location = new System.Drawing.Point(260, 48);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(68, 21);
            this.city.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "CITY";
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "Pakistan",
            "India"});
            this.country.Location = new System.Drawing.Point(190, 49);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(68, 21);
            this.country.TabIndex = 17;
            this.country.SelectedIndexChanged += new System.EventHandler(this.country_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.other);
            this.groupBox5.Controls.Add(this.pakistani);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(336, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 71);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "NATIONALITY";
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Location = new System.Drawing.Point(135, 27);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(63, 17);
            this.other.TabIndex = 13;
            this.other.TabStop = true;
            this.other.Text = "OTHER";
            this.other.UseVisualStyleBackColor = true;
            // 
            // pakistani
            // 
            this.pakistani.AutoSize = true;
            this.pakistani.Location = new System.Drawing.Point(22, 27);
            this.pakistani.Name = "pakistani";
            this.pakistani.Size = new System.Drawing.Size(81, 17);
            this.pakistani.TabIndex = 12;
            this.pakistani.TabStop = true;
            this.pakistani.Text = "PAKISTANI";
            this.pakistani.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rescon);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Location = new System.Drawing.Point(336, 103);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(304, 77);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "COUNTRY OF RESIDENCE";
            // 
            // rescon
            // 
            this.rescon.FormattingEnabled = true;
            this.rescon.Items.AddRange(new object[] {
            "Pakistan"});
            this.rescon.Location = new System.Drawing.Point(20, 30);
            this.rescon.Name = "rescon";
            this.rescon.Size = new System.Drawing.Size(128, 21);
            this.rescon.TabIndex = 20;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.exp);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.nic1);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox7.Location = new System.Drawing.Point(334, 186);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(304, 140);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CNIC INFO";
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(29, 96);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(269, 22);
            this.exp.TabIndex = 20;
            this.exp.ValueChanged += new System.EventHandler(this.exp_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "DATE OF EXPIRY";
            // 
            // nic1
            // 
            this.nic1.Location = new System.Drawing.Point(63, 27);
            this.nic1.MaxLength = 13;
            this.nic1.Name = "nic1";
            this.nic1.Size = new System.Drawing.Size(146, 22);
            this.nic1.TabIndex = 4;
            this.nic1.TextChanged += new System.EventHandler(this.nic1_TextChanged);
            this.nic1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nic1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "ID NO";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.job);
            this.groupBox8.Controls.Add(this.business);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox8.Location = new System.Drawing.Point(350, 341);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(304, 58);
            this.groupBox8.TabIndex = 17;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "OCCUPATION";
            // 
            // job
            // 
            this.job.AutoSize = true;
            this.job.Location = new System.Drawing.Point(126, 24);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(45, 17);
            this.job.TabIndex = 13;
            this.job.TabStop = true;
            this.job.Text = "JOB";
            this.job.UseVisualStyleBackColor = true;
            // 
            // business
            // 
            this.business.AutoSize = true;
            this.business.Location = new System.Drawing.Point(22, 24);
            this.business.Name = "business";
            this.business.Size = new System.Drawing.Size(79, 17);
            this.business.TabIndex = 12;
            this.business.TabStop = true;
            this.business.Text = "BUSINESS";
            this.business.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(661, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // browser
            // 
            this.browser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browser.Location = new System.Drawing.Point(730, 166);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(75, 23);
            this.browser.TabIndex = 19;
            this.browser.Text = "BROWSE";
            this.browser.UseVisualStyleBackColor = true;
            this.browser.Click += new System.EventHandler(this.button1_Click);
            // 
            // createacc
            // 
            this.createacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createacc.Location = new System.Drawing.Point(661, 367);
            this.createacc.Name = "createacc";
            this.createacc.Size = new System.Drawing.Size(133, 34);
            this.createacc.TabIndex = 20;
            this.createacc.Text = "CREATE";
            this.createacc.UseVisualStyleBackColor = true;
            this.createacc.Click += new System.EventHandler(this.button2_Click);
            // 
            // back
            // 
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(800, 367);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(98, 34);
            this.back.TabIndex = 22;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.balance);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox9.Location = new System.Drawing.Point(646, 195);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(237, 99);
            this.groupBox9.TabIndex = 23;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "BALANCE";
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(84, 52);
            this.balance.MaxLength = 10;
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(64, 20);
            this.balance.TabIndex = 24;
            this.balance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // bannnkBindingSource
            // 
            this.bannnkBindingSource.DataMember = "bannnk";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(646, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Balance should be or greater than 500";
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(908, 409);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.back);
            this.Controls.Add(this.createacc);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "create";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bannnkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton married;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton other;
        private System.Windows.Forms.RadioButton pakistani;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox rescon;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nic1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton job;
        private System.Windows.Forms.RadioButton business;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.RadioButton single;
        private System.Windows.Forms.Button browser;
        private System.Windows.Forms.Button createacc;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.DateTimePicker exp;
        //private bankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource bannnkBindingSource;
        private System.Windows.Forms.Label label7;
       // private bankDataSetTableAdapters.bannnkTableAdapter bannnkTableAdapter;
    }
}