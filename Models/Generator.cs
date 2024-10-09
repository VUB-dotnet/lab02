namespace LotteryApp.Models;

public static class Generator
{
  public static List<int> GenerateRandomNumbers(int count, int max)
  {
    var random = new Random();
    var numbers = new List<int>();

    while (numbers.Count < count)
    {
      int nextNumber = random.Next(1, max); // Assuming min is always 1
      if (!numbers.Contains(nextNumber))
      {
        numbers.Add(nextNumber);
      }
    }

    numbers.Sort();
    return numbers;
  }
}
