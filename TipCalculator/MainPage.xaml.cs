namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        decimal subtotal;

        public MainPage()
        {
            InitializeComponent();
        }

        private void etnEnterBillAmount_Completed(object sender, EventArgs e)
        {
            lblGrandTotal.Text = "$" + etnEnterBillAmount.Text;
            subtotal = decimal.Parse(etnEnterBillAmount.Text);
            lblSubtotal.Text = subtotal.ToString();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var tip = (decimal.Parse(etnEnterBillAmount.Text) / 100) * 15;
            
            var totalWithTip = subtotal + tip;

            totalWithTip = Math.Round(totalWithTip, 2);

            lblGrandTotal.Text = "$" + totalWithTip.ToString();
            lblTip.Text = tip.ToString();
            
        }
    }
}
