namespace CSharpExercise.Domain.Services
{
    public class ValidationService
    {
        public bool IsDigit(string number)
        {
            try
            {
                string changedDigit = ChangeToComma(number);

                decimal digit = Convert.ToDecimal(changedDigit);

                return true;
            }
            catch (Exception exception)
            {
                //MessageBox.Show($"This value {number} is not a number!!!!");

                //MessageBox.Show(exception.ToString());

                return false;
            }
        }

        public bool IsDigit(params string[] numbers)
        {
            string number = "";

            try
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    number = numbers[i];

                    string changedDigit = ChangeToComma(number);

                    decimal digit = Convert.ToDecimal(changedDigit);

                }

                return true;
            }
            catch (Exception exception)
            {
                //MessageBox.Show($"This value {number} is not a number!!!!");
                
                //MessageBox.Show(exception.ToString());

                return false;
            }
        }
        private string ChangeToComma (string number)
        {
            if(number.Contains(","))
            {
                number = number.Replace(",",".");
            }

            return number;
       
        }

        /*public bool IsIntDigit(string number)
        {
            try
            {
                //int digit = Convert.ToInt32(number);
                //bool sixDigit = IsSixDigits(digit);

                //return sixDigit;
            }
            catch (Exception exception)
            {
                //MessageBox.Show($"You have to enter a six digits number!!");
                //MessageBox.Show(exception.ToString());
                return false;
            }
        }*/


        private bool IsSixDigits(string number)
        {
            string digit = Convert.ToString(number);
            bool result = false;


            if (digit.Length == 6)
            {
                result = true;
            }
            else
            {
               //MessageBox.Show($"You have to enter a six digits number!!");
            }

            return result;

        }
    }


}
