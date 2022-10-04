using CSharpExercise.Domain.Services;

namespace Calculator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnAddition_Click(object sender, EventArgs e)
        {
            ValidationService validationService = new ValidationService();
            bool firstNumberIsDigit = validationService.IsDigit(TbxNumberOne.Text);
            bool secondNumberIsDigit = validationService.IsDigit(TbxNumberTwo.Text);

            /* w instrukcji warunkowej poniższy zapis oznacza to samo
            (firstNumberIsDigit == true) == (firstNumberIsDigit)
            (firstNumberIsDigit == false) == (!firstNumberIsDigit)
            */

            if (firstNumberIsDigit && secondNumberIsDigit)
            {
                decimal firstNumber = Convert.ToDecimal(TbxNumberOne.Text);
                decimal secondNumber = Convert.ToDecimal(TbxNumberTwo.Text);

                MathService mathService = new MathService();
                decimal result = mathService.Addition(firstNumber, secondNumber);

                TbxResult.Text = result.ToString();
            }
        }
        private void BtnSubstracion_Click(object sender, EventArgs e)
        {
            ValidationService validationService = new ValidationService();
            bool firstNumberIsDigit = validationService.IsDigit(TbxNumberOne.Text);
            bool secondNumberIsDigit = validationService.IsDigit(TbxNumberTwo.Text);

            if (firstNumberIsDigit && secondNumberIsDigit)
            {
                decimal firstNumber = Convert.ToDecimal(TbxNumberOne.Text);
                decimal secondNumber = Convert.ToDecimal(TbxNumberTwo.Text);

                MathService mathService = new MathService();
                decimal result = mathService.Substraction(firstNumber, secondNumber);

                TbxResult.Text = result.ToString();
            }
        }

        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            ValidationService validationService = new ValidationService();
            bool firstNumberIsDigit = validationService.IsDigit(TbxNumberOne.Text);
            bool secondNumberIsDigit = validationService.IsDigit(TbxNumberTwo.Text);

            if(firstNumberIsDigit && secondNumberIsDigit)
            {
                decimal firstNumber = Convert.ToDecimal(TbxNumberOne.Text);
                decimal secondNumber = Convert.ToDecimal(TbxNumberTwo.Text);

                MathService mathService = new MathService();
                decimal result = mathService.Multiplication(firstNumber, secondNumber);

                TbxResult.Text = result.ToString();
            }
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            ValidationService validationService = new ValidationService();
            bool firstNumberIsDigit = validationService.IsDigit(TbxNumberOne.Text);
            bool secondNumberIsDigit = validationService.IsDigit(TbxNumberTwo.Text);

            if( firstNumberIsDigit && secondNumberIsDigit)
            {
                decimal firstNumber = Convert.ToDecimal(TbxNumberOne.Text);
                decimal secondNumber = Convert.ToDecimal(TbxNumberTwo.Text);

                MathService mathService = new MathService();
                decimal result = mathService.Division(firstNumber, secondNumber);

                TbxResult.Text = result.ToString();
            }
        }
       

    }
}