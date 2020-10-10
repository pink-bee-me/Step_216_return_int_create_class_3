using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_216_return_int_create_class_3
{
    class MathProblem
    {

        int x { get; set; }
        int num { get; set; }
        
        
        public int Add(int num)
        {
            int x = 6 + num;
            return x;
        }

        public int Sub(int num)
        {
            int x = 6 - num;
            return x;
        }
    
        public int Mult(int num)
        {
            int x = 6 * num;
            return x;
        }
    }
}







