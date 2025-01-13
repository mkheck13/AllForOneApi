namespace AllForOneApi.Services
{
    public class AskingQuestionsServices
    {
        public string AskingQuestions(string userName, string wakeUpTime)
        {
            bool isNum = int.TryParse(wakeUpTime, out int trueWakeUp);

            if(isNum && trueWakeUp <= 12)
            {
                return $"Nice to met you {userName}, so you woke up at {trueWakeUp}.";
            }
            else{
                return "That is not the proper format for the time, try again!";
            }
        }
    }
}