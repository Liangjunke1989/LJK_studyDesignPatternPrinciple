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
    /// </summary>
    public class AnimalFish : Animal
    {
        public AnimalFish(string name) : base(name)
        {
        }
        public override void Breath()
        {
            Console.WriteLine($"{this._Name} 呼吸水");
        }

        public override void Action()
        {
            Console.WriteLine($"{this._Name} swimming");
        }
    }
}
