using System;
using System.Text;

namespace Combinations
{
    public class Combination
    {
        private int CombinedElements { get; set; }

        private int[] elements;

        public int Length { get { return elements.Length; } }

        public int this[int index] // Indexer declaration
        {
            set // Set accessor declaration
            {
                if (index != 0 || index != elements.Length - 1)
                {
                    elements[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("index");
                }
            }

            get // Get accessor declaration
            {
                if (index != 0 || index != elements.Length - 1)
                {
                    return elements[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("index");
                }
            }
        }

        //
        // CONSTRUCTOR
        //
        public Combination(int combinedElements)
        {
            CombinedElements = combinedElements;

            elements = new int[combinedElements + 1];
        }

        public Combination(int[] elements)
        {
            CombinedElements = elements.Length;

            this.elements = new int[elements.Length + 1];

            int i = 0;
            foreach (int element in elements)
            {
                this.elements[i] = elements[i];
                i++;
            }
        }

        //
        // METHODS
        //

        public static Combination Create(Combination combination)
        {
            Combination toReturn = new Combination(combination.Length - 1);

            for (int i = 0; i < combination.Length; i++)
            {
                toReturn[i] = combination[i];
            }

            return toReturn;
        }

        public override string ToString()
        {
            StringBuilder toReturn = new StringBuilder();

            int i = 0;
            toReturn.Append("[");
            foreach (int element in elements)
            {
                if (i != 0)
                {
                    toReturn.Append(element);
                    if (i != elements.Length - 1)
                    {
                        toReturn.Append(",");
                    }
                }
                i++;
            }
            toReturn.Append("]");

            return toReturn.ToString();
        }
    }
}
