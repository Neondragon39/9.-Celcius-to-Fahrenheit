namespace _9._Celcius_to_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(AsteetTB.Text);
            if (CelciusRB.Checked)
            {
                vastaus = (asteet * 1.8) + 32;
                VastausLB.Text = asteet + "Fahrenheitia on " + vastaus + "Celsius astetta";
                VastausLB.Visible = true;
            }
            else if (FahrenheitRB.Checked)
            {
                vastaus = (asteet - 32) / 1.8;
                VastausLB.Text = asteet + "Celsiusta on " + vastaus + "Fahrenheit astetta";
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Et valinnut muunnettavaa astetta tai antanut oikeaa lukua";
                VastausLB.Visible = true;
            }
        }
    }
}