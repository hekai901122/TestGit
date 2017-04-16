using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = "宋青青傻B";

            cc = "宋青青是个大傻B";

            Program pm = new Program();
            var tm = pm.GetUser();
        }

        /// <summary>
        /// 获取用户
        /// </summary>
        /// <returns></returns>
        public TestModult GetUser()
        {
            TestModult tm = new TestModult();
            tm.UserName = "hekai";
            tm.Address = "湖北蕲春";
            var fs = "标杆 桂林";
            return tm;
        }
    }
}
