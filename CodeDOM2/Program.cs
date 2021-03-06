﻿using CodeDOM2.CodeGen;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDOM2
{
    class Ciccio
    {
        public int val { get; set; }
        public string name { get; set; }
        public int valN;
    }

    //Example usage
    class Program
    {
        static void Main(string[] args)
        {
            Ciccio c = new Ciccio();

            CodeGenerator<Ciccio> convObjCreator = new CodeGenerator<Ciccio>();
            string myClass = convObjCreator.AutogenerateDTO(new Ciccio());

            File.WriteAllText("MyClass.cs", myClass);
           

        }
    }
}
