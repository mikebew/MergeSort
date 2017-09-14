using System.Threading.Tasks;

namespace MergeSortApplication
{
    public class MergeSort
    {
        public async Task<int[]> Sort(int[] iArray)
        {
            int[] duplicateArrary = null;


            duplicateArrary = CloneArray(iArray);

            await Split(iArray, 0, iArray.Length, duplicateArrary);

            return iArray;
        }


        private async Task Split(int[] B, int begin, int end, int[] A)
        {
            if (end - begin < 2)
            {
                return;
            }

            int middle = (end + begin) / 2;

            await Split(A, begin, middle, B);
            await Split(A, middle, end, B);

            Merge(A, begin, middle, end, B);
        }

        private void Merge(int[] A, int begin, int middle, int end, int[] B)
        {
            int i = begin;
            int j = middle;

            for (int k = begin; k < end; k++)
            {
                if (i < middle && (j >= end || A[i] <= A[j]))
                {
                    B[k] = A[i];
                    i++;
                }

                else
                {
                    B[k] = A[j];
                    j++;
                }
            }
        }


        private int[] CloneArray(int[] iSource)
        {
            int[] iCloned = new int[iSource.Length];

            for (int i = 0; i < iSource.Length; i++)
            {
                iCloned[i] = iSource[i];
            }

            return iCloned;
        }
    }
}
