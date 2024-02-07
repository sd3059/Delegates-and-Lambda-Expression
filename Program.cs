using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___Lambda_Expression
{
    /* A delegate is used to reference any method that has the same signature as that of the delegate, 
       means like the reference of MyMethod can be stored in the object of MyDelegate */


    public delegate void MyDelegate(int num); // Here I have declared a delegate, by defining a name as MyDelegate and the parameter I have set as of integer datatype 
    class Program
    { 
        public static void MyMethod(int a) // Here, inside the class named Program I have declared a method named as MyMethod by defining a datatype of type integer 
        {
            a += 10;   // After invoking the value from the main function which is 510, the instructions inside the MyMethod() , will execute and return the value of a  
            Console.WriteLine(a); // Final value of a is achieved as 520

        } 
    
        static void Main(string[] args) // Main Function
        {
            MyDelegate objd1 = new MyDelegate(Program.MyMethod); // Here, the MyDelegate which I created earlier has declared an object named as objd1 
            //objd1.Invoke(510); // Here I am taking the value as 510
            objd1(510);  // Instead of using invoke method we can declare a value for the delegate object like this manner too     
        }

    }
}