using Combinations;
using NUnit.Framework;
using System;

namespace CombinationsTest
{
    [TestFixture]
    public class CombinationTesting
    {
        [Test]
        public void TestCombinationSimpleConstructor()
        {
            //
            // ARRANGE
            //

            Combination combination = new Combination(6);

            //
            // ACT
            //

            combination[1] = 1;
            combination[2] = 2;
            combination[3] = 3;
            combination[4] = 4;
            combination[5] = 5;
            combination[6] = 6;

            //
            // ASSERT
            //

            Console.WriteLine(combination);
        }

        [Test]
        public void TestCombinationArrayConstructor()
        {
            //
            // ARRANGE
            //

            Combination combination = new Combination(new int[] { 0, 0, 0, 0, 0, 0});

            //
            // ACT
            //

            combination[1] = 1;
            combination[2] = 2;
            combination[3] = 3;
            combination[4] = 4;
            combination[5] = 5;
            combination[6] = 6;

            //
            // ASSERT
            //

            Console.WriteLine(combination);
        }

        [Test]
        public void TestCombinationCreateMethod()
        {
            //
            // ARRANGE
            //

            Combination combinationSource = new Combination(new int[] { 0, 0, 0, 0, 0, 0 });

            //
            // ACT
            //

            combinationSource[1] = 1;
            combinationSource[2] = 2;
            combinationSource[3] = 3;
            combinationSource[4] = 4;
            combinationSource[5] = 5;
            combinationSource[6] = 6;

            Combination combinationDestination = Combination.Create(combinationSource);

            //
            // ASSERT
            //

            Console.WriteLine("Source      : {0}", combinationSource);
            Console.WriteLine("Destination : {0}", combinationDestination);
        }
    }
}
