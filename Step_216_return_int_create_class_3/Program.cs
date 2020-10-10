using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Step_216_return_int_create_class_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            MathProblem problem = new(MathProblem);
            problem.Add();


        }
    } }
