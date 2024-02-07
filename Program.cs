using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___Lambda_Expression
{ 

    public delegate void MyDelegate(int num); // Here I have declared a delegate, by defining a name as MyDelegate and the parameter I have set as of integer datatype 
    class Program
    { 
        public static void MyMethod(MyDelegate del, int a) // Here in the MyMethod function we are declaring del as a parameter of the MyDelegates, and the function or method of it's reference is  an anonymous function
        {
            a += 10; // Instruction defined and anything the value of a is, it will be incremented with 10    

            del.Invoke(a); // Here, the value of a will be invoked in the anonymous function and further execution will be done inside the anonymous function as per the value recieved

        } 
    
        static void Main(string[] args) // Main Function
        {
            Program.MyMethod(delegate (int b) { b += 10; Console.WriteLine(b); }, 5); // Here we can observe that the anonymous fuction has been passed as a parameter in the MyMethod Function
            Console.ReadLine();
        }
        
    }
}