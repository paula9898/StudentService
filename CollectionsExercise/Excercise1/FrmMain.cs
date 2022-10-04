using CSharpExercise.Domain.Services;

namespace CollectionsExercise.Exercise1
{
    public partial class Collections : Form
    {
        //pole klasy
        decimal[] operationArray = new decimal[6];
       
        public Collections()
        {
            InitializeComponent();
        }

        private void BtnAddition_Click(object sender, EventArgs e)
        {
            operationArray[0] = Convert.ToDecimal(TxbOne.Text);
            operationArray[1] = Convert.ToDecimal(TxbTwo.Text);
            operationArray[2] = Convert.ToDecimal(TxbThree.Text);
            operationArray[3] = Convert.ToDecimal(TxbFour.Text);
            operationArray[4] = Convert.ToDecimal(TxbFive.Text);
            operationArray[5] = Convert.ToDecimal(TxbSix.Text);

            decimal result = 0;

            for (int i = 0; i < operationArray.Length; i++)
            {
                result += operationArray[i];
            }
            
            LblAddResult.Text = result.ToString();
        }

        private void BtnMinMax_Click(object sender, EventArgs e)

        {
            ValidationService validationService = new ValidationService();/// Dependencies > Projects > Calculator
            //bool firstNumber = validationService.IsDigit

            List<decimal> values = AddTextFromTxbToList();



            decimal min = values.Min();
            decimal max = values.Max();

            LblMinMax.Text = ($"Min number is {min} and max number is {max}"); /// $ przed cudzysłowiem to interpolacja

        }

        private void TxbOne_TextChanged(object sender, EventArgs e)
        {
            if (TxbOne.Text.Contains(","))
            {
                MessageBox.Show("This textbox accepts only char '.'");

                string changedText = TxbOne.Text.Remove(TxbOne.Text.Length - 1);

                TxbOne.Text = changedText;


            }
        }
        private void TxbTwo_TextChanged(object sender, EventArgs e)
        {
            MathService mathservice= new MathService();
            string changedText = mathservice.ChangeCommeToPoint(TxbTwo.Text);
            TxbTwo.Text = changedText;

         
        }

        private void TxbThree_TextChanged(object sender, EventArgs e)
        {
            MathService mathservice = new MathService();
            string changedText = mathservice.ChangeCommeToPoint(TxbThree.Text);
            TxbThree.Text = changedText;

        }

        private void TxbFour_TextChanged(object sender, EventArgs e)
        {
            MathService mathservice = new MathService();
            string changedText = mathservice.ChangeCommeToPoint(TxbFour.Text);
            TxbFour.Text = changedText;
        }

        private void TxbFive_TextChanged(object sender, EventArgs e)
        {
            MathService mathservice = new MathService();
            string changedText = mathservice.ChangeCommeToPoint(TxbFive.Text);
            TxbFive.Text = changedText;

        }

        private void TxbSix_TextChanged(object sender, EventArgs e)
        {
            MathService mathservice = new MathService();
            string changedText = mathservice.ChangeCommeToPoint(TxbSix.Text);
            TxbSix.Text = changedText;

        }

        private void BtnCountElements_Click(object sender, EventArgs e)
        {


                                
            operationArray[0] = Convert.ToDecimal(TxbOne.Text);
            operationArray[1] = Convert.ToDecimal(TxbTwo.Text);
            operationArray[2] = Convert.ToDecimal(TxbThree.Text);
            operationArray[3] = Convert.ToDecimal(TxbFour.Text);
            operationArray[4] = Convert.ToDecimal(TxbFive.Text);
            operationArray[5] = Convert.ToDecimal(TxbSix.Text);

            decimal numberOfElements = operationArray.Length;

            LblNumberOfElements.Text = numberOfElements.ToString();
        }

        private void BtnDividedByThree_Click(object sender, EventArgs e)
        {
            ValidationService validationService = new ValidationService();

            bool isNumberValid = validationService.IsDigit(TxbOne.Text, TxbTwo.Text, TxbThree.Text, TxbFour.Text, TxbFive.Text, TxbSix.Text);

            if (isNumberValid)
            {
                operationArray[0] = Convert.ToDecimal(TxbOne.Text);
                operationArray[1] = Convert.ToDecimal(TxbTwo.Text);
                operationArray[2] = Convert.ToDecimal(TxbThree.Text);
                operationArray[3] = Convert.ToDecimal(TxbFour.Text);
                operationArray[4] = Convert.ToDecimal(TxbFive.Text);
                operationArray[5] = Convert.ToDecimal(TxbSix.Text);



                List<decimal> numbers = new List<decimal>();


                for (int i = 0; i < operationArray.Length; i++)
                {
                    if (operationArray[i] % 3 == 0 && operationArray[i] != 0)
                    {
                        numbers.Add(operationArray[i]);
                    }
                }

                string concatNumbers = string.Join(",", numbers);
                if (string.IsNullOrEmpty(concatNumbers))
                {
                    concatNumbers = "None";
                }

                LblNumbersDividedByThree.Text = $"Numbers divided by three: {concatNumbers}";

            }
            else
            {
                
                LblNumbersDividedByThree.Text = "ERROR";
            }

        }   

        private void BtnElement_Click(object sender, EventArgs e)
        {
            ValidationService validationService = new ValidationService();

            bool isNumberValid = validationService.IsDigit(TxbOne.Text, TxbTwo.Text, TxbThree.Text, TxbFour.Text, TxbFive.Text, TxbSix.Text);

            List<decimal> values = AddTextFromTxbToList();

            List<decimal> numbers = new List<decimal>();

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] == Convert.ToDecimal(TxbFive.Text))
                {
                    numbers.Add(i+1);
                }
            } 

            string textBoxNumbers = string.Join(",", numbers);

            LblElement.Text = $"Textbox numbers are: {textBoxNumbers}";
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {

            ValidationService validationService = new ValidationService();

            bool isNumberValid = validationService.IsDigit(TxbOne.Text, TxbTwo.Text, TxbThree.Text, TxbFour.Text, TxbFive.Text, TxbSix.Text);

            if (isNumberValid)
            {
                List<decimal> values = AddTextFromTxbToList();


                values.Sort();

                List<decimal> numbers = new List<decimal>();

                foreach (decimal x in values)
                {
                    numbers.Add(x);
                }
                string sortedNumbers = string.Join(",", numbers);

                LblSort.Text = $"Sorted numbers are: {sortedNumbers}";
            }
            else
            {
                LblSort.Text = "ERROR";
            }
        }

        private List<decimal> AddTextFromTxbToList()
        {
            List<decimal> operationList = new List<decimal>();/// !

            operationList.Add(Convert.ToDecimal(TxbOne.Text));
            operationList.Add(Convert.ToDecimal(TxbTwo.Text));
            operationList.Add(Convert.ToDecimal(TxbThree.Text));
            operationList.Add(Convert.ToDecimal(TxbFour.Text));
            operationList.Add(Convert.ToDecimal(TxbFive.Text));
            operationList.Add(Convert.ToDecimal(TxbSix.Text));

            return operationList;
        }
    }



}