namespace WindowsFormsApplication1
{
    partial class balanceshet
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.senderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieveridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet3 = new WindowsFormsApplication1.bankDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionTableAdapter1 = new WindowsFormsApplication1.bankDataSet3TableAdapters.transactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.Transparent;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.check.Location = new System.Drawing.Point(384, 54);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 30);
            this.check.TabIndex = 1;
            this.check.Text = "check";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.senderidDataGridViewTextBoxColumn,
            this.recieveridDataGridViewTextBoxColumn,
            this.senderBalanceDataGridViewTextBoxColumn,
            this.recieverBalanceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 189);
            this.dataGridView1.TabIndex = 2;
            // 
            // senderidDataGridViewTextBoxColumn
            // 
            this.senderidDataGridViewTextBoxColumn.DataPropertyName = "sender_id";
            this.senderidDataGridViewTextBoxColumn.HeaderText = "sender_id";
            this.senderidDataGridViewTextBoxColumn.Name = "senderidDataGridViewTextBoxColumn";
            // 
            // recieveridDataGridViewTextBoxColumn
            // 
            this.recieveridDataGridViewTextBoxColumn.DataPropertyName = "reciever_id";
            this.recieveridDataGridViewTextBoxColumn.HeaderText = "reciever_id";
            this.recieveridDataGridViewTextBoxColumn.Name = "recieveridDataGridViewTextBoxColumn";
            // 
            // senderBalanceDataGridViewTextBoxColumn
            // 
            this.senderBalanceDataGridViewTextBoxColumn.DataPropertyName = "Sender_Balance";
            this.senderBalanceDataGridViewTextBoxColumn.HeaderText = "Sender_Balance";
            this.senderBalanceDataGridViewTextBoxColumn.Name = "senderBalanceDataGridViewTextBoxColumn";
            // 
            // recieverBalanceDataGridViewTextBoxColumn
            // 
            this.recieverBalanceDataGridViewTextBoxColumn.DataPropertyName = "Reciever_Balance";
            this.recieverBalanceDataGridViewTextBoxColumn.HeaderText = "Reciever_Balance";
            this.recieverBalanceDataGridViewTextBoxColumn.Name = "recieverBalanceDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // transactionBindingSource1
            // 
            this.transactionBindingSource1.DataMember = "transaction";
            this.transactionBindingSource1.DataSource = this.bankDataSet3;
            // 
            // bankDataSet3
            // 
            this.bankDataSet3.DataSetName = "bankDataSet3";
            this.bankDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ENTER ID";
            // 
            // transactionTableAdapter1
            // 
            this.transactionTableAdapter1.ClearBeforeFill = true;
            // 
            // balanceshet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(553, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "balanceshet";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private bankDataSet3 bankDataSet3;
        private System.Windows.Forms.BindingSource transactionBindingSource1;
        private bankDataSet3TableAdapters.transactionTableAdapter transactionTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieveridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
    }
}