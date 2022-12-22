using Microsoft.AspNetCore.Mvc;
using ReleaseFlow.WebApp.Models;
using System.Diagnostics;
using System.Reflection;

namespace ReleaseFlow.WebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var version = Assembly.GetExecutingAssembly().GetName().Version;

        if (version != null)
        {
            var assemblyVersion = version.ToString();
            ViewBag.Message = $"Your application description page. Version: {assemblyVersion}";
        }

        return View();
    }

    public IActionResult Privacy()
    {
        var version = Assembly.GetExecutingAssembly().GetName().Version;

        if (version != null)
        {
            var assemblyVersion = version.ToString();
            ViewBag.Message = $"Your application description page. Version: {assemblyVersion}";
        }

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}