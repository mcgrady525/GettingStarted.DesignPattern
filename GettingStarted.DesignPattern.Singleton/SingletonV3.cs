using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted.DesignPattern.Singleton
{
    /// <summary>
    /// 单例类（饿汉式版本）
    /// </summary>
    public class SingletonV3
    {
        private static readonly SingletonV3 _singleton = new SingletonV3();

        private SingletonV3()
        { }

        public static SingletonV3 GetInstance()
        {
            return _singleton;
        }

    }
}
