using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LotteryApp.Models;

namespace LotteryApp.Pages;

public class Lotto7x39Model : PageModel
{
    public List<int> Numbers { get; set; }
    private readonly ILogger<Lotto7x39Model> _logger;

    public Lotto7x39Model(ILogger<Lotto7x39Model> logger)
    {
        _logger = logger;
        Numbers = Generator.GenerateRandomNumbers(7, 39);
    }

    public void OnGet()
    {

    }
}
