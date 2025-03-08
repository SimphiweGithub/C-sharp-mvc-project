using System.Diagnostics;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger , ExpensesDbContext context)
    {
        _logger = logger;
        _context = context;
            

    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult Expenses() {
        var allExpenses = _context.Expensess.ToList();
        return View(allExpenses);
    }
    public IActionResult CreateEditExpenses() {
        return View();
    }
    public IActionResult CreateEditExpensesForm(Expenses model) {
        //this method takes in the model which stores a form from CreateEditExpensesForm.cshtml
        _context.Expensess.Add(model);
        _context.SaveChanges();
        return RedirectToAction("Expenses");//this re directs you to the index page on completion.
    }
    private readonly ExpensesDbContext _context;
}
