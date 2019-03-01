using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 懒汉式 
    /// 线程安全
    /// </summary>
    public class LazySingletonSecurity
    {
        /// <summary>
        /// volatile 可以保证运行过程中值不会被重复修改
        /// </summary>
        private static volatile LazySingletonSecurity _LazySingletonSecurity = null;

        /// <summary>
        /// 
        /// </summary>
        private static object LazySingletonSecurity_Lock = new object();

        /// <summary>
        /// private  避免外部创建
        /// </summary>
        private LazySingletonSecurity()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static LazySingletonSecurity CreateInstance()
        {
            if (_LazySingletonSecurity == null)//保证对象初始化之后，不在去等待锁 
            {
                lock (LazySingletonSecurity_Lock)//保证只有一个线程进去 
                {
                    if (_LazySingletonSecurity == null)//保证只被实例化一次 
                    {
                        _LazySingletonSecurity = new LazySingletonSecurity();
                    }
                }

            }

            return _LazySingletonSecurity;
        }
    }
}
