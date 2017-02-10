namespace StudentManagmentSystem
{
    partial class DELETE_RECORD
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteID = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRecord = new System.Windows.Forms.Button();
            this.cmbpro = new System.Windows.Forms.ComboBox();
            this.richaddress = new System.Windows.Forms.RichTextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btnDeleteID);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.txtid);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Location = new System.Drawing.Point(37, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 270);
            this.panel4.TabIndex = 31;
            // 
            // btnDeleteID
            // 
            this.btnDeleteID.Location = new System.Drawing.Point(264, 6);
            this.btnDeleteID.Name = "btnDeleteID";
            this.btnDeleteID.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteID.TabIndex = 28;
            this.btnDeleteID.Text = "DELETE";
            this.btnDeleteID.UseVisualStyleBackColor = true;
            this.btnDeleteID.Click += new System.EventHandler(this.btnDeleteID_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRecord);
            this.panel5.Controls.Add(this.cmbpro);
            this.panel5.Controls.Add(this.richaddress);
            this.panel5.Controls.Add(this.txtphone);
            this.panel5.Controls.Add(this.txtemail);
            this.panel5.Controls.Add(this.txtname);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Location = new System.Drawing.Point(0, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(345, 228);
            this.panel5.TabIndex = 15;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(88, 197);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(139, 23);
            this.btnRecord.TabIndex = 27;
            this.btnRecord.Text = "RECORD DELETE";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // cmbpro
            // 
            this.cmbpro.FormattingEnabled = true;
            this.cmbpro.Items.AddRange(new object[] {
            "",
            "BS(CS)",
            "MS",
            "BBA"});
            this.cmbpro.Location = new System.Drawing.Point(142, 38);
            this.cmbpro.Name = "cmbpro";
            this.cmbpro.Size = new System.Drawing.Size(141, 21);
            this.cmbpro.TabIndex = 24;
            // 
            // richaddress
            // 
            this.richaddress.Location = new System.Drawing.Point(142, 116);
            this.richaddress.Name = "richaddress";
            this.richaddress.Size = new System.Drawing.Size(141, 75);
            this.richaddress.TabIndex = 23;
            this.richaddress.Text = "";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(142, 90);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(141, 20);
            this.txtphone.TabIndex = 22;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(142, 65);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(141, 20);
            this.txtemail.TabIndex = 21;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(142, 7);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(141, 20);
            this.txtname.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "PROGRAM:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "ADDRESS:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 93);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 13);
            this.label22.TabIndex = 17;
            this.label22.Text = "PHONE_NUMBER:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 65);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "E_MAIL:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(21, 10);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(99, 13);
            this.label24.TabIndex = 15;
            this.label24.Text = "STUDENT_NAME:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(100, 6);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(141, 20);
            this.txtid.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(15, 8);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "STUDENT_ID:";
            // 
            // DELETE_RECORD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentManagmentSystem.Properties.Resources._500_F_86719115_eTbbkKCFea6xPa9iFYap5C7AHQfkmL2H;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 412);
            this.Controls.Add(this.panel4);
            this.Name = "DELETE_RECORD";
            this.Text = "DELETE_RECORD";
            this.Load += new System.EventHandler(this.DELETE_RECORD_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteID;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.ComboBox cmbpro;
        private System.Windows.Forms.RichTextBox richaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label25;
    }
}