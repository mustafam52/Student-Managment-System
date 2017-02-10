using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagmentSystem
{
    public partial class Form1 : Form
    {
        public static int record_number=0;
        public Form1()
        {
            InitializeComponent();
        }
        HOME home = new HOME();
        ADD_RECORD ad = new ADD_RECORD();
        EDIT_RECORD ed = new EDIT_RECORD();
        SEARCH_RECORD sr = new SEARCH_RECORD();
        DELETE_RECORD dr = new DELETE_RECORD();
        login L = new login();

        private void label2_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();  
            ad.FormBorderStyle = FormBorderStyle.None;
            ad.TopLevel = false;
            ad.AutoScroll = true;
            this.main_panel.Controls.Add(ad);
            ad.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();  
            sr.FormBorderStyle = FormBorderStyle.None;
            sr.TopLevel = false;
            sr.AutoScroll = true;
            this.main_panel.Controls.Add(sr);
            sr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            main_panel.Controls.Clear();  
            home.FormBorderStyle = FormBorderStyle.None;
            home.TopLevel = false;
            home.AutoScroll = true;
            this.main_panel.Controls.Add(home);
            home.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();  
            home.FormBorderStyle = FormBorderStyle.None;
            home.TopLevel = false;
            home.AutoScroll = true;
            this.main_panel.Controls.Add(home);
            home.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();  
            ed.FormBorderStyle = FormBorderStyle.None;
            ed.TopLevel = false;
            ed.AutoScroll = true;
            this.main_panel.Controls.Add(ed);
            ed.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();  
            dr.FormBorderStyle = FormBorderStyle.None;
            dr.TopLevel = false;
            dr.AutoScroll = true;
            this.main_panel.Controls.Add(dr);
            dr.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkCyan;

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkCyan;
        }
        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DarkCyan;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
                    
            label5.ForeColor = Color.DarkCyan;
      
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.ForeColor = Color.DarkCyan;
        }

       /* private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.DarkCyan;
        }*/

        /*private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.White;
        }*/
        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.ForeColor = Color.White;
        }
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Hide();
            login sc = new login();
            sc.Show();
            
        }

        //logout
        private void label11_Click(object sender, EventArgs e)
        {
            Hide();
            login sc = new login();
            sc.Show();
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
