using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
namespace StudentManagmentSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {

                DataTable dt = verifylogin(textBox1.Text, textBox2.Text);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(" You have Successfully Logged in ");
                    Form1 sc = new Form1();
                    sc.Show();
                    Hide();
                    
                }
                else
                {

                    MessageBox.Show(" Invaid User Name & Password ");
                }

            }
            else
            {

                MessageBox.Show("Please fill out all fields required");
            }
        }



        public DataTable verifylogin(string username, string passwrod)
        {
            string database = AppDomain.CurrentDomain.BaseDirectory + "\\Database\\SMS.sqlite";
            string connectionString = @"Data Source=" + Path.GetFullPath(database);
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            string a = "SELECT * FROM login where Username=" + "'" + textBox1.Text + "' and Password=" + "'" + textBox2.Text + "'";
            SQLiteCommand selectCommand = new SQLiteCommand(a, connection);
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
