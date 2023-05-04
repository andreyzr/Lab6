using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = str.ToLower().Replace(" ","");
            int len= str.Length;
            bool f=false;
            for(int i=0; i<len; i++)
            {
                for(int j= len-1; j>0; j--)
                {
                    if (str[i]== str[j])
                    {
                        f = true;
                    }
                    else 
                    {
                        break; 
                    }
                }
                if (f == false)
                {
                    Console.WriteLine("Предложение не является полиндромом");
                }
                else
                {
                    Console.WriteLine("Предложение  является полиндромом");
                }
                Console.ReadKey();
            }
    
        }
    }
}
