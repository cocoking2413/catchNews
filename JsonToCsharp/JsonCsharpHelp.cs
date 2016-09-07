using Xamasoft.JsonClassGenerator;
using Xamasoft.JsonClassGenerator.CodeWriters;

/*********************************************************
 * 开发人员：王可
 * 创建时间：2016-09-01 18:37:04
 * 最近更新：$updateTime$
 * 描述说明：
 * 
 * 
 *
 * *******************************************************/
namespace JsonToCsharp
{
    public static class JsonCsharpHelp
    {
        private readonly static ICodeWriter[] CodeWriters = new ICodeWriter[] {
            new CSharpCodeWriter(),
            new VisualBasicCodeWriter(),
            new TypeScriptCodeWriter(),
          //  new JavaCodeWriter()
        };
        public static JsonClassGenerator Prepare(string json,string classname,string namespacestr)
        {
            //找到服务器物理路径  
            string serverAppPath = System.Windows.Forms.Application.StartupPath;
            //string serverAppPath = @"d:\";
            //构成配置文件路径  
            string con_file_path = @"" + serverAppPath + @"\public\temp";

            var gen = new JsonClassGenerator();
            gen.Example =json;
            gen.CodeWriter =new CSharpCodeWriter();
            gen.ExplicitDeserialization = false;
            gen.Namespace = namespacestr;
            gen.NoHelperClass =true;
            gen.SecondaryNamespace =null;
            gen.TargetFolder = con_file_path;
            gen.UseProperties = true;
            gen.MainClass = classname;
            gen.UsePascalCase =true;
            gen.UseNestedClasses =false;
            gen.ApplyObfuscationAttributes = false;
            gen.SingleFile =false;
            gen.ExamplesInDocumentation = false;
            return gen;
        }

        public static bool IsEmpty(this string str)
        {
			if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str)) return true;
            return false;
        }
    }
}
