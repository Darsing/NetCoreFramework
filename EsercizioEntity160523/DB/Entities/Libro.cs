using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EsercizioEntity160523.DB.Entities
{
    public class Libro
    {
        [Key]
        public Guid IDLibro { get; set; }
        public string Nome { get; set; }
        public int NumeroPagine { get; set; }
        public Guid? IDAutore { get; set; }
        [ForeignKey("IDAutore")]
        public Autore Autore { get; set; } // questa è la variabile d appoggio per porte fare la join

    }
}
