using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.LOD
{
    /// <summary>
    /// 学校
    /// </summary>
    public class School
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public List<Class> ClassList { get; set; }

        public void Manage()
        {
            Console.WriteLine("Manage {0}", this.GetType().Name);
            foreach (Class c in this.ClassList)
            {
                Console.WriteLine(" {0}Manage {1} ", c.GetType().Name, c.ClassName);
                c.Manage();//班级自己管理学生 1

                //List<Student> studentList = c.StudentList;//找到学生，学校管理 2
                //foreach (Student s in studentList)
                //{
                //    Console.WriteLine(" {0}Manage {1} ", s.GetType().Name, s.StudentName);
                //}
                //如果足够简单，2也没问题
            }
        }


    }
}
