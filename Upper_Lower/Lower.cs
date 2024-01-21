using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper_Lower
{
    internal class Lower
    {
        public void toLower(string input)
        {
            string output = "";
            char[] ca = input.ToCharArray();
            for(int x = 0; x < input.Length; x++)
            {
                output += ca[x].ToString().ToLower();
            }
            Console.WriteLine(output);
        }
    }
}
