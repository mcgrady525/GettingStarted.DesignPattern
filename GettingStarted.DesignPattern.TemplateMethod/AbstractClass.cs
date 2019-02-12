using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted.DesignPattern.TemplateMethod
{
    /// <summary>
    /// 父类
    /// </summary>
    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        /// <summary>
        /// 模板方法
        /// </summary>
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }

    }
}
