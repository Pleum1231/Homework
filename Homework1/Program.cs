using System;
using GuessNumberGame;
namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "\nWelcome to program Guess Number\n" +
                "this program work with 3 or 4 Arguments.\n" +
                "###################################################################\n" +
                "Argument 1 = select mode to play.(0=non-limit guess, 1=limit guess)\n" +
                "Argument 2 = mix number to guess.\n" +
                "Argument 3 = max number to guess.\n" +
                "Argument 4(if Argument 1 = 1) = number of times to guess.\n" +
                "###################################################################\n";

            if(args.Length==4)
            {
                Game GuessNumber = new Game();
                GuessNumber.Start(Convert.ToInt32(args[0]), Convert.ToInt32(args[1] ), Convert.ToInt32(args[2]), Convert.ToInt32(args[3]) );
            }

            else if(args.Length==3)
            {
                Game GuessNumber = new Game();
                GuessNumber.Start(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2]), 0);
            }

            else
            {
                Console.WriteLine("{0}", menu);
            }
            Console.ReadKey();
        }
    }
}
