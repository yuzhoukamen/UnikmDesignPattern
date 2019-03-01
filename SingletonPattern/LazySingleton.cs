using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 懒汉式，线程不安全
    /// 是否 Lazy 初始化：是
    /// 是否多线程安全：否
    /// 实现难度：易
    /// 描述：这种方式是最基本的实现方式，这种实现最大的问题就是不支持多线程。因为没有加锁 synchronized，所以严格意义上它并不算单例模式。
    /// 这种方式 lazy loading 很明显，不要求线程安全，在多线程不能正常工作。
    /// Lazy Singleton（懒汉式单例类），其类的唯一实例在真正调用时才被创建，而不是类加载时就被创建。所以Lazy Singleton不是线程安全的。
    /// 注意：不管是懒汉还是饿汉，其构造函数必须私有，以防多个实例被创建。另外，用懒汉式单例在多线程环境中需要其他的保护措施来保证只有单例被创建，因为可能有多个线程同时调用GetInstance()。 
    /// </summary>
    public class LazySingleton
    {
        /// <summary>
        /// 
        /// </summary>
        private static LazySingleton Instance = null;

        /// <summary>
        /// 
        /// </summary>
        private LazySingleton() { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static LazySingleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new LazySingleton();
            }

            return Instance;
        }
    }
}
