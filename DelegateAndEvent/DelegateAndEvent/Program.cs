using System;

namespace DelegateAndEvent
{
    public delegate void delegatevent();
    class Program
    {
        public static event delegatevent add;
        public static void Main(string[] args)
        {
            Console.WriteLine("DelegateAndEvent");
            Console.WriteLine("Enter a Number \n 1.single cast delegate\n 2.multi cast delegate \n 3.array delegate \n 4.Event");
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
                case 4:
                    add += new delegatevent(INDIA);
                    add += new delegatevent(USA);
                    add += new delegatevent(ENGLAND);
                    add.Invoke();
                    Event.Implementation();
                    break;
            }
            static void INDIA()
            {
                Console.WriteLine("INDIA");
            }
            static void USA()
            {
                Console.WriteLine("USA");
            }
            static void ENGLAND()
            {
                Console.WriteLine("ENGLAND");
            }
        }
    }
}