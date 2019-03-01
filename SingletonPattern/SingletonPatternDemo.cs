using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 从 singleton 类获取唯一的对象。
    /// </summary>
    public class SingletonPatternDemo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {

            //不合法的构造函数
            //编译时错误：构造函数 SingleObject() 是不可见的
            //SingleObject object = new SingleObject();

            //获取唯一可用的对象
            EagerSingleObject obj = EagerSingleObject.GetInstance();

            //显示消息
            obj.ShowMessage();

            Console.ReadLine();
        }
    }
}
