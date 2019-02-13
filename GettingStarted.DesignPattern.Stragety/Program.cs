using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted.DesignPattern.Stragety
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;
            
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            Console.ReadKey();
        }
    }
}
