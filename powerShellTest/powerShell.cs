using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;

/*********************************************************
 * 开发人员：王可
 * 创建时间：2016-08-31 9:41:09
 * 最近更新：$updateTime$
 * 描述说明：
 * 
 * 
 *
 * *******************************************************/
namespace powerShellTest
{
   public class powerShell
    {
        public static string RunScript(string scriptText)
        {
            try
            {
                // create Powershell runspace  

                Runspace runspace = RunspaceFactory.CreateRunspace();

                // open it  

                runspace.Open();

                // create a pipeline and feed it the script text  

                Pipeline pipeline = runspace.CreatePipeline();

                pipeline.Commands.AddScript(scriptText);

                pipeline.Commands.Add("Out-String");

                // execute the script  

                Collection<PSObject> results = pipeline.Invoke();

                // close the runspace  

                runspace.Close();

                // convert the script result into a single string  

                StringBuilder stringBuilder = new StringBuilder();

                foreach (PSObject obj in results)
                {

                    stringBuilder.AppendLine(obj.ToString());

                }

                return stringBuilder.ToString();
            }
            catch (Exception ex) {
                Log.WriteLog(DateTime.Now.ToString() + "日志记录:执行ps命令异常：" + ex.Message);
                return ex.Message;
            }

        }
        public string RunScript(List<string> scripts)
        {
            try
            {
                Runspace runspace = RunspaceFactory.CreateRunspace();
                runspace.Open();
                Pipeline pipeline = runspace.CreatePipeline();
                foreach (var scr in scripts)
                {
                    pipeline.Commands.AddScript(scr);
                }
                //返回结果     
                var results = pipeline.Invoke();
                runspace.Close();

                StringBuilder stringBuilder = new StringBuilder();

                foreach (PSObject obj in results)
                {

                    stringBuilder.AppendLine(obj.ToString());

                }

                return stringBuilder.ToString();

            }
            catch (Exception e)
            {
                Log.WriteLog(DateTime.Now.ToString() + "日志记录:执行ps命令异常：" + e.Message);
                return e.Message;
            }
        }  
    }
}
