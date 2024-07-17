using Common;

namespace Demo
{
    // what can i write inside a namespace
    // 1. class 
    // 2. struct
    // 3. Interface
    // 4. Enum

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
        }
    }
}
