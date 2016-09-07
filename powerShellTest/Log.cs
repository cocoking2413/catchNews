using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
/*********************************************************
 * 开发人员：王可
 * 创建时间：2016-08-31 9:50:18
 * 最近更新：$updateTime$
 * 描述说明：
 * 
 * 
 *
 * *******************************************************/
namespace powerShellTest
{
   public class Log
    {
       private static ILog log = LogManager.GetLogger("myLogger");

       public static void WriteLog(string str)
       {
           if (log.IsDebugEnabled)
           {
               log.Debug(str);
           }
       }
    }
}
