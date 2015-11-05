using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.Loger;
namespace LogerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (var i = 0; i < 100;i++ )
            {
                LogerManager.Current.AsyncInfo(string.Format("log:{0}",i));
            }
            Console.ReadKey();
        }
    }
}
