using DSA_CSharp.TwoSumSolution;

TwoSumSolution solution = new TwoSumSolution();
int[] numbers = new int[] { 3, 4, 7 };
int[] results = solution.TwoSum(numbers, 11);
Console.WriteLine($"{results[0]}, {results[1]} ");
Console.WriteLine("\nPress any key to terminate program.");
Console.ReadKey();