using Humanizer;

namespace NumberToWord
{
    class Convert
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("-------------> Convert number to letters <-------------");
                Console.WriteLine("Enter a number between -9,999 and 9,999");
                string input = Console.ReadLine();
                int number;

                if(int.TryParse(input, out number) && number >= -9999 && number <= 9999)
                {
                    string letters = number.ToWords(new System.Globalization.CultureInfo("en"));
                    Console.WriteLine("The number " + "'" + number + "'" + " in letters is: " + letters);

                    Console.WriteLine(new string('-', 55));
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine(new string('-', 55));
                }
            }
        }
    }
}
