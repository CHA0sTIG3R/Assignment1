namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const decimal With = 30M;
        private const decimal Without = 20M;
        private decimal count = 0M;
        private decimal containDailyWith = 0M;
        private decimal containDailyWithout = 0M;
        private decimal containDailyTotal = 0M;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal containWithout = decimal.Parse(snowWithout.Text) * Without;
            decimal containWith = decimal.Parse(snowWith.Text) * With;
            snowWithoutPrice.Text = "$"+ Math.Round(containWithout, 2);
            snowWithPrice.Text = "$" + Math.Round(containWith, 2);
            total.Text = "$"+ Math.Round(containWith + containWithout, 2);
            containDailyWith += containWith;
            containDailyWithout += containWithout;
            containDailyTotal = containDailyWith + containDailyWithout;
            count++;
            dailySnowWith.Text = "$" + Math.Round(containDailyWith, 2);
            dailySnowWithout.Text = "$" + Math.Round(containDailyWithout, 2);
            dailyTotal.Text = "$"+ Math.Round(containDailyTotal, 2);
            customerAve.Text = "$"+ Math.Round(containDailyTotal/count, 2);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            name.Text = "";
            id.Text = "";
            snowWith.Text = "";
            snowWithout.Text = "";
            snowWithoutPrice.Text = "";
            snowWithPrice.Text = "";
            total.Text = "";
            dailySnowWith.Text = "";
            dailySnowWithout.Text = "";
            dailyTotal.Text = "";
            customerAve.Text = "";
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            name.Text = "";
            id.Text = "";
            snowWith.Text = "";
            snowWithout.Text = "";
            snowWithoutPrice.Text = "";
            snowWithPrice.Text = "";
            total.Text = "";
            dailySnowWith.Text = "";
            dailySnowWithout.Text = "";
            dailyTotal.Text = "";
            customerAve.Text = "";
            containDailyWith = 0M;
            containDailyWithout = 0M;
            containDailyTotal = 0M;
            count = 0M;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}