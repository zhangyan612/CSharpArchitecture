using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpArchitecture.Basic.AbstractClass.Shapes
{
    abstract class Shape
    {
        public string Name { get; set; }

        // You can define non-abstract
        // methods in an abstract class
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        // We want subclasses to override
        // this method so mark it as abstract
        // You can only make abstract methods 
        // in abstract classes
        public abstract double Area();


        // An abstract function cannot have functionality. You're basically saying, 
        // any child class MUST give their own version of this method,
        // however it's too general to even try to implement in the parent class.

        // A virtual function, is basically saying look, here's the functionality that may or may not be good enough for the child class. 
        // So if it is good enough, use this method, if not, then override me, and provide your own functionality.


    }
}