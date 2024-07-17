using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {

        // type B is accessible within its project but not accessible in the external project
        public TypeB()
        {
            TypeA typeA = new TypeA();
            // valid -> TypeA is accessible within its project

            //typeA.X = 1; // invalid due to its protection level 
            // because X is private 

            typeA.Y = 2; // valid because Y is internal

            typeA.Z = 3; // valid because Z is public

            
        }
    }
}
