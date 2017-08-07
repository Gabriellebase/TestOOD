using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOD
{
    public class TestClass
    {
        public static int staticMember = 99;
        public int objectMember = 88;

        public bool GetObjectMember()
        {
            Console.WriteLine("获得实例成员："+this.objectMember);
            Console.WriteLine("获得静态成员：" + TestClass.staticMember);
            return true;
        }
    }
}
