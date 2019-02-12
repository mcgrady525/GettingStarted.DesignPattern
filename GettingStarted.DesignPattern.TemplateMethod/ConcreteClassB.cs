using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted.DesignPattern.TemplateMethod
{
    /// <summary>
    /// 子类B
    /// </summary>
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
        }
    }
}
