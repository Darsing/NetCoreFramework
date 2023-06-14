using EsercizioEntity160523.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EsercizioEntity160523.Controllers
{
    /*
     esercizio:
        - aggiungere un API controller con una post che crei una Person
        su DB prendendo i dati dall'input dell'utente nel frontend
    passi:
        - creare database con nome arbitrario
        - creare tabella Persons
        - creare la connection string nell'appsettings.json
        - importare i pacchetti nuget necessari (guardare nelle 
        dependencies di questo progetto)
        - creare il DBContext
        - creare la Repository
        - registrare i servizi necessari in Startup.cs
        (dbcontext, repository)
        - creare un API controller con la post di insert
            - esempio nel branch MVCeAPI nel PersonController
        - creare in una view un form di insert con n textbox e un button di insert
        - creare una funzione js collegata al button di insert che
        chiami l'endpoint post del controller
        - nell'endpoint del controller chiamare l'insert della repository
            - esempio nel branch EntityFramework in HomeController
     */
    /*
     - creare nel database le entità Libro e Autore
        - autore in rapporto 1:n con libro
     - creare la struttura necessaria per fare get e insert di libro e autore
        - 1 controller per libro con get e insert
        - 1 controller per autore con get e insert
     - creare una view Libreria.cshtml che estragga sia i libri che gli autori
     e li mostri in pagina
     */
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

        public IActionResult Libreria()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
