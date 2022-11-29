using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    // DELEGATE MODIFER/DELEGATE/RETURN TYPE/NAME OF DELEGATE(PARAMETHER)
    public delegate void Add(int a, int b);
    
    public class SingleCastDelegate
    {
        // FOR 1ST DELEGET METHOD
        public void Add1(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }


    }
}
