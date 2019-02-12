using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted.DesignPattern.Singleton
{
    /// <summary>
    /// 单例类（双检锁）
    /// </summary>
    public class SingletonV2
    {
        private static SingletonV2 _singleton;
        private static readonly object lockObj = new object();

        private SingletonV2()
        { }

        public static SingletonV2 GetInstance()
        {
            if (_singleton == null)
            {
                lock (lockObj)
                {
                    if (_singleton == null)
                    {
                        _singleton = new SingletonV2();
                    }
                }
            }

            return _singleton;
        }
    }
}
