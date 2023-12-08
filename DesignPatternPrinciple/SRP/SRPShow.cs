using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.SRP
{
    /// <summary>
    /// 单一职责原则：类T负责两个不同的职责：职责P1，职责P2。当由于职责P1需求发生改变而需要修改类T时，
    /// 有可能会导致原本运行正常的职责P2功能发生故障。
    /// 
    /// 一个类只负责一件事儿
    /// 拆分之后，职责变得单一
    /// 阅读简单，易于维护；
    /// 扩展升级，减少修改，直接增加类；
    /// 方便代码重用的；
    /// 简单--稳定--强大
    /// 
    /// 单一职责的成本：类变多了；上端需要了解更多的类
    /// 
    /// 衡量着使用：如果类相对稳定，扩展变化少，而且逻辑简单，违背单一职责也没关系
    ///             一个类不要让他太“累” 
    ///             如果不同的职责，总是一起变化，这种是一定要分开的
    ///             
    /// 步尘：代码足够简单，就可以稍稍违背
    /// 
    /// 方法：方法多个分支，还可能扩展变化，最好拆分成多个方法
    ///   类：接受输入-数据验证-逻辑计算--数据库操作--日志  为了重用，方便维护升级
    /// 接口：也会把不同的功能接口，独立开来
    /// 类库：把项目拆分成多个类库，重用--方便维护--
    /// 项目：一个web解决所有问题：客户端；管理后台；定时服务；远程接口；  还是要拆分
    /// 系统：成熟互联网企业，有N多项目，有很多重复功能，IP库/日志库/监控系统/在线统计。。。
    /// 
    /// </summary>
    public class SRPShow
    {
        public static void Show()
        {
            {
                Animal animal = new AnimalChicken("鸡");
                animal.Breath();
                animal.Action();
            }
            {
                Animal animal = new AnimalFish("鱼");//呼吸水
                animal.Breath();
                animal.Action();
            }
            //{
            //    Animal animal = new Animal("蚯蚓");//呼吸泥土
            //    animal.Breath();
            //    animal.Action();
            //}
        }
    }
}
