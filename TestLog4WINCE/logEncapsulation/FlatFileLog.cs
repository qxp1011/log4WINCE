using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;


namespace logEncapsulation
{
    /*
     说明：
     * 共3个方法，前2个可记录不同级别的日志信息
     * 第1个另可记录发生错误的模块及其ID标识
     * 第2个另可记录发生错误的模块
     * 最后一个直接使用info级别，只记录记录一般信息，无记录错误模块及ID功能
     */

    //class LogFlatFile:ILog
    //{
    //    public override void Write(LogType type, int eventId, string module, string message)
    //    {
    //        log4net.ILog logger = log4net.LogManager.GetLogger("file");
    //        LogUtility.LogEntrance(type, eventId, module, message, logger);
            
    //        switch (type)
    //        {
    //            case LogType.Default:
    //                logger.Info("发生模块：" + module + ",模块ID:" + eventId + "||" + message);
    //                break;

    //            case LogType.Error:
    //                logger.Error("发生模块：" + module + ",模块ID:" + eventId + "||" + message);
    //                break;

    //            case LogType.Info:
    //                logger.Info("发生模块：" + module + ",模块ID:" + eventId + "||" + message);
    //                break;

    //            case LogType.Fatal:
    //                logger.Fatal("发生模块：" + module + ",模块ID:" + eventId + "||" + message);
    //                break;

    //            case LogType.Debug:
    //                logger.Debug("发生模块：" + module + ",模块ID:" + eventId + "||" + message);
    //                break;
    //        }
    //    }

    //    public void Write(logEncapsulation.LogType type, string module, string message)
    //    {
    //        Write(type, -1, module, message);

    //        //log4net.ILog logger = log4net.LogManager.GetLogger("file");
    //        //switch (type)
    //        //{
    //        //    case LogType.Default:
    //        //        logger.Info("发生模块：" + module + "||" + message);
    //        //        break;

    //        //    case LogType.Error:
    //        //        logger.Error("发生模块：" + module + "||" + message);
    //        //        break;

    //        //    case LogType.Info:
    //        //        logger.Info("发生模块：" + module + "||" + message);
    //        //        break;

    //        //    case LogType.Fatal:
    //        //        logger.Fatal("发生模块：" + module + "||" + message);
    //        //        break;

    //        //    case LogType.Debug:
    //        //        logger.Debug("发生模块：" + module + "||" + message);
    //        //        break;
    //        //}
    //    }

    //    public void Write(LogType type, string message)
    //    {

    //        Write(type, -1, "", message);
    //    }

    //    public void Write(string message)
    //    {
    //        Write(LogType.Info, -1, "", message);

    //        //log4net.ILog logger = log4net.LogManager.GetLogger("file");
    //        ////log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    //        //logger.Info(message);
    //    }

    //}
}
