using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Framework.Console
{
    /// <summary>
    /// 1 深度解析.NetFrameWork/CLR/C# ，C#6/C#7新语法，理解.NetCore
    /// 2 Asp.Net Core2.2解读，MVC6应用、Session组件支持
    /// 3 Asp.NetCore发布，IIS部署，配置文件读取，Log4Net整合
    /// 
    /// 欢迎大家来到.Net 高级班的Vip课程，我是Richard 老师；
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                System.Console.WriteLine("欢迎大家来到.Net 高级班");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                throw;
            }

            System.Console.Read();
        }
    }
}
