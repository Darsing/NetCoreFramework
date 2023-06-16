using System;
using System.Collections.Generic;
using System.Linq;
using Myfruit.DB.Entities;

namespace Myfruit.DB
{
    public class Repository
    {
        private UserDBContext DBContext;
        public Repository(UserDBContext DBContext)
        {
            this.DBContext = DBContext;
        }

        public void InsertFruit(Fruit fruit)
        {
            DBContext.Fruits.Add(fruit);
            DBContext.SaveChanges();
        }

        public List<Fruit> GetFruits()
        {
            //select * from fruits
            List<Fruit> fruits = DBContext.Fruits.ToList();
            return fruits;
        }

        public void InsertImage(Image image)
        {
            DBContext.Images.Add(image);
            DBContext.SaveChanges();
        }
        public List<Image> GetImage()
        {
            //select * from image
            List<Image> images = DBContext.Images.ToList();
            return images;
        }
    }
}
