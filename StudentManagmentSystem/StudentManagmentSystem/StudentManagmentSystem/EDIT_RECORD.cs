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
    public partial class EDIT_RECORD : Form
    {
        public EDIT_RECORD()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
              
                panel1.Enabled = true;
                panel1.Show();
                txtid.ReadOnly = true;
                txtname.ReadOnly = false;
                txtemail.ReadOnly = false;
                cmbpro.Enabled = true;
                richaddress.ReadOnly = false;
                txtphone.ReadOnly = false;

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
                        txtphone.Text = Convert.ToString (dt.Rows[0][4]);
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
            catch (Exception )
            {
                MessageBox.Show("STUDENT ID NOT FOUND");
            }
        }
        //A
        private void btnEdit_Click(object sender, EventArgs e)
        {
             try
            {

               string database = AppDomain.CurrentDomain.BaseDirectory + "\\Database\\SMS.sqlite";
                string connectionString = @"Data Source=" + Path.GetFullPath(database);
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                string a = ("update record set name = '" + txtname.Text + "', program= '" + cmbpro.Text + "', email='" + txtemail.Text + "', phoneno='" + txtphone.Text +"', address ='" + richaddress.Text + "' Where id=" + txtid.Text);
                SQLiteCommand selectCommand = new SQLiteCommand(a, connection);
              //  DataTable dt = new DataTable();
                try
                {
                    connection.Open();
                    selectCommand.ExecuteNonQuery();
                    MessageBox.Show("Record has been sucessfully updated");
                    btnReset.PerformClick();

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            txtid.Clear();
            txtname.Clear();
            txtemail.Clear();
            txtphone.Clear();
            cmbpro.SelectedIndex = 0;
            richaddress.Clear();
            panel1.Enabled = false;
            txtid.ReadOnly = false;
            panel1.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EDIT_RECORD_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}
