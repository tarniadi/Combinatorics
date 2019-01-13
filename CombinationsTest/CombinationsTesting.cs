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
        [TestCase((int)21, (int)18)]
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
        //[Ignore("Ignore a fixture")]
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
        [TestCase((int)21)]
        [TestCase((int)22)]
        [TestCase((int)23)]
        [TestCase((int)24)]
        [TestCase((int)25)]
        [TestCase((int)26)]
        [TestCase((int)27)]
        [TestCase((int)28)]
        [TestCase((int)29)]
        [TestCase((int)30)]
        [TestCase((int)31)]
        [TestCase((int)32)]
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

                    Console.WriteLine("Combinations ({0},{1}) = {2}", combinationNumbers, totalNumbers, Combinations.Math.Combinations(totalNumbers, combinationNumbers));

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
        [TestCase((int)49, (int)6)]
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
        [Ignore("Ignore a fixture")]
        [TestCase((int)49, (int)6)]
        public void CheckIEnumerable(int totalNumbers, int combinationNumbers)
        {
            //
            // Arrange
            //

            Combinator cmb = new Combinator(totalNumbers, combinationNumbers);

            Console.WriteLine("Combinations ({0},{1}) = {2}", combinationNumbers, totalNumbers, Combinations.Math.Combinations(totalNumbers, combinationNumbers));

            //
            // Act
            //

            BigInteger i = 0;

            foreach (int[] combination in cmb)
            {
                StringBuilder toReturn = new StringBuilder();

                for (int n = 1; n < combination.Length; n++)
                {
                    toReturn.Append(combination[n].ToString("## ") + " ");
                }

                Console.WriteLine(toReturn.ToString());

                i++;
            }

            //
            // Assert
            //

            Assert.AreEqual(Combinations.Math.Combinations(totalNumbers, combinationNumbers), i);
        }
    }
}

//[TestCase((int)3, (int)2)]
//[TestCase((int)4, (int)2)]
//[TestCase((int)5, (int)3)]
//[TestCase((int)6, (int)3)]
//[TestCase((int)7, (int)4)]
//[TestCase((int)8, (int)4)]
//[TestCase((int)9, (int)4)]
//[TestCase((int)10, (int)4)]
//[TestCase((int)11, (int)5)]
//[TestCase((int)12, (int)5)]
//[TestCase((int)13, (int)5)]
//[TestCase((int)14, (int)5)]
//[TestCase((int)15, (int)5)]
//[TestCase((int)16, (int)5)]
//[TestCase((int)17, (int)5)]
//[TestCase((int)18, (int)5)]
//[TestCase((int)19, (int)5)]
//[TestCase((int)20, (int)5)]
//[TestCase((int)21, (int)6)]
//[TestCase((int)22, (int)6)]
//[TestCase((int)23, (int)6)]
//[TestCase((int)24, (int)6)]
//[TestCase((int)25, (int)6)]
//[TestCase((int)26, (int)6)]
//[TestCase((int)27, (int)6)]
//[TestCase((int)28, (int)6)]
//[TestCase((int)29, (int)6)]
//[TestCase((int)30, (int)6)]
//[TestCase((int)31, (int)6)]
//[TestCase((int)32, (int)6)]
//[TestCase((int)33, (int)6)]
//[TestCase((int)34, (int)6)]
//[TestCase((int)35, (int)6)]
//[TestCase((int)36, (int)6)]
//[TestCase((int)37, (int)6)]
//[TestCase((int)38, (int)6)]
//[TestCase((int)39, (int)6)]
//[TestCase((int)40, (int)6)] 

//[TestCase((int)3)]
//[TestCase((int)4)]
//[TestCase((int)5)]
//[TestCase((int)6)]
//[TestCase((int)7)]
//[TestCase((int)8)]
//[TestCase((int)9)]
//[TestCase((int)10)]
//[TestCase((int)11)]
//[TestCase((int)12)]
//[TestCase((int)13)]
//[TestCase((int)14)]
//[TestCase((int)15)]
//[TestCase((int)16)]
//[TestCase((int)17)]
//[TestCase((int)18)]
//[TestCase((int)19)]
//[TestCase((int)20)]
//[TestCase((int)21)]
//[TestCase((int)22)]
//[TestCase((int)23)]
//[TestCase((int)24)]
//[TestCase((int)25)]
//[TestCase((int)26)]
//[TestCase((int)27)]
//[TestCase((int)28)]
//[TestCase((int)29)]
//[TestCase((int)30)]
//[TestCase((int)31)]
//[TestCase((int)32)]
//[TestCase((int)33)]
//[TestCase((int)34)]
//[TestCase((int)35)]
//[TestCase((int)36)]
//[TestCase((int)37)]
//[TestCase((int)38)]
//[TestCase((int)39)]
//[TestCase((int)40)]
