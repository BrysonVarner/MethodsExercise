namespace MethodsExercise
{
    public class Program
    {
        public static int Addition(int add1, int add2) 
        {
            return add1 + add2;
        }
        public static int Subtraction(int sub1, int sub2)
        {
            return sub1 - sub2;
        }
        public static int Multiplication(int mlt1, int mlt2)
        {
            return mlt1 * mlt2;
        }
        public static int Division(int div1, int div2)
        {
            return div1 / div2;
        }
        public static int Modulus(int mod1)
        {
            int mod2 = 2;
            int result = mod1 % mod2;

            if (result == 0) 
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        static void Main(string[] args)
        {
            //------------------Project 1-------------------
            
            Console.WriteLine("Welcome to Part One of my C# Method Exercise! What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"\nHi {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("\nDo you have a favorite kind of animal? What is it called?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine($"\nThat is awesome {userName}! Do you have a favorite band? What is their name?"); 
            string favBand = Console.ReadLine();
            Console.WriteLine($"\nNow for some even more strange questions, bear with me okay {userName}? \nI need some numbers to add together. \nWill you please insert a number for me.");
            string addStr = Console.ReadLine();
            int addNum1 = Convert.ToInt32(addStr);
            Console.WriteLine("\nOkay, and a number to add to the last one?");
            string addStr0 = Console.ReadLine();
            int addNum2 = Convert.ToInt32(addStr0);
            int totalSum = Addition(addNum1, addNum2);
            Console.WriteLine($"\nThank you {userName}! This will be like those MadLib books when you were young, \nso the effort will payoff in the end. I promise! Can I have some numbers to subtract please? Choose your first number.");
            string addStr1 = Console.ReadLine();
            int subIn1 = Convert.ToInt32(addStr1);
            Console.WriteLine("\nOkay, and your number to subtract from the last one?");
            string addStr2 = Console.ReadLine();
            int subIn2 = Convert.ToInt32(addStr2);
            int subTotal = Subtraction(subIn1, subIn2);
            Console.WriteLine("\nCan I please get some numbers to multiply together now? Please enter the first number.");
            string addStr3 = Console.ReadLine();
            int multIn1 = Convert.ToInt32(addStr3);
            Console.WriteLine("\nOkay, and your number to multiply the last one by?");
            string addStr4 = Console.ReadLine();
            int multIn2 = Convert.ToInt32(addStr4);
            int multTotal = Multiplication(multIn1, multIn2);
            Console.WriteLine($"\nYou are doing a great job {userName}! Enter a number to divide also?");
            string addStr5 = Console.ReadLine();
            int divIn1 = Convert.ToInt32(addStr5);
            Console.WriteLine("\nAnd enter a number to divide that last one by.");
            string addStr6 = Console.ReadLine();
            int divIn2 = Convert.ToInt32(addStr6);
            int divTotal = Division(divIn1, divIn2);
            Console.WriteLine($"\nAlright {userName}, Last one. Pick a number... ");
            string addStr7 = Console.ReadLine();
            int modIn = Convert.ToInt32(addStr7);
            int modTotal = Modulus(modIn);
            Console.WriteLine($"I met another person named {userName} once before.");
            Console.WriteLine($"{userName} was very smart, especially with their money.");
            Console.WriteLine($"{userName} always said it was because of their {favColor} socks.");
            Console.WriteLine($"One day {userName} decided to try to gamble on their favorite sports team, the Fighting {favAnimal}s.");
            Console.WriteLine($"They checked the ATM and the account balance was ${multTotal}!");
            Console.WriteLine($"{userName} never gambled before and was nervous, so they had ${divTotal} in" +
                $" drinks to try and relax.");
            Console.WriteLine($"{userName} placed a bet on the Fighting {favAnimal}s in the amount of ${totalSum}.");
            if (modTotal == 0)
            {
                Console.WriteLine($"{userName} ended up losing the bet and ${subTotal} by the end of the day. Good thing for the band {favBand}, \ntheir music always took {userName}'s mind off of problems.");
            }
            else 
            {
                Console.WriteLine($"{userName} ended up winning the bet and ${subTotal} on it. {userName} knew just how they wanted to celebrate! Listen to their favorite band {favBand}, That always got them pumped!");
            }
            



        }
    }
}
