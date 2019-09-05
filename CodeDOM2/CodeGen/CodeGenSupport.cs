using CodeDOM2.Domain;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeDOM2.CodeGen
{
    public class CodeGenSupport
    {
        public List<CodeMemberField> GenerateProperties(List<ClassPropsDesc> classDescriptot)
        {
            List<CodeMemberField> properties = new List<CodeMemberField>();
            foreach (var prop in classDescriptot)
            {
                CodeMemberField field = new CodeMemberField
                {
                    Attributes = MemberAttributes.Public | MemberAttributes.Final,
                    Name = prop.Name,
                    Type = new CodeTypeReference(prop.PropType),
                };
                field.Name += " { get; set; }"; //credits: https://stackoverflow.com/questions/13679171/how-to-generate-empty-get-set-statements-using-codedom-in-c-sharp

                properties.Add(field);
            }
            return properties;
        }

        internal void AddPropertiesToClass(CodeTypeDeclaration @class, List<CodeMemberField> properties)
        {
            foreach (var prop in properties)
            {
                @class.Members.Add(prop);
            }
        }

        internal string GetDtoClassName(string className)
        {
            return className + "DTO";
        }

        internal List<ClassPropsDesc> AddPropsToClassPropsObj(PropertyInfo[] objProps)
        {
            List<ClassPropsDesc> classProps = new List<ClassPropsDesc>();
            foreach (var item in objProps)
            {
                classProps.Add(new ClassPropsDesc(name: item.Name, propType: item.PropertyType.ToString()));
            }

            return classProps;
        }
    }
}
