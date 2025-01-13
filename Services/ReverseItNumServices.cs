using System.Reflection.Metadata.Ecma335;

namespace AllForOneApi.Services
{
    public class ReverseItNumServices
    {
        public string ReverseItNum(string userNum)
        {
            bool isNum = Int32.TryParse(userNum, out int num);
            int reverseNum = 0;

            if(isNum)
            {
                while (num != 0)
                {
                    reverseNum = reverseNum * 10 + (num % 10);
                    num = num / 10;
                }
            }
            else
            {
                return $"That isn't a number. Please try again.";
            }
            return $"{userNum} reversed is {reverseNum}";
        }
        
    }
}