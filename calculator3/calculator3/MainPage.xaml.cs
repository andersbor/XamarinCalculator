using Xamarin.Forms;

namespace calculator3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ButtonCalculate.Clicked += (sender, args) =>
            {
                MessageLabel.Text = "Clicked ";
                string number1Str = Number1Entry.Text;
                string number2Str = Number2Entry.Text;
                MessageLabel.Text += number1Str + " " + number2Str;
                if (number1Str == null || number1Str.Trim() == "")
                {
                    MessageLabel.Text = "Not a number";
                    return;
                }
                double number1 = double.Parse(number1Str);
                double number2 = double.Parse(number2Str);
                double result = 0.0;
                int selectedIndex = OperationPicker.SelectedIndex;
                MessageLabel.Text += " " + selectedIndex;
                switch (selectedIndex)
                {
                    case -1:
                        MessageLabel.Text = "Select an operation";
                        return; // nothing selected
                    case 0: // +
                        result = number1 + number2;
                        break;
                    case 1: // -
                        result = number1 - number2;
                        break;
                    case 2: // *
                        result = number1 * number2;
                        break;
                    case 3: // *
                        result = number1 / number2;
                        break;
                }
                ResultLabel.Text = result.ToString();
            };
        }
    }
}
