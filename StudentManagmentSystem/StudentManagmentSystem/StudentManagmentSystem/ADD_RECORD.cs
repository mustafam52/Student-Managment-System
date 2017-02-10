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
    public partial class ADD_RECORD : Form
    {
        public ADD_RECORD()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                //database...
                string database = AppDomain.CurrentDomain.BaseDirectory + "\\Database\\SMS.sqlite";
                string connectionString = @"Data Source=" + Path.GetFullPath(database);
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                string a = "insert into record (name,program,email,phoneno,address) values (" + "'" + txtname.Text + "','" + cmbprrogram.Text + "','" + txtemail.Text + "'," + "'" + txtphone.Text + "','"+ RichAddress.Text+"')";
                SQLiteCommand selectCommand = new SQLiteCommand(a, connection);
                DataTable dt = new DataTable();
                try
                {
                    connection.Open();
                    selectCommand.ExecuteNonQuery();
                    MessageBox.Show("Record has been sucessfully added");
                    button4.PerformClick();
                   

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
            catch (Exception)
            {
                MessageBox.Show("INVALID DATA ENTRY");
            }
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            txtname.Clear();
            txtemail.Clear();
            txtphone.Clear();
            RichAddress.Clear();
            cmbprrogram.SelectedIndex = 0;
            generteID();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void ADD_RECORD_Load(object sender, EventArgs e)
        {
            generteID();
            
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkCyan;
        }

        public void generteID()
        {
            string database = AppDomain.CurrentDomain.BaseDirectory + "\\Database\\SMS.sqlite";
            string connectionString = @"Data Source=" + Path.GetFullPath(database);
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            string a = "SELECT max(id) FROM record";
            SQLiteCommand selectCommand = new SQLiteCommand(a, connection);
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    textBox1.Text = Convert.ToString(dt.Rows[0][0]);

                }
                reader.Close();

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
    }
}
