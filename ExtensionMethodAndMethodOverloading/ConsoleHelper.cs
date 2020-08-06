using System;

namespace ExtensionMethodAndMethodOverloading
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output;
            do
            {
                Console.WriteLine(message);
                output = Console.ReadLine();
            } while (output.Length == 0);
            return output;
        }

        public static int RequestInt (this string message)
        {

            return message.RequestInt(false);
        }

        public static int RequestInt(this string message, int minAge, int maxAge)
        {

            return message.RequestInt(true, minAge, maxAge);
        }

        private static int RequestInt(this string message, bool applyMinMax, int minAge=0, int maxAge=100)
        {

            bool isValid;
            int output;
            bool isInValidRange = true;

            do
            {
                Console.WriteLine(message);
                string userInput = Console.ReadLine();
                isValid = int.TryParse(userInput, out int convertedInt);
                output = convertedInt;


                if(applyMinMax == true)
                {
                    isInValidRange = (output >= minAge && output <= maxAge);
                    //if(output >= minAge && output <= maxAge)
                    //{
                    //    isInValidRange = true;
                    //}
                    //else
                    //{
                    //    isInValidRange = false;
                    //}
                }



            } while (isValid == false || isInValidRange == false) ;

            return output;
        }
    }
}
