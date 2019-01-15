namespace Combinations
{
    public class Combination
    {
        private int CombinedElements { get; set; }

        private int[] elements;

        public Combination(int combinedElements)
        {
            CombinedElements = combinedElements;

            elements = new int[combinedElements + 1];
        }
    }
}
