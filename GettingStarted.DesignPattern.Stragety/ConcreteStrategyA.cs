using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted.DesignPattern.Stragety
{
    /// <summary>
    /// 具体策略A
    /// </summary>
    public class ConcreteStrategyA : IStrategy
    {
        public void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }
}
