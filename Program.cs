using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___Lambda_Expression
{
    /* Now we will discuss about Anonymous Function or Anonymous Method, an anonymous function is one where instead of a 
       method getting called inside the class, it can directly be called in the main function with the help of a delegate,
       The anonymous method does not have any name, and using the delegate keyword it is declared in the main function 
    
       Some features of anonymous function:
       1) The anonymous function is used for small codes.
       2) The anonymous function does not use access specifiers and is not a static and instance member.
       3) Also,the anonymous function has no return type, and is dependent on the return type of the delegate directly.
       4) Also the anonymous function cannot contain jump statements like goto,continue or break statements.
       5) Also the anonymous function can be passed as a parameter.*/


    public delegate void MyDelegate(int num); // Here I have declared a delegate, by defining a name as MyDelegate and the parameter I have set as of integer datatype 
    class Program
    { 
        //public static void MyMethod(int a) // Here, inside the class named Program I have declared a method named as MyMethod by defining a datatype of type integer 
        //{
        //    a += 10;   // After invoking the value from the main function which is 510, the instructions inside the MyMethod() , will execute and return the value of a  
        //    Console.WriteLine(a); // Final value of a is achieved as 520

        //} 
    
        static void Main(string[] args) // Main Function
        {
            MyDelegate objd2 = delegate(int a) // Here the Anonymous Function has been declared and a parameter as that of the same type as the delegate has been set
            {
                a += 10; // Inside the anonymous function, the instructions are defined  
                
                Console.WriteLine(a);  // Final value is being printed

                // return a; /* When a return type is defined in the delegate */
            };
            // Console.WriteLine(objd2.Invoke(5)); /* When a return type is defined in the delegate */

            objd2.Invoke(5); // Here, the value of the delegate is being passed and the anonymous function is being used as a reference
        }

    }
}