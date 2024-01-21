using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper_Lower
{
    internal class Upper
    {
        public void toUpper(string input )
        {
            string s = "";
            char[] c = input.ToCharArray();
            for(int x=0;x<input.Length;x++)
            {
                s += c[x].ToString().ToUpper();
            }
            Console.WriteLine(s);

        }
    }
}
