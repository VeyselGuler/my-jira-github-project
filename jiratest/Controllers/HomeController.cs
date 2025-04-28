using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using jiratest.Models;

namespace jiratest.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
        
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
}