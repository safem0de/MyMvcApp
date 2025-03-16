using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;
using MyMvcApp.Helpers;

namespace MyMvcApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public ActionResult exam1()
    {
        List<int> result = new List<int>();
        for (int i = 2500; i <= 2600; i++)
        {
            result.Add(i);
        }

        Dictionary<int, string> resultDictionary = new Dictionary<int, string>();
        foreach (var yearBE in result)
        {
            int yearAD = DataHelper.ConvertBCtoBE(yearBE);
            bool isSpecial = DataHelper.IsMonthSpecial(yearAD, 1);
            resultDictionary.Add(yearBE, isSpecial ? "Yes" : "No");
        }
        return View(resultDictionary);
    }

    public ActionResult exam2()
    {
        Student[] students = Student.GetDemo();
        return View(students);
    }

    public ActionResult exam3()
    {
        Student[] students = Student.GetDemo();
        return View(students);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
