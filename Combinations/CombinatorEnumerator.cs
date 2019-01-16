using System;
using System.Collections;
using System.Text;

namespace Combinations
{
    public class CombinatorEnumerator : IEnumerator
    {
        private int CP { get; set; }

        public int TotalElements { get; set; }
        public int CombinedElements { get; set; }

        private int[] Elements { get; set; }           
        private Combination CurrentCombination { get; set; }
        private Combination TempCombination { get; set; }


        private Combination MaxCombination { get; set; }
        private Combination MinCombination { get; set; }

        public bool Finished { get; set; }

        public object Current { get; set; }

        public CombinatorEnumerator(int totalElements, int combinedElements)
        {
            TotalElements = totalElements;
            CombinedElements = combinedElements;

            Elements = new int[TotalElements + 1];

            for (int x = 0; x < Elements.Length; x++)
            {
                Elements[x] = x;
            }

            CurrentCombination = new Combination(CombinedElements);

            MinCombination = new Combination(CombinedElements);
            MaxCombination = new Combination(CombinedElements);

            for (int x = 1; x <= CombinedElements; x++)
            {
                CurrentCombination[x] = x;
                MinCombination[x] = x;
            }

            int v = CurrentCombination.Length - 2;

            for (int x = 1; x <= CurrentCombination.Length - 1; x++)
            {
                MaxCombination[x] = (Elements[TotalElements - v]);
                v--;
            }

            CP = CombinedElements;

            Finished = false;
        }

        public bool MoveNext()
        {
            if (Finished) return false;   //End of process

            if (CurrentCombination[CurrentCombination.Length - 1] == MinCombination[MinCombination.Length - 1])
            {
                Finished = false;

                TempCombination = Combination.Create(CurrentCombination);
                Current = TempCombination;

                CurrentCombination[CurrentCombination.Length - 1]++;

                return true;
            }

            if (CurrentCombination[1] >= MaxCombination[1])
            {
                Finished = true;

                TempCombination = Combination.Create(CurrentCombination);
                Current = TempCombination;

                return true;
            }      //last location (which is first element)

            TempCombination = Combination.Create(CurrentCombination);
            Current = TempCombination;

            //----------------------------------------------------------------------------
            if (CurrentCombination[CP] == MaxCombination[CP])
            {
                //------------------------------------------------------------------------
                //Loop & step down TC till find CombAry[] != Max[]
                //------------------------------------------------------------------------
                while (CurrentCombination[CP] == MaxCombination[CP])
                {
                    CP--;
                }
                //-------------------------------------------------------------------------
                //in case the element < its Max value Advance element at 
                //[TC] one step then re-adjust all next elements from location (TC) upto 
                //last location (CombArySZ),,  Or Advance element at [TC] one Step directly
                //-------------------------------------------------------------------------
                int Loc = CurrentCombination[CP];

                if (CurrentCombination[CP] + 1 == MaxCombination[CP])

                    CurrentCombination[CP] = ++Loc;

                else
                    for (int t = CP; t <= CombinedElements; t++)
                    {
                        CurrentCombination[t] = ++Loc;
                    }
                //-------------------------------------------------------------------------
                //after this element readjustment, alwayes TC must be reset to 
                //the last element in CombAry[]
                //-------------------------------------------------------------------------
                CP = CombinedElements;

                return true;
            }
            else
            {
                CurrentCombination[CP]++;

                // the new combination result has been generated, that you can display or store.
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder toReturn = new StringBuilder();

            for (int n = 1; n < CurrentCombination.Length; n++)
            {
                toReturn.Append(CurrentCombination[n].ToString("## ") + " ");
            }

            return toReturn.ToString();
        }

        public void Reset()
        {
            for (int x = 1; x <= CombinedElements; x++)
            {
                CurrentCombination[x] = x;
            }

            CP = CombinedElements;

            Finished = false;
        }
    }
}
