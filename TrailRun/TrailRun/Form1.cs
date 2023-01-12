using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace TrailRun
{
    public partial class Form1 : Form
    {

        int ClickCounter = 0;

        public Form1()
        {
            InitializeComponent();

            BindGrid();

            string ClicksCountedText = "Times clicked: " + ClickCounter;

            lblTimesClicked.Text = ClicksCountedText;
        }

        public string conString = "Data Source=(localdb)\\Local;Initial Catalog=TestDatabasePratice;Integrated Security=True";

        public void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM People", con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void btnAccept1_Click(object sender, EventArgs e)
        {
            string pressedAcceptButtonText = "You pressed the accept button";

            string pressedAcceptButtonCaption = "Click";

            ClickCounter++;

            string ClicksCountedText = "Times clicked: " + ClickCounter;

            lblTimesClicked.Text = ClicksCountedText;

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string qq = "SELECT * FROM People";
                SqlCommand cmd = new SqlCommand(qq, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection made successfully, All pulled");


            }



            MessageBox.Show(pressedAcceptButtonText, pressedAcceptButtonCaption, MessageBoxButtons.OK);
        }

        public void btnSearchDatabase_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into People(Name,Age)values('" + txtName.Text.ToString() + "','" + txtAge.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection made successfully");
            }

        }

        public void displayData()
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select * From People";

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        public void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into People values('"+txtDbName.Text.ToString()+"','"+txtDbAge.Text+"','"+txtDbJob.Text.ToString()+"') ";

                cmd.ExecuteNonQuery();

                displayData();

                MessageBox.Show("insert made successfully");
            }
            con.Close();
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From People where Name='"+ txtDbName.Text.ToString() + "'";

                cmd.ExecuteNonQuery();

                displayData();

                MessageBox.Show("Delete made successfully");
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update People set Name= '" + txtAltName.Text.ToString() + "' where Name= '" +txtDbName.Text.ToString()+ "'";

                cmd.ExecuteNonQuery();

                displayData();

                MessageBox.Show("Update made successfully");
            }
            con.Close();
        }
    }
    
}