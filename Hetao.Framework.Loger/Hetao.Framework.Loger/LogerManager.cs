using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hetao.Framework.Loger
{
    public class LogerManager
    {
        private static ILoger _loger;

        public static ILoger Current
        {
            get {
                //线程同步
                lock (_loger)
                {
                    if (_loger == null)
                    {
                        _loger = new FileLoger();
                    }
                    return _loger;
                }
            }
            set
            {
                lock (_loger)
                {
                    _loger = value;
                }
            }
        }


    }
}
