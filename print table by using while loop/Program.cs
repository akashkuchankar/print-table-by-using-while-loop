using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_table_by_using_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            Console.WriteLine("Enter any munber");
            N= Convert.ToInt32(Console.ReadLine());

             M = 1;
            while (M <= 10)   
            {
                Console.WriteLine("{0}*{1}={2}",N,M,(N*M));
                M++;    
               
            }
        }
    }
}
