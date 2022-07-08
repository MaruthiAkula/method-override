﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_override
{
    public class Baseclass
    {
      public virtual void print()
        {
            Console.WriteLine("I'm a Base Classsss");
        }
    }
    public class Derivedclass:Baseclass
    {
        public override void print()
        {
            Console.WriteLine("I'm a Derived Cls");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Baseclass Obj = new Derivedclass();
            Obj.print();


        }
    }
}
