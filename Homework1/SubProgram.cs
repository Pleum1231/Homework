using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumberGame
{
    class RAND
    {
        public int RandomNumber(int min,int max)
        {
            Random random = new Random();
            return random.Next(min,max);
        }
    }

    class Game
    {
        RAND RObject = new RAND();
        int count=0;
        int num=0;
        int guess=0;
        public
        void Start(int mode,int min,int max,int time)
        {
            num=RObject.RandomNumber(min, max);
           
            msg1(min,max);
            if (mode == 0)
            {
                while (guess != num)
                {
                    msg5();
                    int.TryParse(Console.ReadLine(), out guess);
                    count++;
                    if (num > guess)
                    {
                        msg3();
                    }
                    else if (num < guess)
                    {
                        msg2();
                    }

                }
                msg4();
                msg6();
            }
            else
            {
                while (guess != num&& count<time)
                {
                    msg5();
                    int.TryParse(Console.ReadLine(), out guess);
                    count++;
                    if (num > guess)
                    {
                        msg3();
                    }
                    else if (num < guess)
                    {
                        msg2();
                    }
                    if(time-count>0)
                    {
                        Console.WriteLine("You have {0} times left.\n", time - count);
                    }
                }
                if (count <= time && guess == num)
                {
                    msg4();
                    msg6();
                }
                else
                {
                    msg7();
                }
            }
        }
        void msg1(int min,int max)
        {
            Console.WriteLine(" Welcome to GuessNumber game!");
            Console.WriteLine("min number = {0}  max number = {1}\n", min, max);

        }
        void msg2()
        {
            Console.WriteLine("That's wrong! Your Guess number are greater than Random number\n");
        }
        void msg3()
        {
            Console.WriteLine("That's wrong! Your Guess number are less than Random number\n");
        }
        void msg4()
        {
            Console.WriteLine("That's correct, You win!");
        }
        void msg5()
        {
            Console.Write("Number ? ");
        }
        void msg6()
        {
            Console.Write("You guess {0} times.",count);
        }
        void msg7()
        {
            Console.WriteLine("You out of time to guess, you loss...\n" +
                "Try again next time!");
        }
        
    }
}
