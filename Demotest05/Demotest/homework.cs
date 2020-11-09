using System;
using System.Collections.Generic;
using System.Text;

namespace Demotest
{
public class homework : IHomework05
    {
        public static string[] led = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
        public string DisplayLEDOnScreen(string lednum)
        {
            string value = null;
            if (lednum == "A")
            {
                led[9] = led[9] == "[ ]" ? "[!]" : "[ ]";
            }
            else
            {
                int num = int.Parse(lednum);
                num--;
                led[num] = led[num] == "[ ]" ? "[!]" : "[ ]";
            }
            foreach (string item in led)
            {
                value += item;
            }
            Console.WriteLine(value);
            Console.WriteLine(" 1  2  3  4  5  6  7  8  9  A");
            return value;
        }

    }
}
