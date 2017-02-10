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
    public partial class DELETE_RECORD : Form
    {
        public DELETE_RECORD()
        {
            InitializeComponent();
        }

        private void btnDeleteID_Click(object sender, EventArgs e)
        {
            try
            {

                panel5.Show();
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
            catch
            {
                MessageBox.Show("STUDENT ID NOT FOUND");
            }

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                string database = AppDomain.CurrentDomain.BaseDirectory + "\\Database\\SMS.sqlite";
                string connectionString = @"Data Source=" + Path.GetFullPath(database);
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                string a = "DELETE FROM record where  id=" + txtid.Text;
                SQLiteCommand selectCommand = new SQLiteCommand(a, connection);
                connection.Open();
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                MessageBox.Show("RECORD HAS BEEN DELETED");
                txtid.Clear();
                panel5.Hide();
            }
            catch (Exception )
            {
                MessageBox.Show("INVALID DATA ENTRY");
            }
            
        }

        private void DELETE_RECORD_Load(object sender, EventArgs e)
        {
            panel5.Hide();
        }
    }
}
