using System;
namespace Pelingdrome 
{
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            int len = s.Length-1;
            string st = " ";
            for(int i = len; i >= 0;i--)
            {
                st = st+s[i].ToString();
            }
            if(s == st) 
            {
              System.Console.WriteLine("String is Palingdrome");
            } 
            else {
                System.Console.WriteLine("String is not PalingDrome");
            }
        }
    }

}