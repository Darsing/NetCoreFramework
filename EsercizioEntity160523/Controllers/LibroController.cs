using EsercizioEntity160523.DB;
using EsercizioEntity160523.DB.Entities;
using EsercizioEntity160523.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EsercizioEntity160523.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly RepositoryLibro repository;

        public LibroController(RepositoryLibro repository)
        {
            this.repository = repository;
        }

        [HttpPost("InsertLibro")]
        public async Task<IActionResult> InsertLibro([FromBody] LibreriaModel model)
        {
            Libro libro = new Libro();
            libro.Nome = model.Nome;
            libro.NumeroPagine = int.Parse( model.NumeroDiPagine);
            this.repository.InsertLibri(libro);
            return Ok(200);
        }

        [HttpGet("GetLibro")]
        public async Task<object> GetLibro()
        {

            List<Libro> libri = this.repository.GetLibro();
            return new
            {
                result = libri
            };

        }
    }
}
