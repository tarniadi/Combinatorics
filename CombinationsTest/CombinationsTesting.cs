using Combinations;
using NUnit.Framework;
using System;
using System.Numerics;
using System.Text;

namespace CombinationsTest
{
    [TestFixture]
    public class CombinationsTesting
    {
        [Test]
        [Ignore("Ignore a fixture")]
        [TestCase((int)5, (int)2)]
        public void CheckCombinationsNumber(int totalNumbers, int combinationNumbers)
        {
            //
            // Arrange
            //

            CombinatorEnumerator cmb = new CombinatorEnumerator(totalNumbers, combinationNumbers);

            //
            // Act
            //

            BigInteger i = 0;

            while (!cmb.Finished)
            {
                cmb.MoveNext();
                i++;
            }

            //
            // Assert
            //

            Assert.AreEqual(Combinations.Math.Combinations(totalNumbers, combinationNumbers), i);
        }

        [Test]
        [Ignore("Ignore a fixture")]
        [TestCase((int)2)]
        [TestCase((int)3)]
        [TestCase((int)4)]
        [TestCase((int)5)]
        [TestCase((int)6)]
        [TestCase((int)7)]
        [TestCase((int)8)]
        [TestCase((int)9)]
        [TestCase((int)10)]
        [TestCase((int)11)]
        [TestCase((int)12)]
        [TestCase((int)13)]
        [TestCase((int)14)]
        [TestCase((int)15)]
        [TestCase((int)16)]
        [TestCase((int)17)]
        [TestCase((int)18)]
        [TestCase((int)19)]
        [TestCase((int)20)]
        [TestCase((int)33)]

        public void CheckAllCombinationsNumber(int maxTotalNumbers)
        {
            for (int totalNumbers = maxTotalNumbers; totalNumbers <= maxTotalNumbers; totalNumbers++)
            {
                for (int combinationNumbers = 1; combinationNumbers <= totalNumbers - 1; combinationNumbers++)
                {
                    //
                    // Arrange
                    //

                    CombinatorEnumerator cmb = new CombinatorEnumerator(totalNumbers, combinationNumbers);

                    Console.WriteLine("Combinations ({1},{0}) = {2}", combinationNumbers, totalNumbers, Combinations.Math.Combinations(totalNumbers, combinationNumbers));

                    //
                    // Act
                    //

                    BigInteger i = 0;

                    while (!cmb.Finished)
                    {
                        //Console.WriteLine("{0}, [{1}]", i + 1, cmb);
                        cmb.MoveNext();
                        i++;
                    }

                    //
                    // Assert
                    //

                    Assert.AreEqual(Combinations.Math.Combinations(totalNumbers, combinationNumbers), i);
                }
            }
        }

        [Test]
        [Ignore("Ignore a fixture")]
        [TestCase((int)5, (int)2)]
        public void CheckOneCombinationsNumber(int totalNumbers, int combinationNumbers)
        {
            //
            // Arrange
            //

            CombinatorEnumerator cmb = new CombinatorEnumerator(totalNumbers, combinationNumbers);

            Console.WriteLine("Combinations ({0},{1}) = {2}", combinationNumbers, totalNumbers, Combinations.Math.Combinations(totalNumbers, combinationNumbers));

            //
            // Act
            //

            BigInteger i = 0;

            while (!cmb.Finished)
            {
                Console.WriteLine("{0}, [{1}]", i + 1, cmb);
                cmb.MoveNext();
                i++;
            }

            //
            // Assert
            //

            Assert.AreEqual(Combinations.Math.Combinations(totalNumbers, combinationNumbers), i);
        }

        [Test]
        //[Ignore("Ignore a fixture")]
        [TestCase((int)30, (int)6)]
        public void CheckIEnumerable(int totalNumbers, int combinationNumbers)
        {
            //
            // Arrange
            //

            Combinator cmb = new Combinator(totalNumbers, combinationNumbers);

            Console.WriteLine("Combinations ({1},{0}) = {2}", combinationNumbers, totalNumbers, Combinations.Math.Combinations(totalNumbers, combinationNumbers));

            //
            // Act
            //

            BigInteger i = 0;

            foreach (Combination combination in cmb)
            {

                Console.WriteLine("{0,3} - {1}", i+1, combination);

                i++;
            }

            //
            // Assert
            //

            Assert.AreEqual(Combinations.Math.Combinations(totalNumbers, combinationNumbers), i);
        }
    }
}
