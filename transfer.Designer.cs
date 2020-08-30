namespace WindowsFormsApplication1
{
    partial class transfer
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
            this.balfrom = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.to = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER YOUR ID NUMBER";
            // 
            // balfrom
            // 
            this.balfrom.Location = new System.Drawing.Point(15, 66);
            this.balfrom.MaxLength = 10;
            this.balfrom.Name = "balfrom";
            this.balfrom.Size = new System.Drawing.Size(100, 20);
            this.balfrom.TabIndex = 1;
            this.balfrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // send
            // 
            this.send.Enabled = false;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.send.Location = new System.Drawing.Point(189, 186);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(94, 50);
            this.send.TabIndex = 2;
            this.send.Text = "SEND";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.button1_Click);
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(15, 140);
            this.to.MaxLength = 10;
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(100, 20);
            this.to.TabIndex = 3;
            this.to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.to_KeyPress);
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(317, 99);
            this.money.MaxLength = 10;
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(100, 20);
            this.money.TabIndex = 4;
            this.money.TextChanged += new System.EventHandler(this.money_TextChanged);
            this.money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.money_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID WHERE YOU WANT TO SEND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "AMOUNT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(243, 23);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 13);
            this.Date.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(454, 279);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.money);
            this.Controls.Add(this.to);
            this.Controls.Add(this.send);
            this.Controls.Add(this.balfrom);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "transfer";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox balfrom;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
    }
}