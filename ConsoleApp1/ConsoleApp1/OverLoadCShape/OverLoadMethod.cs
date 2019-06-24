using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OverLoadCShape
{
    class OverLoadMethod
    {
        public int Add(int x)
        {
            return 0;
        }

        // 2 method is invalid for overload method in CShape - Java


        //int Add(int x)
        //{
        //    return 0;
        //}
        //public int Add(int x)
        //{
        //    return 0;
        //}
        public int Add(int x, int y)
        {
            return 0;
        }
        // CShape overload : same 
        //+ Datatype return 
        //+ MethodName
       
    }
}
