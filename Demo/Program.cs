using Common;
using System.Security.Principal;

namespace Demo
{
    

    // Access Modifiers Allowed inside Namespace
    // 1. internal (Default)
    // 2. public

    internal class Program
    {
        #region Exception Handling
        //static void DoSomeCode()
        //{
        //    try
        //    {
        //        int X, Y, Z;

        //        X = int.Parse(Console.ReadLine()); // System.FormatException
        //        Y = int.Parse(Console.ReadLine());
        //        Z = X / Y; // System.divideByZeroException

        //        int[] Numbers = { 1, 2, 3 };
        //        Numbers[10] = 100; // System.IndexOutOfRangeException
        //    }
        //    // if any exception happens in the try block 
        //    // The clr will create an object from the class of the exception 
        //    // then it will be throughn in the catch block 
        //    catch (FormatException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        // Log in file or store in the database for the support team
        //    }
        //    catch (DivideByZeroException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    catch (IndexOutOfRangeException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        // this block will be executed in all cases
        //        // if there is an exception or not
        //        // if there is a return statement or not
        //        // if there is a break statement or not
        //        // if there is a continue statement or not
        //        // if there is a goto statement or not
        //        // if there is a throw statement or not
        //        // if there is a try block or not
        //        // if there is a catch block or not
        //        // if there is a loop or not
        //        // if there is a condition or not
        //        // if there is a method or not
        //        // if there is a class or not
        //        // if there is a namespace or not
        //        // if there is a project or not
        //        // if there is a solution or not
        //        // if there is a computer or not
        //        // if there is a human or not
        //        // if there is a planet or not
        //        // if there is a galaxy or not
        //        // if there is a universe or not
        //        // if there is a multiverse

        //    }
        //}

        //static void DoSomeProtectiveCode()
        //{
        //    int X, Y, Z;
        //    bool Flag;
        //    do
        //    {
        //        Console.WriteLine("Enter First Num: ");
        //        Flag = int.TryParse(Console.ReadLine(), out X); // System.FormatException

        //    } while (!Flag);
        //    // try parese ==> GTrue - X = 10
        //    // try parse ==> False - X = 0

        //    do
        //    {
        //        Console.WriteLine("Enter First Num: ");
        //        Flag = int.TryParse(Console.ReadLine(), out Y);

        //    } while (!Flag || Y == 0);

        //    Z = X / Y; // System.divideByZeroException

        //    //int[] Numbers = { 1, 2, 3 };
        //    int[] Numbers = null; // Null Reference Exception

        //    if (Numbers?.Length > 10)
        //    {
        //        // if Numbers = Null => Numbers?.Length = Null
        //        // if Numbers = Not Null => Numbers?.Length = Numbers.Length
        //        Numbers[10] = 100; // System.IndexOutOfRangeException
        //    }
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region Exception Handling
            //DoSomeCode();

            //Exception

            // 1. System Exceptions
            //// 1.1 Format Exception
            //// 1.2 Index Out Of Range exception
            //// 1.3 Null Reference Exception
            //// 1.4 Invalid Operation Exception
            //// 1.5 Arithimitic Exception
            ////  1.5.1 Divide by Zero Exception
            ////  1.5.2 Overflow Exception

            // 2. Application Excpetions
            //// 
            ////

            //try
            //{
            //    DoSomeProtectiveCode();
            //    // throw new Exception("This is a custom exception");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    // Close | Delete | Release | Deallocated Unmanged resources
            //    // open file
            //    // Connection with database
            //    Console.WriteLine("Finally Block");
            //}

            //Console.WriteLine("After finally"); 
            #endregion

            #region Access Modifiers 
            TypeA obj = new TypeA();

            // TypeB obj2 = new TypeB(); // invalid because TypeB is internal and not accessible in the external project

            //obj.X = 10; // invalid because X is private 
            
            obj.Z = 10; // valid because Z is public
            #endregion

            #region Enum
            #region Ex 01
            //Days day = Days.Friday;

            //Grades X = Grades.A;

            //Console.WriteLine(day);
            //Console.WriteLine(X);

            //if (day == Days.Saturday)
            //{
            //    Console.WriteLine("Today is a holiday");
            //}
            //else
            //{
            //    Console.WriteLine("Today is a working day");
            //}

            //if (X == Grades.A)
            //{
            //    Console.WriteLine("Excellent");
            //}
            //else if (X == Grades.B)
            //{
            //    Console.WriteLine("Very Good");
            //}
            //else if (X == Grades.C)
            //{
            //    Console.WriteLine("Good");
            //}
            //else if (X == Grades.D)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}

            //Grades Y = 2; // invalid because 2 is not a valid value for Grades enum

            //Grades Y = (Grades)2; // valid because we are casting 2 to Grades enum

            //Grades Z = (Grades)10; // invalid because 10 is not a valid value for Grades enum
            //Console.WriteLine(Z); // 10 
            #endregion

            #region Ex 02
            //Console.WriteLine("Please Enter your Grade: ");

            ////Grades X = (Grades) Enum.Parse(typeof(Grades), Console.ReadLine());
            //// bad way 

            //bool result = Enum.TryParse(typeof(Grades), Console.ReadLine(), out object X);

            //Console.WriteLine(X);
            //Console.WriteLine(result);
            #endregion
            #endregion

            #region Struct
            //Point P1;

            // Decalre a variable from the type Point
            // CLR will allocate 8 uninitialized bytes in the stack

            // Console.Write(P1.X) // invalid because X is not initialized

            //P1.X = 10;
            //P1.Y = 20;

            //Console.WriteLine(P1.X);
            //Console.WriteLine(P1.Y);

            // Point P2 = new Point(10, 20);
            // CLR will allocate 8 bytes in the stack and initialize them with default constructor values
            // New => is just only for constructor selection

            //Console.WriteLine(P2.X);
            //Console.WriteLine(P2.Y);
            //Console.WriteLine(P2.ToString());

            //Console.WriteLine(P1); // Boxing, unboxing

            //Point P02 = new();


            #endregion
        }
    }

    class Employee
    {
        string Name;
        int Age;
        double Salary;
        Gender Gender; // Male - Female
        Role Role = Role.Admin; // Admin - User - Guest
    }

    public enum Branches : byte
    {
        Dokki = 200, Giza, Maadi = 253, NasrCity, Heliopolis // SmartVillage invalid 
    }

    public enum Role : int
    {
        Admin = 20, Editor = 30, Viewer = 40
    }
    public enum Gender : int // default 
    {
        Male, Female
    }

    public enum Days : int
    {
        Saturday = 1,
        Sunday = 2,
        Monday, // 3
        Tuesday, 
        Wednesday, 
        Friday
    }

    public enum Grades : int
            {
        A, B, C, D, F
    }
}
