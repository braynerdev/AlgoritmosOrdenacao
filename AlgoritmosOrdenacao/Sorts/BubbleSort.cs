namespace AlgoritmosOrdenacao.Sorts
{
    public class BubbleSort
    {
        public static List<int> Calc(List<int> numbers)
        {
            var troca = true;
            for (int i = 0; i < numbers.Count - 1 && troca; i++)
            {
                troca = false;
                for (int j = 0; j < numbers.Count - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                        troca = true;
                    }
                }
            }
            return numbers;

        }
    }
}
