using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace logEncapsulation
{
    public static class LogFactory
    {
        public static ILog Create(LogType type)
        {
            ILog log = null;
            try
            {
                //switch (mode)
                //{
                //    case LogMode.Default:
                //    case LogMode.FlatFile:
                //        log = new logEncapsulation.LogFlatFile();
                //        break;

                //    case LogMode.Database:
                //        log = new logEncapsulation.LogDatabase();
                //        break;

                //    case LogMode.XML:
                //        log = new logEncapsulation.LogXml();
                //        break;

                //    default:
                //        log = new logEncapsulation.LogFlatFile();
                //        break;
                //}
                log = new LogHandler(type);
            }
            catch (Exception ex)
            {
                ExceptionFactory.Create().HandleException("Create Log Error:" + ex.Message);
            }
            return log;
        }

        /// <summary>
        /// 默认为info模式
        /// </summary>
        /// <returns></returns>
        public static ILog Create()
        {
            return Create(LogType.Info);
        }
    }
}
