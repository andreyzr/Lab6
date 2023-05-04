using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string starString =Console.ReadLine();
            string [] stringArray = starString.Split();
            string resultString = "";
            foreach (string s in stringArray)
            {
                resultString += s.Substring(0, 1).ToUpper() + s.Substring(1) + ' ';
            }
            Console.WriteLine(resultString);
            Console.ReadKey();
        }
    }
}
