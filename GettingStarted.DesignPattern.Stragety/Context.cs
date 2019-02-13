using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted.DesignPattern.Stragety
{
    /// <summary>
    /// 上下文
    /// </summary>
    public class Context
    {
        private IStrategy _strategy;
        
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }
        
        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}
