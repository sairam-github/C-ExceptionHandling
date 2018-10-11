using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;

            int num2 = 50;

            try
            {
                Divide(num1, num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static int Divide(int num1, int num2)
        {
            try
            {
                return num2 / num1;
            }
            catch (DivideByZeroException ex)
            {
                // Execute by commenting any one of the below lines
                throw new Exception("Exception is thrown");
                // throw new Exception("Exception is thrown", ex);
            }
        }
    }
}
