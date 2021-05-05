using System;

namespace Binary2Hex2Decimal
{
    class Program
    {
        public static string ToDecimal(string Decimal, string userInput)
        {
            string hexInput = userInput;
            int decAgain = int.Parse(Decimal, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("0x" + hexInput + " in decimal is: " + decAgain);
            return Decimal;
        }
        

        public static int ToHex (int Hex)
        {
            string Convert2Hex = Convert.ToString(Hex, 16);
            return Hex;
        }

        public static int ToBinary (int Binary)
        {
            return Binary;
        }
        static void Main(string[] args)
        {
            int Restart = 1;

            while (Restart == 1)
            {

                Console.WriteLine("Enter a number to convert to: ");
                string userInput = Console.ReadLine();
                Console.WriteLine("What would you like to convert it to?: \n" +
                    "1: Decimal\n" +
                    "2: Hex\n" +
                    "3: Binary");
                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    string userDecimal = userInput;
                    ToDecimal(userDecimal, userInput);
                }
                if (userChoice == "2")
                {
                    Console.WriteLine("Choice 2 Test");
                }
                if (userChoice == "3")
                {
                    Console.WriteLine("Choice 3 Test");
                }

                Console.WriteLine("Would you like to convert another number? (Y/N): ");
                string userRestart = Console.ReadLine();
                if (userRestart == "Y")
                {
                    Restart = 1;
                }
                else
                {
                    Restart = 0;
                }
            }
        }
    }

}
