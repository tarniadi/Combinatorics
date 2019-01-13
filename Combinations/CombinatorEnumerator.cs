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
        private int[] Combination { get; set; }
        private int[] Temp { get; set; }


        private int[] Max { get; set; }
        private int[] Min { get; set; }

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

            Combination = new int[CombinedElements + 1];

            Min = new int[CombinedElements + 1];
            Max = new int[CombinedElements + 1];

            for (int x = 1; x <= CombinedElements; x++)
            {
                Combination[x] = x;
                Min[x] = x;
            }

            int v = Combination.Length - 2;

            for (int x = 1; x <= Combination.Length - 1; x++)
            {
                Max[x] = (Elements[TotalElements - v]);
                v--;
            }

            CP = CombinedElements;

            Finished = false;
        }

        public bool MoveNext()
        {
            if (Finished) return false;   //End of process

            if (Combination[Combination.Length - 1] == Min[Min.Length - 1])
            {
                Finished = false;

                Temp = new int[CombinedElements + 1];
                Array.Copy(Combination, Temp, Combination.Length);
                Current = Temp;

                Combination[Combination.Length - 1]++;

                return true;
            }

            if (Combination[1] >= Max[1])
            {
                Finished = true;

                Temp = new int[CombinedElements + 1];
                Array.Copy(Combination, Temp, Combination.Length);
                Current = Temp;

                return true;
            }      //last location (which is first element)

            Temp = new int[CombinedElements + 1];
            Array.Copy(Combination, Temp, Combination.Length);
            Current = Temp;

            //----------------------------------------------------------------------------
            if (Combination[CP] == Max[CP])
            {
                //------------------------------------------------------------------------
                //Loop & step down TC till find CombAry[] != Max[]
                //------------------------------------------------------------------------
                while (Combination[CP] == Max[CP])
                {
                    CP--;
                }
                //-------------------------------------------------------------------------
                //in case the element < its Max value Advance element at 
                //[TC] one step then re-adjust all next elements from location (TC) upto 
                //last location (CombArySZ),,  Or Advance element at [TC] one Step directly
                //-------------------------------------------------------------------------
                int Loc = Combination[CP];

                if (Combination[CP] + 1 == Max[CP])

                    Combination[CP] = ++Loc;

                else
                    for (int t = CP; t <= CombinedElements; t++)
                    {
                        Combination[t] = ++Loc;
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
                Combination[CP]++;

                // the new combination result has been generated, that you can display or store.
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder toReturn = new StringBuilder();

            for (int n = 1; n < Combination.Length; n++)
            {
                toReturn.Append(Combination[n].ToString("## ") + " ");
            }

            return toReturn.ToString();
        }

        public void Reset()
        {
            for (int x = 1; x <= CombinedElements; x++)
            {
                Combination[x] = x;
            }

            CP = CombinedElements;

            Finished = false;
        }
    }
}
