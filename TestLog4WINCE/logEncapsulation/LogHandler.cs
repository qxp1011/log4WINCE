using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using log4net.Config;
using System.IO;
using System.Runtime.InteropServices;

namespace logEncapsulation
{
    class LogHandler : ILog
    {

        #region 获取当前程序的根目录
        private string NativeEntryAssemblyLocation
        {
            get
            {
                StringBuilder moduleName = null;

                IntPtr moduleHandle = GetModuleHandle(IntPtr.Zero);

                if (moduleHandle != IntPtr.Zero)
                {
                    moduleName = new StringBuilder(255);
                    if (GetModuleFileName(moduleHandle, moduleName, moduleName.Capacity) == 0)
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    return string.Empty;
                }

                return moduleName.ToString();
            }
        }
        #endregion

        [DllImport("CoreDll.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern IntPtr GetModuleHandle(IntPtr ModuleName);

        [DllImport("CoreDll.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern Int32 GetModuleFileName(
            IntPtr hModule,
            StringBuilder ModuleName,
            Int32 cch);


        LogType _type = LogType.Info;

        public LogHandler(LogType type)
        {
            _type = type;
        }



        public LogHandler()
        {
            // log4net.Config.XmlConfigurator(configFile = "log4net.config", watch = true);
        }

        #region ILog 成员

        public void Write(LogType type, string module, string eventname, string message, Exception ex)
        {
            try
            {
                log4net.ILog logger = null;
                //**********************************************
                //邱小平
                //原因log4读取不到根目录下的StartForm.exe.config文件，修改此处可以实现
                //时间：2013/06/07
                string xmlPath=this.NativeEntryAssemblyLocation;
                if (!string.IsNullOrEmpty(xmlPath))
                {
                    FileInfo fI = new FileInfo(xmlPath+".config");

                    XmlConfigurator.Configure(fI);
                }
                //
                //*****************************************

                switch (type)
                {

                    case LogType.Info:
                        logger = log4net.LogManager.GetLogger("Info");
                        logger.Info("Module:" + module + ",eventname:" + eventname + ",MSG:" + message, ex);
                        break;

                    case LogType.Error:
                        logger = log4net.LogManager.GetLogger("Error");
                        logger.Error("Module:" + module + ",eventname:" + eventname + ",MSG:" + message, ex);
                        break;

                    case LogType.Debug:
                        logger = log4net.LogManager.GetLogger("Debug");
                        logger.Debug("Module:" + module + ",eventname:" + eventname + ",MSG:" + message, ex);
                        break;

                    case LogType.Warn:
                        logger = log4net.LogManager.GetLogger("Warn");
                        logger.Warn("Module:" + module + ",eventname:" + eventname + ",MSG:" + message, ex);
                        break;

                    case LogType.Fatal:
                        logger = log4net.LogManager.GetLogger("Fatal");
                        logger.Fatal("Module:" + module + ",eventname:" + eventname + ",MSG:" + message, ex);
                        break;

                    case LogType.Success:
                        logger = log4net.LogManager.GetLogger("Success");
                        logger.Info("Module:" + module + ",eventname:" + eventname + ",Success:" + message, ex);
                        break;

                    case LogType.Fail:
                        logger = log4net.LogManager.GetLogger("Fail");
                        logger.Info("Module:" + module + ",eventname:" + eventname + ",Fail:" + message, ex);
                        break;

                    case LogType.Default:
                        logger = log4net.LogManager.GetLogger("Default");
                        logger.Info("Module:" + module + ",eventname:" + eventname + ",Default:" + message, ex);
                        break;
                }
            }
            catch (System.Exception ex2)
            {
                string s = ex2.Message;

            }


        }

        public void Write(LogType type, string module, string message, Exception ex)
        {
            Write(type, module, "None", message, ex);
        }

        public void Write(LogType type, string message, Exception ex)
        {
            Write(type, "None", "None", message, ex);
        }

        public void Write(LogType type, string message)
        {
            Write(type, "None", "None", message, null);
        }

        public void Write(LogType type, Exception ex)
        {
            Write(type, "None", "None", "no message", ex);
        }

        public void Write(string module, string eventname, string message, System.Exception ex)
        {
            Write(_type, module, eventname, message, ex);
        }

        public void Write(string module, string message, System.Exception ex)
        {
            Write(_type, module, "None", message, ex);
        }

        public void Write(string message, System.Exception ex)
        {
            Write(_type, "None", "None", message, ex);
        }

        public void Write(Exception ex)
        {
            Write(_type, "None", "None", "no message", ex);
        }

        public void Write(string message)
        {
            Write(_type, "None", "None", message, null);
        }

        #endregion
    }
}
