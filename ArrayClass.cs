/*
 * 
 * 
 * THIS CLASS IS NOT USED IN THE PROGRAM
 * 
 * 
 * 
 * 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJS
{
    public class ArrayClass
    {
        List<string> greetings = new List<string>(new string[] { "hello", "bonjour", "ciao" });

        public String this[int i]
        {
            get
            {
                if (i >= greetings.Count)
                {
                    greetings.Add("here is a new one");
                }
                return greetings[i];
            }
        }
        public void addGreeting(String g)
        {
            greetings.Add(g);
        }
    }
}
*/