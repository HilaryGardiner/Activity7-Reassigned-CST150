namespace Activity7App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateNumberOfTermsButton_Click(object sender, EventArgs e)
        {
            int integer32BitValue;
            double piValue = 4, numeratorValue = 4, denominatorValue = 3;
            integer32BitValue = Convert.ToInt32(textBoxInput.Text);
            for (int i = 0; i <= integer32BitValue; i++)
            {
                if (i % 2 == 0)
                {
                    piValue -= numeratorValue / denominatorValue;
                }
                else
                {
                    piValue += numeratorValue / denominatorValue;
                }
                denominatorValue += 2;
            }
            PI_TextResponseLabel2.Text = "Approximate value of pi after " + integer32BitValue + " terms";
            PI_ResultValueLabel3.Text = "= " + piValue;
        }
    }
}