namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void etnEnterBillAmount_Completed(object sender, EventArgs e)
        {
            lblGrandTotal.Text = "$" + etnEnterBillAmount.Text;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var totalWithTip = decimal.Parse(etnEnterBillAmount.Text) * 15;

            lblGrandTotal.Text = "$" + totalWithTip.ToString();
        }
    }
}
