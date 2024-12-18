using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab_12.Models;

namespace Lab_12.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}