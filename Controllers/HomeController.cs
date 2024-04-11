using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Hrpage.Models;

namespace Hrpage.Controllers;

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
    [HttpGet]
    public ViewResult emplo()
    {
        return View();
    }
    [HttpPost]
    public ViewResult emplo(empl emp)
    {
        if (ModelState.IsValid)
        {
            Repo.ADDemp(emp);
            return View("ConfirmPage", emp);
        }
        else
            return View();
    }
    public ViewResult allempl()
    {
        return View(Repo.Getemp().Where(emp =>emp.isactive == true));
    }
}
