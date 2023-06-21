namespace RadixSort
{
    public class LSDSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            int maxVal = GetMaxValue(arr);

            for (int exp = 1; maxVal / exp > 0; exp *= 10)
            {
                CountingSort(arr, n, exp);
            }
        }

        private static void CountingSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                count[(arr[i] / exp) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }

        private static int GetMaxValue(int[] arr)
        {
            int max = int.MinValue;
            foreach (int num in arr)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
