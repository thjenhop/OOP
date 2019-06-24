using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OverWriteCShape
{
    interface I
    {
        void M();
    }

    abstract class C : I
    {
        public abstract void M();
    }

    public abstract class Shape
    {
        public abstract int GetArea();
    }
    
    public class Square : Shape
    {
        public int a;

        public Square(int n) => a = n;
        // funtional programing CShape

        public override int GetArea() => a * a;

    }

}
