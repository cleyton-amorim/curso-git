using System;

namespace ExemploDatetime
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dt =  DateTime.Now;
            string s  = dt.ToLongTimeString();
            string s2 = dt.ToLongDateString(); 
            Console.WriteLine(s);
            Console.WriteLine(s2);
        }
    }
}
