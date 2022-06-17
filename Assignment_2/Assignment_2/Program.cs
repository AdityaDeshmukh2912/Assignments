using System;
using System.IO;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n = Int32.Parse(Console.ReadLine());
         
            var numbers = new string[n];
            Console.WriteLine("Enter Array Elements : ");
            for (int i = 0; i < n; i++)
                numbers[i] = Console.ReadLine();

            
            File.WriteAllLines(@"C:\Users\deshmukha\OneDrive - Lenze SE\Documents\newFile.txt", numbers);

            string[] numbers1 = System.IO.File.ReadAllLines(@"C:\Users\deshmukha\OneDrive - Lenze SE\Documents\newFile.txt");

            Console.WriteLine("Input Array : {0} ", String.Join(",", numbers));

            Console.WriteLine("Input number to find pairs :");
            var input = Console.ReadLine();

            int count = 0;
            
            foreach(var num in numbers)
            {
                if (num.Equals(input))
                {
                    count++;
                }
            }
            Console.WriteLine("Answer : " + (count / 2));
        }
    }
}
