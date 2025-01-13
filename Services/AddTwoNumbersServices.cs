namespace AllForOneApi.Services
{
    public class AddTwoNumbersServices
    {
        public string AddTwoNumbers(string num1, string num2)
        {
            bool isNum1 = int.TryParse(num1, out int trueNum1);
            bool isNum2 = int.TryParse(num2, out int trueNum2);

            if (isNum1 && isNum2)
            {
                return $"The total of {trueNum1} and {trueNum2} is {trueNum1 + trueNum2}";
            }
            else
            {
                return "One or both don't seem to be numbers. Try again.";
            }
        }
    }
}