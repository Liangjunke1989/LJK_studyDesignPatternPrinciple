﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple
{
    /// <summary> 
    /// 1.  单一职责原则（Single Responsibility Principle）
    /// 2.  里氏替换原则（Liskov Substitution Principle）
    /// 3.  依赖倒置原则（Dependence Inversion Principle）
    /// 4.  接口隔离原则（Interface Segregation Principle）
    /// 5.  迪米特法则  （Law Of Demeter）
    /// 6.  开闭原则     (Open Closed Principle)
    /// 
    /// 设计模式：面向对象语言开发过程中，遇到各种场景和问题，解决方案和思路，沉淀下来就是设计模式
    ///         套路
    /// 设计模式六大原则： 面向对象语言开发过程中，推荐的一些指导性原则(并不是强制要求的)        
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到 .net高级班vip课程，今天是Eleven老师为大家带来的设计模式六大原则");
                //{
                //    Console.WriteLine("*******************单一职责原则********************");
                //    SRP.SRPShow.Show();
                //}
                //{
                //    Console.WriteLine("*******************里氏替换原则********************");
                //    LSP.LSPShow.Show();
                //}
                //{
                //    Console.WriteLine("*******************依赖倒置原则********************");
                //    DIP.DIPShow.Show();
                //}
                //{
                //    Console.WriteLine("*******************接口隔离原则********************");
                //    ISP.ISPShow.Show();
                //}
                {
                    Console.WriteLine("*******************迪米特法则********************");
                    LOD.LODShow.Show();
                }
                //{
                //    Console.WriteLine("*******************里氏替换原则********************");
                //    OCP.OCPShow.Show();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
