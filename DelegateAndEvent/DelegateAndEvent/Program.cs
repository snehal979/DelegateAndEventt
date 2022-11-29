using System;

namespace DelegateAndEvent
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("DelegateAndEvent");
            Console.WriteLine("Enter a Number \n 1.single cast delegate\n 2.multi cast delegate \n 3.array delegate");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    SingleCastDelegate creat = new SingleCastDelegate();
                    // delegate
                    Add a = new Add(creat.Add1);
                    a(100, 40);
                  
                    break;
                case 2:
                    multiCastDelegate.ImplementationDelegate();
                    break;
                case 3:
                    ArrayDelegate.ImplementationArrayDelegate();
                    break;
            }
        }
    }
}