using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unikm.DP.AbstractFactoryPattern
{
    /// <summary>
    /// 
    /// </summary>
    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Green::fill() method.");
        }
    }
}
