using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    /// <summary>
    /// MulticastDelegate
    /// </summary>
    public class multiCastDelegate
    {
        delegate void Object1(int x, int y);
        public static void ImplementationDelegate()
        {
            Object1 obj = Calculation.Add1;
            obj += Calculation.Sub1;
            obj(75, 75);
            obj(75, 75);


        }
    }
    class Calculation
    {

        public static void Add1(int a, int b)
        {
            Console.WriteLine("sum is {0}", a + b);
        }

        public static void Sub1(int a, int b)
        {
            Console.WriteLine("sub is {0}", a - b);
        }


    }
    /// <summary>
    /// Array Delegate
    /// </summary>
    public class ArrayDelegate
    {
        delegate void Object1(int x, int y);
        public static void ImplementationArrayDelegate()
        {
            // delegate instantation
            Object1[] obj =
            {
                new Object1(Calculation.Add1),
                new Object1(Calculation.Sub1)
            };
            for (int i = 0; i<obj.Length; i++)
            {
                obj[i](100, 60);
                obj[i](34, 6);
                obj[i](5, 4);
                obj[i](7, 6);
            }


        }

    }
   
    
}
