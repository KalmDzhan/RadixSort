namespace RadixSort
{
    public class MSDSort
    {
        public static void Sort(string[] arr)
        {
            int n = arr.Length;
            string[] aux = new string[n];
            Sort(arr, aux, 0, n - 1, 0);
        }

        private static void Sort(string[] arr, string[] aux, int low, int high, int d)
        {
            if (high <= low)
            {
                return;
            }

            int[] count = new int[256 + 2];
            for (int i = low; i <= high; i++)
            {
                int index = GetCharIndex(arr[i], d);
                count[index + 2]++;
            }

            for (int r = 0; r < 256 + 1; r++)
            {
                count[r + 1] += count[r];
            }

            for (int i = low; i <= high; i++)
            {
                int index = GetCharIndex(arr[i], d);
                aux[count[index + 1]++] = arr[i];
            }

            for (int i = low; i <= high; i++)
            {
                arr[i] = aux[i - low];
            }

            for (int r = 0; r < 256; r++)
            {
                Sort(arr, aux, low + count[r], low + count[r + 1] - 1, d + 1);
            }
        }

        private static int GetCharIndex(string str, int d)
        {
            if (d < str.Length)
            {
                return (int)str[d];
            }
            else
            {
                return -1;
            }
        }
    }
}
