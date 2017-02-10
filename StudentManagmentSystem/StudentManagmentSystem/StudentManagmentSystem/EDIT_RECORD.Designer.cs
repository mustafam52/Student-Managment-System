namespace StudentManagmentSystem
{
    partial class EDIT_RECORD
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
            this.EDIT_PANEL = new System.Windows.Forms.Panel();
            this.btnid = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbpro = new System.Windows.Forms.ComboBox();
            this.richaddress = new System.Windows.Forms.RichTextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.EDIT_PANEL.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EDIT_PANEL
            // 
            this.EDIT_PANEL.BackColor = System.Drawing.Color.Transparent;
            this.EDIT_PANEL.Controls.Add(this.btnid);
            this.EDIT_PANEL.Controls.Add(this.panel1);
            this.EDIT_PANEL.Controls.Add(this.txtid);
            this.EDIT_PANEL.Controls.Add(this.label13);
            this.EDIT_PANEL.Location = new System.Drawing.Point(37, 29);
            this.EDIT_PANEL.Name = "EDIT_PANEL";
            this.EDIT_PANEL.Size = new System.Drawing.Size(346, 263);
            this.EDIT_PANEL.TabIndex = 5;
            // 
            // btnid
            // 
            this.btnid.Location = new System.Drawing.Point(264, 6);
            this.btnid.Name = "btnid";
            this.btnid.Size = new System.Drawing.Size(75, 23);
            this.btnid.TabIndex = 28;
            this.btnid.Text = "ID EDIT";
            this.btnid.UseVisualStyleBackColor = true;
            this.btnid.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.cmbpro);
            this.panel1.Controls.Add(this.richaddress);
            this.panel1.Controls.Add(this.txtphone);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 228);
            this.panel1.TabIndex = 15;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(208, 197);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 27;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(127, 197);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(46, 197);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.txtname.Location = new System.Drawing.Point(142, 8);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(141, 20);
            this.txtname.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "PROGRAM:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "ADDRESS:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "PHONE_NUMBER:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "E_MAIL:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "STUDENT_NAME:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(100, 6);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(141, 20);
            this.txtid.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "STUDENT_ID:";
            // 
            // EDIT_RECORD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentManagmentSystem.Properties.Resources._500_F_86719115_eTbbkKCFea6xPa9iFYap5C7AHQfkmL2H;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 412);
            this.Controls.Add(this.EDIT_PANEL);
            this.Name = "EDIT_RECORD";
            this.Text = "EDIT_RECORD";
            this.Load += new System.EventHandler(this.EDIT_RECORD_Load);
            this.EDIT_PANEL.ResumeLayout(false);
            this.EDIT_PANEL.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EDIT_PANEL;
        private System.Windows.Forms.Button btnid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cmbpro;
        private System.Windows.Forms.RichTextBox richaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label13;
    }
}