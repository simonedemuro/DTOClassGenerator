using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDOM2.Domain
{
    public class ClassPropsDesc
    {
        public string Name { get; set; }
        public string PropType { get; set; }

        public ClassPropsDesc()
        {

        }

        public ClassPropsDesc(string name, string propType)
        {
            Name = name;
            PropType = propType;
        }
    }
}
