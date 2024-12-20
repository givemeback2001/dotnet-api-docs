﻿// System.Int32.Equals(Object)

/*
   The following program demonstrates the 'Equals(Object)' method
   of struct 'Int32'. This compares an instance of 'Int32' with the
   passed in object and returns true if they are equal.
*/

using System;
class MyInt32_Equals
{
     public static void Main()
     {
         try
         {
// <Snippet1>
            Int32 myVariable1 = 60;
            Int32 myVariable2 = 60;

            // Get and display the declaring type.
            Console.WriteLine("\nType of 'myVariable1' is '{0}' and"+
                 " value is :{1}",myVariable1.GetType(), myVariable1);
            Console.WriteLine("Type of 'myVariable2' is '{0}' and"+
                 " value is :{1}",myVariable2.GetType(), myVariable2);

            // Compare 'myVariable1' instance with 'myVariable2' Object.
            if( myVariable1.Equals( myVariable2 ) )
               Console.WriteLine( "\nStructures 'myVariable1' and "+
                     "'myVariable2' are equal");
            else
               Console.WriteLine( "\nStructures 'myVariable1' and "+
                     "'myVariable2' are not equal");

// </Snippet1>
         }
         catch(Exception e)
         {
            Console.WriteLine("Exception :{0}", e.Message);
         }
     }
}
