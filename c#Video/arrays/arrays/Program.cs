using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42};

            string[] names = new string[] { "NAKUL", "KOTHARI", "202012110", "DAIICT"};

            Console.WriteLine(numbers.Length);
            //using for loop
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //using foreach
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // string to array

            string str = "Tera bhai kisse kam hai tere bhai me bhi dum hai";

            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);

            foreach (char strChar in charArr)
            {
                Console.Write(strChar);
            }

            Console.ReadLine();
        }
    }
}
