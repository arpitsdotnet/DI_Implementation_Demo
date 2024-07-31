using System.Diagnostics;
using System.Text;
using DI_Implementation_Demo.Models;
using DI_Implementation_Demo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI_Implementation_Demo.Controllers;
public class HomeController : Controller
{
    private readonly IScopedGuidService _scoped1;
    private readonly IScopedGuidService _scoped2;
    private readonly IScopedGuidService _scoped3;
    private readonly ITransientGuidService _transient1;
    private readonly ITransientGuidService _transient2;
    private readonly ITransientGuidService _transient3;
    private readonly ISingletonGuidService _singleton1;
    private readonly ISingletonGuidService _singleton2;
    private readonly ISingletonGuidService _singleton3;

    public HomeController(
        IScopedGuidService scoped1,
        IScopedGuidService scoped2,
        IScopedGuidService scoped3,
        ITransientGuidService transient1,
        ITransientGuidService transient2,
        ITransientGuidService transient3,
        ISingletonGuidService singleton1,
        ISingletonGuidService singleton2,
        ISingletonGuidService singleton3
        )
    {
        _scoped1 = scoped1;
        _scoped2 = scoped2;
        _scoped3 = scoped3;
        _transient1 = transient1;
        _transient2 = transient2;
        _transient3 = transient3;
        _singleton1 = singleton1;
        _singleton2 = singleton2;
        _singleton3 = singleton3;
    }

    public IActionResult Index()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Transient 1: {_transient1.GetGuid()}");
        sb.AppendLine($"Transient 2: {_transient2.GetGuid()}");
        sb.AppendLine($"Transient 3: {_transient3.GetGuid()}");
        sb.AppendLine("\n");
        sb.AppendLine($"Scoped 1: {_scoped1.GetGuid()}");
        sb.AppendLine($"Scoped 2: {_scoped2.GetGuid()}");
        sb.AppendLine($"Scoped 3: {_scoped3.GetGuid()}");
        sb.AppendLine("\n");
        sb.AppendLine($"Singleton 1: {_singleton1.GetGuid()}");
        sb.AppendLine($"Singleton 2: {_singleton2.GetGuid()}");
        sb.AppendLine($"Singleton 3: {_singleton3.GetGuid()}");
        sb.AppendLine("\n");
        sb.AppendLine("Refresh the page and see the guid generated for different scope");

        return Ok(sb.ToString());
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
}
