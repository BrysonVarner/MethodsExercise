namespace MethodsExercise
{
    public class Program
    {
        public static int AdditionInfiniteParams(params int[] numbers1) 
        {
            return numbers1.Sum();
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
            int result = mod1 % 2;

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
            Console.WriteLine($"\nNow for some even more strange questions, bear with me okay {userName}? \nI need some numbers to add together. \nWill you please insert some numbers separated by a comma for me.");
            string addStr0 = Console.ReadLine();
            int addNum = Convert.ToInt32( addStr0 );
            int totalSum = AdditionInfiniteParams(addNum);
            Console.WriteLine($"\nThank you {userName}! This will be like those MadLib books when you were young, \nso the effort will payoff in the end. I promise! Can I have some numbers to subtract please? Choose your first number.");
            string addStr1 = Console.ReadLine();
            int subIn1 = Convert.ToInt32(addStr1);
            Console.WriteLine("Okay, and your number to subtract from the last one?");
            string addStr2 = Console.ReadLine();
            int subIn2 = Convert.ToInt32(addStr2);
            int subTotal = Subtraction(subIn1, subIn2);

        }
    }
}
