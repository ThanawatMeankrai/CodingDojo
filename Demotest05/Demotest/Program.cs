using System;

namespace Demotest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x < 10)
            {
               
                IHomework05 con = new homework();
                Console.Write("Please choose LED to turn On/Off:");
                String lednum = Console.ReadLine();
                string sum = con.DisplayLEDOnScreen(lednum);
                //Console.WriteLine(sum);
            }
        }
    }
}
