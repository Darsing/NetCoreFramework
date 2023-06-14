using EsercizioEntity160523.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using EsercizioEntity160523.Models;
using EsercizioEntity160523.DB.Entities;
using System.Collections.Generic;

namespace EsercizioEntity160523.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoreController : ControllerBase
    {
        private readonly RepositoryAutore repository;
       
        public AutoreController(RepositoryAutore repository)
        {
            this.repository = repository;
        }

        [HttpPost("InsertAutore")]
        public async Task<IActionResult> InsertAutore([FromBody] LibreriaModel model)
        {
            Autore autore = new Autore();
            autore.Nome = model.Nome;
            this.repository.InsertAutores(autore);
            return Ok(200);
        }

        [HttpGet("GetAutore")]
        public async Task<object> GetAutore()
        {
          List<Autore>autori= this.repository.GetAutori();
            return new { 
            result = autori
            };
        }
    }
}
