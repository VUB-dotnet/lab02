using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LotteryApp.Pages;

public class Lotto7x39Model : PageModel
{
    public List<int> Numbers { get; set; }
    private readonly ILogger<Lotto7x39Model> _logger;

    public Lotto7x39Model(ILogger<Lotto7x39Model> logger)
    {
        _logger = logger;
        Numbers = GenerateRandomNumbers();
    }

    public void OnGet()
    {

    }

    private List<int> GenerateRandomNumbers()
    {
      var random = new Random();
      var numbers = new List<int>();

      while (numbers.Count < 7)
      {
        int nextNumber = random.Next(1, 39);
        if (!numbers.Contains(nextNumber))
        {
          numbers.Add(nextNumber);
        }
      }

      numbers.Sort();
      return numbers;
    }
}
