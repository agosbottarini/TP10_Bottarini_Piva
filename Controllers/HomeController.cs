using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP10_Bottarini_Piva.Models;

namespace TP10_Bottarini_Piva.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Series = BD.ObtenerSeries();    

        return View();
    }


    public List<Actores> ObtenerActores(int idSerie)
    {
        List<Actores> ListaActores = BD.ObtenerActores(idSerie);

        return ListaActores;
    }

    public List<Temporadas> ObtenerTemporadas(int idSerie)
    {
        List<Temporadas> ListaTemporadas = BD.ObtenerTemporadas(idSerie);

        return ListaTemporadas;
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
