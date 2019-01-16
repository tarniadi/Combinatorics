using Combinations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CombinationsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Arrange
            //

            int totalNumbers = 49;
            int combinationNumbers = 6;

            Combinator cmb = new Combinator(totalNumbers, combinationNumbers);

            Console.WriteLine("Combinations ({0},{1}) = {2}", combinationNumbers, totalNumbers, Combinations.Math.Combinations(totalNumbers, combinationNumbers));

            //
            // Act
            //

            BigInteger i = 0;

            foreach (Combination combination in cmb)
            {
                Console.WriteLine(combination);

                i++;
            }

            //
            // Assert
            //

            Console.WriteLine();

            Console.WriteLine(Combinations.Math.Combinations(totalNumbers, combinationNumbers) == i);

            Console.ReadLine();
        }
    }
}
