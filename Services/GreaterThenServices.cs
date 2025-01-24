namespace AllForOneApi.Services
{
    public class GreaterThenServices
    {
        public string GreaterThen(string num1, string num2)
        {
            bool isRealNum1 = double.TryParse(num1, out double realNum1);
            bool isRealNum2 = double.TryParse(num2, out double realNum2);

            if (isRealNum1 && isRealNum2)
            {
                if (realNum1 > realNum2)
                {
                    return $"{realNum1} is greater than {realNum2}. And {realNum2} is less than {realNum1}.";
                }
                else if (realNum1 < realNum2)
                {
                    return $"{realNum1} is less than {realNum2}. And {realNum2} is greater than {realNum1}.";
                }
                else
                {
                    return $"{realNum1} and {realNum2} are equal to each other.";
                }
            }
            else
            {
                return "One or both seem to not a valid number. Please try again.";
            }
        }
    }
}