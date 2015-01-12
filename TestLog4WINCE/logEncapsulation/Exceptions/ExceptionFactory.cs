using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logEncapsulation
{
    public static class ExceptionFactory
    {
        /// <summary>
        /// 根据mode创建不同的异常处理模式
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static IException Create(logEncapsulation.ExceptionMode mode)
        {
            IException exception = null;
            try
            {
                switch (mode)
                {
                    case ExceptionMode.Default:
                        exception = new logEncapsulation.ExceptionDefault();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception("Create Exception Error:" + ex.Message);
            }
            return exception;                    
        }

        /// <summary>
        /// 创建默认异常处理模式
        /// </summary>
        /// <returns></returns>
        public static IException Create()
        {
            return Create(ExceptionMode.Default);  
        }
    }
}
