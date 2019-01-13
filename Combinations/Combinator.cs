using System.Collections;

namespace Combinations
{
    public class Combinator : IEnumerable
    {
        private int TotalElements { get; set;}
        private int CombinedElements { get; set; }

        public Combinator(int totalElements, int combinedElements)
        {
            TotalElements = totalElements;
            CombinedElements = combinedElements;
        }

        public IEnumerator GetEnumerator()
        {
            return new CombinatorEnumerator(TotalElements, CombinedElements);
        }
    }
}
