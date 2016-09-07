using DotLiquid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*********************************************************
 * 开发人员：王可
 * 创建时间：2016-08-30 17:29:19
 * 最近更新：$updateTime$
 * 描述说明：
 * 
 * 
 *
 * *******************************************************/
namespace codeTemplate
{

    public static class LiquidFunctions
    {
        public static void RegisterViewModel(Type rootType)
        {
            rootType
                .Assembly
                .GetTypes()
                .Where(t => t.Namespace == rootType.Namespace)
                .ToList()
                .ForEach(RegisterSafeTypeWithAllProperties);
        }

        public static void RegisterSafeTypeWithAllProperties(Type type)
        {
            Template.RegisterSafeType(type,
                type
                    .GetProperties()
                    .Select(p => p.Name)
                    .ToArray());
        }

        public static string RenderViewModel(this Template template, object root)
        {
            return template.Render(
                Hash.FromAnonymousObject(root));
        }
    }
}
