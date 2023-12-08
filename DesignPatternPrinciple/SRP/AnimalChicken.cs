using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.SRP
{
    /// <summary>
    /// 每个类做自己的事儿
    /// </summary>
    public class AnimalChicken : Animal
    {
        public AnimalChicken(string name) : base(name)
        {
        }
        public override void Breath()
        {
            Console.WriteLine($"{this._Name} 呼吸空气");
        }

        public override void Action()
        {
            Console.WriteLine($"{this._Name} flying");
        }
    }
}
