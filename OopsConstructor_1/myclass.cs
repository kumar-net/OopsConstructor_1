using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OopsConstructor_1
{
    internal class myclass
    {
        // Constructor name should be same as class name.
        // Constructor will not return any value due to that reason it will not have any return
        /*  <access modifier><class name ()>
             {
               // initialization
             }  */

        int a;//Here We are declaring instance variable only or non static variable
        int b;//instance variable as well as state as well as data member these are all same only
        public myclass()//here we are crating a constructor because of assigning values to the instance variables dirctly at the time of creating object
        {
            Console.WriteLine("constructor is calling");
            a = 10;
            b = 20;
        }
        public void display()
        {
            Console.WriteLine("a is:" + a);
            Console.WriteLine("b is:" + b);
        }
    }
}
