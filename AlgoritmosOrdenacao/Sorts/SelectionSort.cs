namespace AlgoritmosOrdenacao.Sorts
{
    public class SelectionSort
    {
        public static List<int> Calc(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int posMenor = i;
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[j] < numbers[posMenor])
                    {
                        posMenor = j;
                    }
                }
                (numbers[i], numbers[posMenor]) = (numbers[posMenor], numbers[i]);
            }
            return numbers;
        }
    }
}
