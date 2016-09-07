using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*********************************************************
 * 开发人员：王可
 * 创建时间：2016-08-31 11:47:34
 * 最近更新：$updateTime$
 * 描述说明：
 * 
 * 
 *
 * *******************************************************/
namespace razorTest
{
    public static class Help
    {
        public static bool IsPath(this string path)
        {
            if (Directory.Exists(path))
                return true;
            else
            {
                try
                {
                    Directory.CreateDirectory(path);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        } 
    }
}
