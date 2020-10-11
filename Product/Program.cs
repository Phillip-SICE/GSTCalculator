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
                Decimal.TryParse(inputs[1], out decimal price);
                var product = new Product(inputs[0], price);
                Console.WriteLine($"The GST for {inputs[0]} is {product.CalculateGST()}\n");

                Console.WriteLine("Continue?\n1.Yes\n2.No");
                var key = Console.ReadKey();
                Console.WriteLine();

                if(key.KeyChar != '1')
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();
        }
    }
}
