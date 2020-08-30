namespace WindowsFormsApplication1
{
    partial class Form8
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
            this.idnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nme = new System.Windows.Forms.TextBox();
            this.balnce = new System.Windows.Forms.TextBox();
            this.amnt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idnum
            // 
            this.idnum.Location = new System.Drawing.Point(137, 48);
            this.idnum.MaxLength = 5;
            this.idnum.Name = "idnum";
            this.idnum.Size = new System.Drawing.Size(100, 20);
            this.idnum.TabIndex = 0;
            this.idnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idnum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTER YOUR ID";
            // 
            // check
            // 
            this.check.Enabled = false;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.check.Location = new System.Drawing.Point(284, 48);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(110, 32);
            this.check.TabIndex = 2;
            this.check.Text = "CHECK DETAILS";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ACCOUNT BALANCE";
            // 
            // nme
            // 
            this.nme.Location = new System.Drawing.Point(137, 93);
            this.nme.MaxLength = 30;
            this.nme.Name = "nme";
            this.nme.Size = new System.Drawing.Size(100, 20);
            this.nme.TabIndex = 6;
            // 
            // balnce
            // 
            this.balnce.Location = new System.Drawing.Point(137, 138);
            this.balnce.MaxLength = 10;
            this.balnce.Name = "balnce";
            this.balnce.Size = new System.Drawing.Size(100, 20);
            this.balnce.TabIndex = 7;
            // 
            // amnt
            // 
            this.amnt.Location = new System.Drawing.Point(41, 47);
            this.amnt.MaxLength = 10;
            this.amnt.Name = "amnt";
            this.amnt.Size = new System.Drawing.Size(112, 22);
            this.amnt.TabIndex = 8;
            this.amnt.TextChanged += new System.EventHandler(this.amnt_TextChanged);
            this.amnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amnt_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.amnt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(47, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 109);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AMOUNT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "/= RS";
            // 
            // deposit
            // 
            this.deposit.Enabled = false;
            this.deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deposit.Location = new System.Drawing.Point(302, 262);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(92, 36);
            this.deposit.TabIndex = 10;
            this.deposit.Text = "DEPOSIT";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(465, 340);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.balnce);
            this.Controls.Add(this.nme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idnum);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nme;
        private System.Windows.Forms.TextBox balnce;
        private System.Windows.Forms.TextBox amnt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deposit;
    }
}