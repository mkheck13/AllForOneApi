namespace AllForOneApi.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(string input)
        {
            bool isNum = int.TryParse(input, out int num);

            if (isNum)
            {
                if (isNum && num % 2 == 0)
                {
                    return $"{num} appears to be even.";
                }
                else
                {
                    return $"{num} appears to be odd.";
                }
            }
            else
            {
                return $"{input} was not a number. Try entering a number.";
            }
        }
    }
}