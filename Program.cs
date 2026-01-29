using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;

namespace task03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // // string input = Console.ReadLine();
            // string input=null;
            // // int num = int.Parse(input);
            // int num= Convert.ToInt32(input);
            // Console.WriteLine(num);
            //when handling null inputs , parse cause it is very strict and parse strings only it throws an exception,
            //however Convert function designed to return the default value when the input is null (for int it returns 0)
            #endregion

            #region Q2
            // Console.Write("enter a  number: ");
            // string input = Console.ReadLine();
            // bool valid = int.TryParse(input, out int res);
            // Console.WriteLine(valid ? res : "invalid number");
            // //try parse handels invalid inputs without throwing any exception
            #endregion

            #region Q3
            // Object obj1 = 5;
            // Object obj2 = 5.2;
            // Object obj3 = "Youssef";
            // Console.WriteLine(obj1.GetHashCode());
            // Console.WriteLine(obj2.GetHashCode());
            // Console.WriteLine(obj3.GetHashCode());
            // //returns a numeric identifire for an object for effcient storing and retrieving objects based on thier hashcodes 
            #endregion

            #region Q4
            // Point p1 = new Point();
            // Point p2 = p1;
            // p1.x = 10;
            // Console.WriteLine(p2.x);
            // p1.x = 101;
            // Console.WriteLine(p2.x);
            // //its base role so that making two references refering to the same object in the memory instead of coping the same object
            // //and change to any ref will affect the other --> optimize preformance
            #endregion

            #region Q5
            // string str = "hey, ";
            // Console.WriteLine(str.GetHashCode());
            // str += "Hi Willy";
            // Console.WriteLine(str.GetHashCode());
            // //hashcodes are not the same , cause strings are immutable , cause it is composed of arry of charechter (fixed size)
            // //therefore when modifying the string a new object created in the memory , with a different hashcode
            #endregion

            #region Q6
            // StringBuilder str = new StringBuilder("hey ,");
            // Console.WriteLine(str.GetHashCode());
            // str.Append("Hi Willy");
            // Console.WriteLine(str.GetHashCode());
            // //string bulider allow modifying the same object (mutable) 
            // // cause it is internally made of linked list which allows size changing
            #endregion

            #region Q7
            //t is a mutable class, allowing modifications to an existing object in the memory rather than creating new one
            #endregion

            #region Q8
            // Console.Write("Enter the first number: ");
            // int num1 = int.Parse(Console.ReadLine());
            // Console.Write("Enter the second number: ");
            // int num2 = int.Parse(Console.ReadLine());
            // string msg1 = "res: " + num1 + " + " + num2 + " = " + (num1 + num2);
            // Console.WriteLine(msg1);
            // string msg2 = string.Format("res : {0} + {1} = {2}", num1, num2, (num1 + num2));
            // Console.WriteLine(msg2);
            // string msg3 = $"res: {num1} + {num2} = {num1 + num2} ";
            // Console.WriteLine(msg3);
            // //interpolation is the most used one , improves readability
            #endregion

            #region Q9
            // StringBuilder str= new StringBuilder("Youssef");
            // Console.WriteLine(str);
            // str.Append(" Ayman");
            // Console.WriteLine(str);
            // str.Replace("Ayman", "Sab3awy");
            // Console.WriteLine(str);
            // str.Insert(0,"Mr,");
            // Console.WriteLine(str);
            // str.Remove(0,3);
            // Console.WriteLine(str);
            // //they are mutable unlike strings
            #endregion

            //PART 02\\

            #region Q2
            // // enums is a special "class" that contains a set of named integer constants.
            // //we and use enums when we have values that we know will not change,
            // //To get the integer value from an item, you must explicitly convert to an int
            // //ex (enum class below the main function)
            // Console.WriteLine(departments.computer);
            #endregion

            #region Q3
            //strings are immutable , good for read only text and simple modificaiton
            //StringBuilders are mutable , good for more modification purposes and for performance and memory optimization 
            #endregion
        }
        #region enumdec
        enum departments
        {
            computer,
            communicaiion,
            electrical,
            medical,
            mechanical
        }
        #endregion

    }
}
