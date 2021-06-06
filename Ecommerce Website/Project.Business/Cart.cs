using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business
{
    public class Cart
    {

        public int CartID { get; set; }
        public string ProdectName { get; set; }
        public string CategoryName { get; set; }
        public string Price { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }

        public List<Project.DataAccess.Cart> Liste()
        {
            Project.DataAccess.Website4Entities ent = new DataAccess.Website4Entities();
            var s = ent.Carts.ToList();
            return s;
        }
        public string DataAdd(Project.DataAccess.Cart obj)
        {
            Project.DataAccess.Website4Entities add = new DataAccess.Website4Entities();
            Project.DataAccess.Cart n = new DataAccess.Cart();
            n.ProdectName = obj.ProdectName;
            n.CategoryName = obj.CategoryName;
            n.Price = obj.Price;
            n.Size = obj.Size;
            n.Color = obj.Color;
            add.SaveChanges();
            // var v = List();
            return "1";


        }

        public string DataUpdate(Project.DataAccess.Cart obj)
        {
            Project.DataAccess.Website4Entities update = new DataAccess.Website4Entities();
            Project.DataAccess.Cart n = new DataAccess.Cart();
            var search = update.Carts.Where(p => p.CartID == CartID).FirstOrDefault();

            search.ProdectName = obj.ProdectName;
            search.CategoryName = obj.CategoryName;
            search.Price = obj.Price;
            search.Size = obj.Size;
            search.Color = obj.Color;
            update.SaveChanges();
            // var v = List();
            return "1";


        }

        public string DataRemov(Project.DataAccess.Cart obj)
        {
            Project.DataAccess.Website4Entities remov = new DataAccess.Website4Entities();
            Project.DataAccess.Cart n = new DataAccess.Cart();
            var search = remov.Carts.Where(p => p.CartID == CartID).FirstOrDefault();

            search.ProdectName = obj.ProdectName;
            search.CategoryName = obj.CategoryName;
            search.Price = obj.Price;
            search.Size = obj.Size;
            search.Color = obj.Color;
            remov.Carts.Remove(search);
            remov.SaveChanges();
            // var v = List();
            return "1";


        }

    }
}
