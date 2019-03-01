using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// Eager Singleton(饿汉式单例类)，其静态成员在类加载时就被初始化，此时类的私有构造函数被调用，单例类的唯一实例就被创建。
    /// </summary>
    public class EagerSingleObject
    {
        /// <summary>
        /// 创建 SingleObject 的一个对象
        /// 饿汉式单例类
        /// </summary>
        private static EagerSingleObject Instance = new EagerSingleObject();

        /// <summary>
        /// 让构造函数为 private，这样该类就不会被实例化
        /// </summary>
        private EagerSingleObject() { }

        /// <summary>
        /// 获取唯一可用的对象
        /// </summary>
        /// <returns></returns>
        public static EagerSingleObject GetInstance()
        {
            return Instance;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
