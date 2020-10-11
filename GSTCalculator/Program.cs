using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTCalculator
{
    public class Program
    {

        public void Run()
        {
            while(true)
            {
                Console.WriteLine("Please enter product name and price, separated by a single white space:");
                var input = Console.ReadLine();
                var inputs = input.Split(' ');
                var product = new Product(inputs[0], Decimal.TryParse(inputs[1]));
                Console.WriteLine($"The GST for {inputs[0]} is {product.CalculateGST()}");
            }
        }

        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();
        }
    }
}
