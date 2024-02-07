using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___Lambda_Expression
{

    /* So, a lambda expression is a simplified form of the anonymous function, where we simplify the code, thus making the code more 
       efficient and understandable, here we use the lambda operator '=>', and to the left side of it is the parameter or input
       part and the right side of it is the statement or expression part, so the statement part is defined by '{}' where multiple 
       instructions we have to define, and in case of the expression only one line is defined. This statement & expression lambda
       are the two types of lambda-expression. */

    //public delegate int MyDelegate(int num); // A delegate has been defined with the name as MyDelegate, and the signature has been defined as an integer datatype 

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        MyDelegate objd3 = (a) => a * a; // This is expression lambda, as only a single statement is defined for the lambda-expression
    //        MyDelegate objd4 = (a) => a * a * a; // Also multiple single statements can be defined 
    //        Console.WriteLine(objd4.Invoke(5)); // Printing the final value

    //        MyDelegate objd3 = (a) => // An lambda operator has been defined, which is basically the simplified form of anonymous function 
    //        {
    //            a *= 5; // This is the statement lambda type, where multiple instructions are defined.
    //            Console.WriteLine(a);
    //            // return a; // when the delegate is defined witha return type
    //        };
    //        Console.WriteLine(objd3.Invoke(5)); // This is when a return type is defined in the delegate
    //        objd3.Invoke(5);
    //        Console.ReadLine();
    //    }

    //}

    public delegate int MyDelegate(int num1, int num2); // Here two parameters are declared in the delegate

    /* Returns the evaluated value implicitly */
    class Program1
    {
        static void Main(string[] args)
        {
            MyDelegate objd5 = (a, b) => a + b; // Here multiple values can be declared and operations can be performed on it using expression-lambda
            Console.WriteLine(objd5.Invoke(10,20)); // Printing the final result
            Console.ReadLine(); //Instruction to hold the console window
        }

    }
}