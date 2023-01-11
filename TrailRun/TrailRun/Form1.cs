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
    }
}