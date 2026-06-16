namespace AlgoritmosOrdenacao.Sorts
{
    public class InsertionSort
    {
        public static List<int> Calc(List<int> numbers)
        {
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    var menor = true;
                    for (int j = i; j > 0 && menor; j--)
                    {
                        if (numbers[j - 1] > numbers[j])
                        {
                            (numbers[j], numbers[j - 1]) = (numbers[j - 1], numbers[j]);
                        }
                        else
                        {
                            menor = false;
                        }
                    }
                }
            }
            return numbers;
        }
    }
}
