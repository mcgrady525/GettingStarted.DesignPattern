using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted.DesignPattern.Singleton
{
    /// <summary>
    /// 单例类（初始版本）
    /// </summary>
    public class SingletonV1
    {
        private static SingletonV1 _singleton;

        private SingletonV1()
        { }

        public static SingletonV1 GetInstance()
        {
            if (_singleton== null)
            {
                _singleton = new SingletonV1();
            }

            return _singleton;
        }

    }
}
