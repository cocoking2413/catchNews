using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace runtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.code_text.Text) || string.IsNullOrWhiteSpace(this.main_text.Text) || string.IsNullOrWhiteSpace(this.class_text.Text)) return;

            //创建编译器和参数
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();

            //参数引用外部dll
            // Reference to System.Drawing library
            parameters.ReferencedAssemblies.Add("System.Drawing.dll");
            // True - memory generation, false - external file generation
            parameters.GenerateInMemory = true;
            // True - exe file generation, false - dll file generation
            parameters.GenerateExecutable = true;

            //编译组件
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, this.code_text.Text);
            //检查错误
            if (results.Errors.HasErrors)
            {
                StringBuilder sb = new StringBuilder();
                foreach (CompilerError error in results.Errors)
                {
                    sb.AppendLine(string.Format("Error {0}:{1}", error.ErrorNumber, error.ErrorText));
                }
                MessageBox.Show(sb.ToString());
                return;
            }

            //获取编译程序集类型和main方法
            Assembly assembly = results.CompiledAssembly;
            Type program = assembly.GetType(this.class_text.Text);
            MethodInfo main = program.GetMethod(this.main_text.Text);

            main.Invoke(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static MethodInfo CreateFunction(string function)
        {
            string code = @"
                            using System;
            
                            namespace UserFunctions
                            {                
                                public class BinaryFunction
                                {                
                                    public static double Function(double x, double y)
                                    {
                                        return func_xy;
                                    }
                                }
                            }
                        ";

            string finalCode = code.Replace("func_xy", function);

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerResults results = provider.CompileAssemblyFromSource(new CompilerParameters(), finalCode);

            Type binaryFunction = results.CompiledAssembly.GetType("UserFunctions.BinaryFunction");
            return binaryFunction.GetMethod("Function");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MethodInfo function = CreateFunction(this.code_text.Text);
                var betterFunction = (Func<double, double, double>)Delegate.CreateDelegate(typeof(Func<double, double, double>), function);
                MessageBox.Show(betterFunction(2, 3).ToString());
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
