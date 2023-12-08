using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.LOD
{
    /// <summary>
    /// 迪米特法则(最少知道原则):一个对象应该对其他对象保持最少的了解。
    /// 面向对象--类--类与类之间会有交互--功能模块--系统
    /// 高内聚，低耦合：高度封装，尽量少的暴露信息，类与类之间减少依赖
    /// 耦合关系：依赖、    关联、组合、聚合    继承 实现
    ///         间接朋友      直接朋友
    /// 只与直接的朋友通信
    /// 
    /// 去掉内部依赖--降低访问修饰符
    /// 门面(外观)模式/中介者模式
    /// </summary>
    public class LODShow
    {
        public static void Show()
        {
            Console.WriteLine("************************");
            School school = new School()
            {
                SchoolName = "软谋教育",
                ClassList = new List<Class>()
                {
                    new Class()
                    {
                        ClassName="高级班",
                        StudentList=new List<Student>()
                        {
                            new Student()
                            {
                                StudentName="yoyo"
                            }
                        }
                    }
                }
            };

            school.Manage();
        }
    }
}
