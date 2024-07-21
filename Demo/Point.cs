using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Point
    {
        //      what you can write inside a struct
        // 1. Field or attributes => member variables

        #region Attributes
        public int X;
        public int Y;
        #endregion

        // 2. functions (Constructors, Getters setters, method)

        // Constructor => special function that will be called when you create an object from the class
        // 1. Always Named with the same name of the struct or class
        // 2. No return type
        // 3. Can be overloaded

        #region Constructors
        // By Default , the compiler will create a paramerterless constructor for you
        //public Point() // initialized default values of the attributes
        //{ 

        //} // before .Net 7 you had to initialize the values inside the constructor

        //public Point() 
        //{
        //    X = 1;
        //    Y = 2;
        //    // valid from c# 10 .Net 6.0
        //}

        //public Point(int x, int y)
        //{
        //    X = x;
        //    Y = y;
        //} 

        //public Point(int L, int M) // invalid 
        //{ 
        //   X = L;
        //   Y = M;
        //}

        public Point(int X)
        {
            this.X = X;
            this.Y = X;
        }
        #endregion


        #region Methods

        public override string ToString()
        {
            return $"{X} , {Y}";
        }
        #endregion
        // 3. Proprties [Full property, Automatic Property, Indexer]
        // 4. Events

        //     Access Modifier Allowed Inside Struct
        // 1. Private[Default]
        // 2. Internal
        // 3. Public

    }
}
