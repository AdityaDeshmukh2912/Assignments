using System;
using System.Text.RegularExpressions;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            //input=Console.ReadLine();
            string[] fileText = System.IO.File.ReadAllLines(@"C:\Users\deshmukha\OneDrive - Lenze SE\Documents\SampleFile.txt");
            Console.WriteLine("Text file contails :\n {0} .", fileText);
            Console.WriteLine("Enter Input string to be searched : ");
            input = Console.ReadLine();
            int counter = 0, lCounter = 0, lineNo=0;

            input = String.Format(@"(?i) {0}", input);

            

            Regex exp = new Regex(input);


            input = input.ToLower();
            foreach (string line in fileText)
            {
                MatchCollection matches = Regex.Matches(line,input);

                counter = counter + (matches.Count);
                    if (lineNo == 0 && counter>=2)
                    {
                        lineNo = lCounter;
                    }
                lCounter++;
            }
            Console.WriteLine("Input String : " + input);
            Console.WriteLine("No of Occurances : " + counter);
            Console.WriteLine("Answer : Line " + lineNo);


            
        }
    }
}
