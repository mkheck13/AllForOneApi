namespace AllForOneApi.Services
{
    public class SayHelloServices
    {
        public string SayHello(string userName)
        {
            if (!string.IsNullOrEmpty(userName))
            {
                return $"Hello {userName}.";
            }
            else
            {
                return "Hello Mr/Mrs/Miss. NoName";
            }
        }
    }
}