namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        decimal subtotal;
        decimal tip = 0;
        decimal totalWithTip;
        int partySize = 1;
        int tipPercent = 0;
        double sliderTip;

        public MainPage()
        {
            InitializeComponent();
        }

        private void etnEnterBillAmount_Completed(object sender, EventArgs e)
        {
            subtotal = decimal.Parse(etnEnterBillAmount.Text);

            lblSubtotal.Text = "$" + etnEnterBillAmount.Text;

            Calculate();
        }

        private void sldTipPercent_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Calculate();
        }

        private void btnRemovePerson_Clicked(object sender, EventArgs e)
        {
            if (partySize <= 1)
            {
                partySize = 1;
            }
            else
            {
                partySize--;
            }

            lblPartySize.Text = partySize.ToString();

            Calculate();
        }

        private void btnAddPerson_Clicked(object sender, EventArgs e)
        {
            partySize++;

            lblPartySize.Text = partySize.ToString();

            Calculate();
        }

        private void Calculate()
        {
            tip = (decimal.Parse(etnEnterBillAmount.Text) / 100) * tipPercent;
            totalWithTip = subtotal + tip;
            totalWithTip = Math.Round(totalWithTip, 2) / partySize;
            totalWithTip = Math.Round(totalWithTip, 2);

            sliderTip = sldTipPercent.Value;
            lblTipSlider.Text = Math.Round(sliderTip).ToString() + "%";
            tipPercent = (int)sliderTip;

            lblSubtotal.Text = "$" + totalWithTip.ToString();
            lblTip.Text = "$" + Math.Round(tip, 2).ToString();

            lblGrandTotal.Text = "$" + totalWithTip.ToString();
        }

        private void Button_Clicked15(object sender, EventArgs e)
        {
            tipPercent = 15;
            Calculate();
        }

        private void Button_Clicked20(object sender, EventArgs e)
        {
            tipPercent = 20;
            Calculate();
        }

        private void Button_Clicked25(object sender, EventArgs e)
        {
            tipPercent = 25;
            Calculate();
        }
    }
}