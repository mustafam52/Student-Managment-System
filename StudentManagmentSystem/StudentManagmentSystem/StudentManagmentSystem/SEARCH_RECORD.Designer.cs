namespace StudentManagmentSystem
{
    partial class SEARCH_RECORD
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbpro = new System.Windows.Forms.ComboBox();
            this.richaddress = new System.Windows.Forms.RichTextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Location = new System.Drawing.Point(36, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 263);
            this.panel2.TabIndex = 30;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(264, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.cmbpro);
            this.panel3.Controls.Add(this.richaddress);
            this.panel3.Controls.Add(this.txtphone);
            this.panel3.Controls.Add(this.txtemail);
            this.panel3.Controls.Add(this.txtname);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 228);
            this.panel3.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(100, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "PROGRAM:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "ADDRESS:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "PHONE_NUMBER:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "E_MAIL:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "STUDENT_NAME:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(100, 6);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(141, 20);
            this.txtid.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "STUDENT_ID:";
            // 
            // SEARCH_RECORD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentManagmentSystem.Properties.Resources._500_F_86719115_eTbbkKCFea6xPa9iFYap5C7AHQfkmL2H;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 412);
            this.Controls.Add(this.panel2);
            this.Name = "SEARCH_RECORD";
            this.Text = "SEARCH_RECORD";
            this.Load += new System.EventHandler(this.SEARCH_RECORD_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbpro;
        private System.Windows.Forms.RichTextBox richaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCancel;

    }
}