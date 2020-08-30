namespace WindowsFormsApplication1
{
    partial class menuu
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
            this.bankmenu = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchUpdateAndDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankimage = new System.Windows.Forms.PictureBox();
            this.bankmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankimage)).BeginInit();
            this.SuspendLayout();
            // 
            // bankmenu
            // 
            this.bankmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.balanceSheetToolStripMenuItem});
            this.bankmenu.Location = new System.Drawing.Point(0, 0);
            this.bankmenu.Name = "bankmenu";
            this.bankmenu.Size = new System.Drawing.Size(554, 24);
            this.bankmenu.TabIndex = 0;
            this.bankmenu.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.searchUpdateAndDeleteToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.newAccountToolStripMenuItem.Text = "&New Account";
            this.newAccountToolStripMenuItem.Click += new System.EventHandler(this.newAccountToolStripMenuItem_Click);
            // 
            // searchUpdateAndDeleteToolStripMenuItem
            // 
            this.searchUpdateAndDeleteToolStripMenuItem.Name = "searchUpdateAndDeleteToolStripMenuItem";
            this.searchUpdateAndDeleteToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.searchUpdateAndDeleteToolStripMenuItem.Text = "&Search,Update and Delete";
            this.searchUpdateAndDeleteToolStripMenuItem.Click += new System.EventHandler(this.searchUpdateAndDeleteToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferMoneyToolStripMenuItem,
            this.depositMoneyToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // transferMoneyToolStripMenuItem
            // 
            this.transferMoneyToolStripMenuItem.Name = "transferMoneyToolStripMenuItem";
            this.transferMoneyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.transferMoneyToolStripMenuItem.Text = "&Transfer Money";
            this.transferMoneyToolStripMenuItem.Click += new System.EventHandler(this.transferMoneyToolStripMenuItem_Click);
            // 
            // depositMoneyToolStripMenuItem
            // 
            this.depositMoneyToolStripMenuItem.Name = "depositMoneyToolStripMenuItem";
            this.depositMoneyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.depositMoneyToolStripMenuItem.Text = "&Deposit Money";
            this.depositMoneyToolStripMenuItem.Click += new System.EventHandler(this.depositMoneyToolStripMenuItem_Click);
            // 
            // balanceSheetToolStripMenuItem
            // 
            this.balanceSheetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem});
            this.balanceSheetToolStripMenuItem.Name = "balanceSheetToolStripMenuItem";
            this.balanceSheetToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.balanceSheetToolStripMenuItem.Text = "Balance Sheet";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // bankimage
            // 
            this.bankimage.Image = global::WindowsFormsApplication1.Properties.Resources.Business_bank_account_e1534519443766;
            this.bankimage.Location = new System.Drawing.Point(0, 27);
            this.bankimage.Name = "bankimage";
            this.bankimage.Size = new System.Drawing.Size(554, 257);
            this.bankimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bankimage.TabIndex = 1;
            this.bankimage.TabStop = false;
            this.bankimage.Click += new System.EventHandler(this.bankimage_Click);
            // 
            // menuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 284);
            this.Controls.Add(this.bankimage);
            this.Controls.Add(this.bankmenu);
            this.MainMenuStrip = this.bankmenu;
            this.Name = "menuu";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.bankmenu.ResumeLayout(false);
            this.bankmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip bankmenu;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchUpdateAndDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferMoneyToolStripMenuItem;
        private System.Windows.Forms.PictureBox bankimage;
        private System.Windows.Forms.ToolStripMenuItem depositMoneyToolStripMenuItem;
    }
}