namespace AllForOneApi.Services
{
    public class ReverseItAlphaServices
    {
        public string ReverseItAlpha(string input)
        {
            string reverseWord = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverseWord += input[i];
            }
            return $"{input} reversed is {reverseWord}";
        }
    }
}