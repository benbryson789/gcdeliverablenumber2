using System;

namespace GrandCircusEncodedMessages
{
    class Program
    {
        static void Main(string[] args)
        {

            string message = "";
            int checksum = 0;

            Console.WriteLine("What is your message?");

            string input  = Console.ReadLine().ToUpper();

            foreach (char character in input)
            {
                // A = 65 in Unicode
                message = message + $"{character - 64}-";
                checksum = checksum + character;
            }

            Console.WriteLine("Your encoded message is " + message.TrimEnd('-'));
            Console.WriteLine("Message checksum is " + checksum);

            // Just for sake of pausing  
            Console.Read();
        }
    }
}
