using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.SRP
{
    /// <summary>
    /// 封装
    /// 动物类
    /// 简单意味着稳定
    /// 
    /// 都塞在一起，多个职责都在一起
    /// </summary>
    public abstract class Animal
    {
        protected string _Name = null;
        public Animal(string name)
        {
            this._Name = name;
        }
        public abstract void Breath();
        //{
        //    if (this._Name.Equals("鸡"))
        //    {
        //    Console.WriteLine($"{this._Name} 呼吸空气");
        //}
        //    else if (this._Name.Equals("鱼"))
        //    {
        //    Console.WriteLine($"{this._Name} 呼吸水");
        //}
        ////。。
        //}

        //好多分支，好多固定分支，好多if else  三套东西
        //违背了单一职责：一个类只做一件事儿，，一个方法也应该只做一件事儿

        public abstract void Action();
        //if (this._Name.Equals("鸡"))
        //    {
        //    Console.WriteLine($"{this._Name} flying");
        //}
        //    else if (this._Name.Equals("鱼"))
        //    {
        //    Console.WriteLine($"{this._Name} swimming");
        //}
        }
}
