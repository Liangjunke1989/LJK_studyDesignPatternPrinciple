using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.DIP
{
    /// <summary>
    /// 依赖倒置原则:上层模块不应该依赖于低层模块，二者应该通过抽象依赖
    /// 
    /// </summary>
    public class DIPShow
    {
        public static void Show()
        {
            Console.WriteLine("**************DIPShow***************");
            Student student = new Student()
            {
                Id = 191,
                Name = "候鸟班长"
            };
            {
                iPhone phone = new iPhone();
                student.PlayiPhone(phone);
            }
            {
                Lumia phone = new Lumia();
                student.PlayLumia(phone);
            }
        }
    }
}
