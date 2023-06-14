using EsercizioEntity160523.DB.Entities;
using EsercizioEntity160523.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EsercizioEntity160523.DB
{
    public class RepositoryAutore
    {
        private DBContext DBContext;
        public RepositoryAutore(DBContext DBContext)
        {
            this.DBContext = DBContext;
        }

        public void InsertAutores(Autore autore)
        {
            this.DBContext.Autori.Add(autore);
            this.DBContext.SaveChanges();
        }

       public List<Autore> GetAutori()
        {
            List<Autore> autores= this.DBContext.Autori.ToList();
            return autores;
        }
    }

}
