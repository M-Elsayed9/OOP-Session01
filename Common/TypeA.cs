using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // TypeA is accessible within its project and withing external project  but you have to import the class the library 
    public class TypeA
    {
        //      what you can write inside a class
        // 1. Field or attributes => member variables
        // 2. functions (Constructors, Getters setters, method)
        // 3. Proprties [Full property, Automatic Property, Indexer]
        // 4. Events

        //      Access Modifier Allowed Inside Class?
        // 1. Private[Default]
        // 2. Private Protected
        // 3. Protected
        // 4. Internal
        // 5. Protected Internal
        // 6. Public

        //        Access Modifier Allowed Inside Struct?
        //1. Private[Default]
        //2. Internal
        //3. Public

        /*private*/ int X; // default access modifier is private and accessible withing its scope only
        internal int Y; // accessible within its project
        public int Z; // accessible within its project and external project with import
        
        void Print()
        {
            Console.WriteLine("X: " + X);
        }
    }
}
