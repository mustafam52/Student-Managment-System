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
    public partial class HOME : Form
    {
        int count = 0;
        public HOME()
        {
            InitializeComponent();
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
          //  String images = AppDomain.CurrentDomain.BaseDirectory +"image\\5.jpg";
            pictureBox1.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "image\\5.jpg");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count > 5)
            {
                count = 0;
            }
            else
            {
                
                pictureBox1.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "image\\" + count + ".jpg");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
