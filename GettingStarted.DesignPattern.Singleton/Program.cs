using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted.DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonV2 singleton1 = SingletonV2.GetInstance();
            SingletonV2 singleton2 = SingletonV2.GetInstance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("对象singleton1和对象singleton2是同一个对象！");
            }

            Console.ReadKey();
        }
    }
}
