using System;

namespace NumberGuessGameServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    // Implementation of SecretNUmber and CheckNumber function
    public class NumberGuessGame : INumberGameGuessService
    {
        private static int _secretNumber;
        public int SecretNumber(int lower, int upper)
        { //Generate a random secret number using the upper limit value and lower limit value

            DateTime currentDate = DateTime.Now;
            int seed = (int)currentDate.Ticks;
            Random random = new Random();
            _secretNumber = random.Next(lower, upper + 1);
            return _secretNumber;
        }

        public string CheckNumber(int userNum, int secretNum)
        {
            // here we will compare the number entered by the user and secret number generated.

            if (userNum == secretNum)
            {
                return "Correct";
            }
            else if (userNum > secretNum)
            {
                return "too big";
            }
            else
                return "too small";
        }
    }
}
