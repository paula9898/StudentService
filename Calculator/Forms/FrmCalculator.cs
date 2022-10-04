namespace Calculator.Forms
{
    public partial class FrmCalculator : Form
    {
        string operatorClicked = "";
        double resultValue = 0;
        bool isOperatorClicked = false;
        public FrmCalculator()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            if (TxbResult.Text == "0" || (isOperatorClicked))
            {
                TxbResult.Clear();
            }

            isOperatorClicked = false;
            var button = (Button)sender;
            if (button.Text == ".")
            {
                if (!TxbResult.Text.Contains(".") && !String.IsNullOrEmpty(TxbResult.Text))
                {
                    TxbResult.Text = TxbResult.Text + button.Text;
                }
                else if (TxbResult.Text.Contains(".") && !String.IsNullOrEmpty(TxbResult.Text))
                {
                    TxbResult.Text = TxbResult.Text;
                }
                else
                {
                    TxbResult.Text = "0";
                    TxbResult.Text = TxbResult.Text + button.Text;
                }
            }
            else
            {
                TxbResult.Text = TxbResult.Text + button.Text;

            }
                
        }
        private string ClearZero (string text)
        {
          if (text.Contains("0"))
            {
                text = text.Replace("0","");
            }

            return text;
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxbResult.Text = "0";
            resultValue = 0;
        }
        private void BtnOperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                BtnEqual.PerformClick();
                operatorClicked = button.Text;
                isOperatorClicked = true;
            }
            else
            {
                operatorClicked = button.Text;
                resultValue = Double.Parse(TxbResult.Text);
                isOperatorClicked = true;
                LabelCurrentOperation.Text = resultValue + " " + operatorClicked;

            }
            operatorClicked = button.Text;
            resultValue = Double.Parse(TxbResult.Text);
            LabelCurrentOperation.Text = resultValue + " " + operatorClicked;
            



        }
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            switch(operatorClicked)
            {
                case "+":
                    TxbResult.Text = (resultValue + Double.Parse(TxbResult.Text)).ToString();
                    break;
                case "-":
                    TxbResult.Text = (resultValue - Double.Parse(TxbResult.Text)).ToString();
                    break;
                case "*":
                    TxbResult.Text = (resultValue * Double.Parse(TxbResult.Text)).ToString();
                    break;
                case "/":
                    TxbResult.Text = (resultValue / Double.Parse(TxbResult.Text)).ToString();
                    break;
                default:
                    break;
            }

        }
    }
}
