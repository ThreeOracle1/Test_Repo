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

namespace TrailRun
{
    public partial class Form1 : Form
    {

        int ClickCounter = 0;

        public Form1()
        {
            InitializeComponent();

            string ClicksCountedText = "Times clicked: " + ClickCounter;

            lblTimesClicked.Text = ClicksCountedText;
        }

        public string conString = "Data Source=(localdb)\\Local;Initial Catalog=TestDatabasePratice;Integrated Security=True";


        private void btnAccept1_Click(object sender, EventArgs e)
        {
            string pressedAcceptButtonText = "You pressed the accept button";

            string pressedAcceptButtonCaption = "Click";

            ClickCounter++;

            string ClicksCountedText = "Times clicked: " + ClickCounter;

            lblTimesClicked.Text = ClicksCountedText;

            MessageBox.Show(pressedAcceptButtonText, pressedAcceptButtonCaption, MessageBoxButtons.OK);
        }
        
        public void btnSearchDatabase_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State== System.Data.ConnectionState.Open)
            {
                string q = "insert into People(Name,Age)values('" +txtName.Text.ToString()+"','"+txtAge.Text.ToString()+"')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection made successfully");
            }

        }
    }
}