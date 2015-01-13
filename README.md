# log4WINCE
log4WINCE

跨平台的日志工具，修改了几行，移植到WINCE平台上。修改内容如下：

让log4，能读取根目录下的StartForm.exe.config，StartForm为程序的入口exe文件名。
	修改文件地址：logEncapsulation/ LogHandler.cs
public void Write(LogType type, string module, string eventname, string message, Exception ex)方法中
操作：在代码log4net.ILog logger = null;后添加如下代码
string xmlPath=this.NativeEntryAssemblyLocation;
                if (!string.IsNullOrEmpty(xmlPath))
                {
                    FileInfo fI = new FileInfo(xmlPath+".config");
                    XmlConfigurator.Configure(fI);
                }

写日志，log4默认在程序根目录下建立log.txt文件，或者根据conifg配置在根目录下建立相应的文件路径。要想实现在其他目录下新建日志，我修改了log4的源代码。	
        修改文件地址：Log4WINCE/ Util/ SystemInfo.cs/
         932行的public static string ConvertToFullPath(string path)方法中string applicationBaseDirectory = SystemInfo.ApplicationBaseDirectory;
修改为 string applicationBaseDirectory =@"\NandFlash\";
这样log4写的日志是以NandFlash为根目录写的。
如果WINCE的文件夹地址不一致，直接修改源码重新编译即可。



经测试可用。
配置文件见TestLog4WINC中的TestLog4WINCE.exe.config。
使用时引用到项目，配置文件复制到TestLog4WINCE.exe.config即可。


