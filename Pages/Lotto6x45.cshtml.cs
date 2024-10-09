using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LotteryApp.Models;

namespace LotteryApp.Pages;

public class Lotto6x45Model : PageModel
{
    public List<int> Numbers { get; set; }
    private readonly ILogger<Lotto6x45Model> _logger;

    public Lotto6x45Model(ILogger<Lotto6x45Model> logger)
    {
        _logger = logger;
        Numbers = Generator.GenerateRandomNumbers(6, 45);
    }

    public void OnGet()
    {

    }
}
