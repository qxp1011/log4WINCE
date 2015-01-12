#region 
/****************************************************************************************************
 * Library
 * Author: 				邱小平
 * Class description:   log4Net接口二次封装
 * Creation date:       2011-07-22
 ====================================================================================================
  
 ****************************************************************************************************/
#endregion


namespace logEncapsulation
{

    public class LogE
    {
        public static ILog _log = LogFactory.Create();
    }


    public interface ILog
    {

        /// <summary>
        /// 写入日志,取日志类型,事件ID,模块等信息
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="module"></param>
        /// <param name="message"></param>
        void Write(LogType type, string module,string eventname, string message, System.Exception ex);

        void Write(LogType type, string module, string message, System.Exception ex);

        void Write(LogType type, string message, System.Exception ex);

        void Write(LogType type, string message);

        void Write(LogType type, System.Exception ex);

        void Write(string module,string eventname, string message, System.Exception ex);

        void Write(string module, string message, System.Exception ex);

        void Write(string message, System.Exception ex);

        void Write(System.Exception ex);

       // void Write(string modulename, string eventname, string message, System.Exception ex);

        /// <summary>
        /// 写入日志,其他参数全部使用默认值
        /// </summary>
        /// <param name="message"></param>
        void Write(string message);
    }
}




#region LOG4配置文件参考

/*
<?xml version="1.0"?>
<configuration>
  
    <startup>
      <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.0"/>
    </startup>


  <configSections>
    <section name="log4net"
     type="log4net.Config.Log4NetConfigurationSectionHandler,log4net-net-1.2.11.0" />
  </configSections>

  <log4net>
    <root>
      <level value="ALL" />

      <!--<appender-ref ref="RollingLogFileAppender" />-->
      <appender-ref ref="RollingFileAppender" />      
      <!--<appender-ref ref="LogFileAppender" />-->
    </root>


    <!--按照日期格式建立日志文件-->
    <!--<appender name="RollingLogFileAppender" type="log4net.Appender.RollingFileAppender">
      <file value="Log\logfile.txt" />
      <appendToFile value="true" />
      <rollingStyle value="Date" />
      <datePattern value="yyyyMMdd-HHmm" />
      --><!--<datePattern value="yyyyMMdd" />--><!--
      <layout type="log4net.Layout.PatternLayout">
        <conversionPattern value="%d %r [%t]%-5p %c - %m%n" />
      </layout>
    </appender>-->




    <!--按文件大小与个数建立日志文件-->
    <appender name="RollingFileAppender" type="log4net.Appender.RollingFileAppender">
      <file value="Log\log.txt" />
      <appendToFile value="true" />
      <rollingStyle value="Size" />
      <maxSizeRollBackups value="100" />
      <maximumFileSize value="1024KB" />
      <staticLogFileName value="true" />
      <layout type="log4net.Layout.PatternLayout">
        <!--<conversionPattern value="%date [%thread] %-5level %logger [%property{NDC}] - %message%newline" />-->
        <conversionPattern value="%d %r [%t]%-5p %c - %m%n" />
      </layout>
    </appender>




    <!--<appender name="LogFileAppender" type="log4net.Appender.FileAppender" > 
      
      <param name="AppendToFile" value="true" />
      <param name="File" value="Log\log.txt" />  
      --><!--<param name="rollingStyle" value="Date"/>
      <param name="datePattern" value="yyyyMMdd"/>--><!--  

      <layout type="log4net.Layout.PatternLayout">
        --><!--<param name="ConversionPattern" value="%d %L %d %m %r %c %n" />--><!--
        <param name="ConversionPattern" value="%d %r [%t]%-5p %c - %m%n" />  
        --><!--%m(message):输出的日志消息，如ILog.Debug(…)输出的一条消息

        %n(new line):换行

        %d(datetime):输出当前语句运行的时刻

        %r(run time):输出程序从运行到执行到当前语句时消耗的毫秒数

        %t(thread id):当前语句所在的线程ID

        %p(priority): 日志的当前优先级别，即DEBUG、INFO、WARN…等

        %c(class):当前日志对象的名称，例如：

        模式字符串为：%-10c -%m%n

        代码为：

        ILog log=LogManager.GetLogger(“Exam.Log”);

        log.Debug(“Hello”);

        则输出为下面的形式：

        Exam.Log       - Hello

        %L：输出语句所在的行号

        %F：输出语句所在的文件名

        %-数字：表示该项的最小长度，如果不够，则用空格填充

        例如，转换模式为%r [%t]%-5p %c - %m%n 的 PatternLayout 将生成类似于以下内容的输出：

        176 [main] INFO  org.foo.Bar - Located nearest gas station.--><!-- 
      </layout>
    </appender>-->  
  </log4net> 
  </configuration>
*/
#endregion LOG4配置文件参考