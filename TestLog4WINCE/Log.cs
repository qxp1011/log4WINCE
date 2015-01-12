using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using logEncapsulation;

namespace LogLayer
{
    public class Log
    {
        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="msg"></param>
        public static void Write(Exception msg)
        {
            try
            {
                //调用log4写日志
                LogE._log.Write(msg);
            }
            catch (Exception)
            {

            }
        }
    }
}
