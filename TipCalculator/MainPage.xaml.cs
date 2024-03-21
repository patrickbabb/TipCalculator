namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        decimal subtotal;
        decimal tip;
        decimal totalWithTip;
        int partySize = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void etnEnterBillAmount_Completed(object sender, EventArgs e)
        {
            subtotal = decimal.Parse(etnEnterBillAmount.Text);

            lblSubtotal.Text = "$" + etnEnterBillAmount.Text;

            lblGrandTotal.Text = "TEST";
        }

        private void Button_Clicked15(object sender, EventArgs e)
        {
            Calculate(15);
        }

        private void Button_Clicked20(object sender, EventArgs e)
        {
            Calculate(20);
        }

        private void Button_Clicked25(object sender, EventArgs e)
        {
            Calculate(25);
        }

        private void Calculate(int tipPercent)
        {
            tip = (decimal.Parse(etnEnterBillAmount.Text) / 100) * tipPercent;
            totalWithTip = subtotal + tip;
            totalWithTip = Math.Round(totalWithTip, 2);

            lblSubtotal.Text = "$" + totalWithTip.ToString();
            lblTip.Text = tip.ToString();
        }

        private void sldTipPercent_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var sliderTip = sldTipPercent.Value;
            lblTipSlider.Text = Math.Round(sliderTip).ToString() + "%";

            Calculate((int)sliderTip);
        }

        private void btnRemovePerson_Clicked(object sender, EventArgs e)
        {
            if (partySize <= 0)
            {
                partySize = 0;
            }
            else
            {
                partySize--;
            }
            
            lblPartySize.Text = partySize.ToString();
        }

        private void btnAddPerson_Clicked(object sender, EventArgs e)
        {
            partySize++;

            lblPartySize.Text = partySize.ToString();
        }
    }
}
