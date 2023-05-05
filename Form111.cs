using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dreader;
        string connstring = "Data Source=DESKTOP-RB1MO78\\SQLEXPRESS03;Initial Catalog=master;Integrated" ;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn01_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("Insert into Student_Detail Values(" + txt01.Text + ",'" + txt02.Text + "'," + listBox1.Text + ",'" + txt03.Text + "')", conn);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Saved...");
            }
            catch (Exception)
            {
                MessageBox.Show("Not Saved");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("Delete from Student_Detail where Roll Number = " + txt01.Text + " ", conn);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Deleted...");
                txt01.Clear();
                txt02.Clear();

                txt03.Clear();
                txt01.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show(" Not Deleted" + x.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
