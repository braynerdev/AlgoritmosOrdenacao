using AlgoritmosOrdenacao.Sorts;

List<int> numbers = new List<int>() { 435, 23, 21, 324, 1, 891, 2, 45, 436 };

//var response = InsertionSort.Calc(numbers);
//var response = BubbleSort.Calc(numbers);
//var response = SelectionSort.Calc(numbers);
var response = QuickSort.Calc(numbers, 0, numbers.Count - 1);

Console.WriteLine($"Response: [{string.Join(", ", response)}]");
