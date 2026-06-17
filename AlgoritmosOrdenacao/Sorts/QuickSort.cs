namespace AlgoritmosOrdenacao.Sorts
{
    public class QuickSort
    {
        public static List<int> Calc(List<int> numbers, int start, int end)
        {
            if (start < end)
            {
                var particion = Partition(numbers, start, end);
                Calc(numbers, start, particion - 1);
                Calc(numbers, particion + 1, end);
            }
            return numbers;
        }

        private static int Partition(List<int> numbers, int start, int end)
        {
            int pivot = numbers[end];

            int i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (numbers[j] <= pivot)
                {
                    i++;

                    (numbers[j], numbers[i]) = (numbers[i], numbers[j]);
                }
            }

            (numbers[i + 1], numbers[end]) = (numbers[end], numbers[i + 1]);

            return i + 1;
        }
    }
}
