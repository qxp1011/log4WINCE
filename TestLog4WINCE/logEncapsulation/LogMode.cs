using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logEncapsulation
{
    public enum LogMode
    {
        Default,   //default使用数据库
        FlatFile,  //文件
        Database,  //数据库
        XML,       //xml
        EventLog,
        Email     //暂不使用，需要时添加 
    }
}
