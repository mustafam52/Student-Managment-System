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
    public partial class SEARCH_RECORD : Form
    {
        public SEARCH_RECORD()
        {
            InitializeComponent();
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            try
            {
                panel3.Show();
                panel3.Enabled = true;
                string database = AppDomain.CurrentDomain.BaseDirectory + "\\Database\\SMS.sqlite";
                string connectionString = @"Data Source=" + Path.GetFullPath(database);
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                string a = "SELECT * FROM record where id=" + txtid.Text;
                SQLiteCommand selectCommand = new SQLiteCommand(a, connection);
                DataTable dt = new DataTable();
                try
                {
                    connection.Open();
                    SQLiteDataReader reader = selectCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                        txtname.Text = Convert.ToString(dt.Rows[0][1]);
                        cmbpro.Text = Convert.ToString(dt.Rows[0][2]);
                        txtemail.Text = Convert.ToString(dt.Rows[0][3]);
                        txtphone.Text = Convert.ToString(dt.Rows[0][4]);
                        richaddress.Text = Convert.ToString(dt.Rows[0][5]);

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
            catch (Exception)
            {
                MessageBox.Show("STUDENT ID NOT FOUND ");
            }
        }

        private void SEARCH_RECORD_Load(object sender, EventArgs e)
        {
           btnCancel.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            txtid.Clear();
            txtname.Clear();
            cmbpro.SelectedIndex = 0;
            txtemail.Clear();
            txtphone.Clear();
            richaddress.Clear();
        }
    }
}
