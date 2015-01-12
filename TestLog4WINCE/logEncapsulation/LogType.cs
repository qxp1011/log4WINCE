using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logEncapsulation
{
    public enum LogType
    {
        Info,    //记录一般信息
        Error,   //记录一般错误日志
        Debug,   //专用于调试日志
        Warn,
        Fatal, 
        Success, //业务功能成功
        Fail,   //业务功能失败 
        Default, 
    }
}
