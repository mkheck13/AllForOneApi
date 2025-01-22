namespace AllForOneApi.Services
{
    public class GuessItServices
    {
        public string EasyMode(string input)
        {
            int randomIndex = new Random().Next(0, 11);
            bool isNum = int.TryParse(input, out int num);

            if (isNum && num > 0 && num < 11)
            {
                if (num == randomIndex)
                {
                    return $"{num} was the correct guess";
                }
                else if (num > randomIndex)
                {
                    return $"{num} seems to be to high. Try again.";
                }
                else
                {
                    return $"{num} seems to be to low. Try again.";
                }
            }
            else
            {
                return $"{input} was not a vailid input. Try guessing between 1 - 10.";
            }

        }

        public string MedMode(string input)
        {
            int randomIndex = new Random().Next(0, 51);
            bool isNum = int.TryParse(input, out int num);

            if (isNum && num > 0 && num < 51)
            {
                if (num == randomIndex)
                {
                    return $"{num} was the correct guess";
                }
                else if (num > randomIndex)
                {
                    return $"{num} seems to be to high. Try again.";
                }
                else
                {
                    return $"{num} seems to be to low. Try again.";
                }
            }
            else
            {
                return $"{input} was not a vailid input. Try guessing between 1 - 50.";
            }

        }

        public string HardMode(string input)
        {
            int randomIndex = new Random().Next(0, 101);
            bool isNum = int.TryParse(input, out int num);

            if (isNum && num > 0 && num < 101)
            {
                if (num == randomIndex)
                {
                    return $"{num} was the correct guess";
                }
                else if (num > randomIndex)
                {
                    return $"{num} seems to be to high. Try again.";
                }
                else
                {
                    return $"{num} seems to be to low. Try again.";
                }
            }
            else
            {
                return $"{input} was not a vailid input. Try guessing between 1 - 100.";
            }

        }
    }
}
