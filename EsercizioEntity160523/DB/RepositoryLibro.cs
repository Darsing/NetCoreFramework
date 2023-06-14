using EsercizioEntity160523.DB.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EsercizioEntity160523.DB
{
    public class RepositoryLibro
    {
        private DBContext DBContext;
        public RepositoryLibro(DBContext DBContext)
        {
            this.DBContext = DBContext;
        }

        public void InsertLibri(Libro libro)
        {
            this.DBContext.Libri.Add(libro);
            this.DBContext.SaveChanges();
        }

        //con Include sto facendo la join
        public List<Libro> GetLibro()
        {
            List<Libro> libri = this.DBContext.Libri.Include(l => l.Autore).ToList();
            return libri;
        }
    }
}
