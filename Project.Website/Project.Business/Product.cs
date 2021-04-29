using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business
{
    class Product
    {

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }

        public List<Project.DataAccess.Product> List()
        {
            Project.DataAccess.WebsiteEntities ent = new DataAccess.WebsiteEntities();
            var s = ent.Products.OrderByDescending(p => p.ProductId).ToList();
            return s;
        }
        public string DataAdd(Project.DataAccess.Product obj)
        {
            Project.DataAccess.WebsiteEntities add = new DataAccess.WebsiteEntities();
            Project.DataAccess.Product n = new DataAccess.Product();
            n.ProductName = obj.ProductName;
            n.CategoryName = obj.CategoryName;
            n.Price = obj.Price;
            n.Image = obj.Image;
            n.Size = obj.Size;
            n.Color = obj.Color;
            add.SaveChanges();
            // var v = List();
            return "1";


        }

        public string DataUpdate(Project.DataAccess.Product obj)
        {
            Project.DataAccess.WebsiteEntities update = new DataAccess.WebsiteEntities();
            Project.DataAccess.Product n = new DataAccess.Product();
            var search = update.Products.Where(p => p.ProductId == ProductId).FirstOrDefault();

            search.ProductName = obj.ProductName;
            search.CategoryName = obj.CategoryName;
            search.Price = obj.Price;
            search.Image = obj.Image;
            search.Size = obj.Size;
            search.Color = obj.Color;
            update.SaveChanges();
            // var v = List();
            return "1";


        }

        public string DataRemov(Project.DataAccess.Product obj)
        {
            Project.DataAccess.WebsiteEntities remov = new DataAccess.WebsiteEntities();
            Project.DataAccess.Product n = new DataAccess.Product();
            var search = remov.Products.Where(p => p.ProductId == ProductId).FirstOrDefault();

            search.ProductName = obj.ProductName;
            search.CategoryName = obj.CategoryName;
            search.Price = obj.Price;
            search.Image = obj.Image;
            search.Size = obj.Size;
            search.Color = obj.Color;
            remov.Products.Remove(search);
            remov.SaveChanges();
            // var v = List();
            return "1";


        }

    }
}
