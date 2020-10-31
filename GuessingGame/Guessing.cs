using System;

namespace GuessingGame
{
    class Guessing
    {
        public static int SelectedNumber = 0;
        public static Random rand = new Random();
        public static bool GameOver = false;


        static void Main(string[] args)
        {
            // Subhi Najjar
            //Guessing Game ...

            SelectedNumber = rand.Next(1, 50);
            //SelectedNumber = rand.Next(1, 500000);
            
            int userNumber = 0;

            //if you need to know the right number.
            //Console.WriteLine($"The Guessing Number is : {SelectedNumber} ");


            do
            {
                Console.WriteLine("Guess a number between 1 and 50");
                userNumber = Convert.ToInt32(Console.ReadLine());
                GuessNumber(userNumber);
            }
            while (GameOver == false);

        }
        public static void GuessNumber (int userNumber)
        {
            int playAgain = 0;
            if (userNumber < SelectedNumber)
                Console.WriteLine("Too low. Try again.");
            else if (userNumber > SelectedNumber)
                Console.WriteLine("Too high. Try again.");
            else
            {
                Console.WriteLine("You got it! Press 1 to play again, or 2 to quit");
                playAgain = Convert.ToInt32(Console.ReadLine());

                while(playAgain != 1 && playAgain != 2)
                {
                    Console.WriteLine("Please select only 1 to play again, or 2 to quit");
                    playAgain = Convert.ToInt32(Console.ReadLine());
                }

                if (playAgain.Equals(2))
                    GameOver = true;
                else
                    SelectedNumber = rand.Next(1, 50);

            }
        }
    }
}
