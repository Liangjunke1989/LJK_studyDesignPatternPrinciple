using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.ISP
{
    /// <summary>
    /// 接口隔离原则:客户端不应该依赖它不需要的接口；
    ///              一个类对另一个类的依赖应该建立在最小的接口上；
    /// </summary>
    public class ISPShow
    {
        public static void Show()
        {
            Console.WriteLine("***************ISPShow*************");


        }
    }
}
