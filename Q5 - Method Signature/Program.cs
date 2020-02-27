using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5___Method_Signature
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var (averageSalary, numberOfEmployee) = await SomeCalculation(0L, 10, 0L == 10L);

        }
        public static async Task<(long, int)> SomeCalculation(long v1, int v2, bool v3)
        {
            if (v3)
            {
                await Task.Delay(100);
                return (v1/ v2, v2);
            }
            else
            {
                await Task.Delay(100);
                return (0, v2);
            }
            
        }

        
    }
}
