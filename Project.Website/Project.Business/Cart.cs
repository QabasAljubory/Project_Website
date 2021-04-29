using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business
{
     class Cart
    {
        public int CartId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Subtotal { get; set; }
        public string Delivery { get; set; }
        public string Discount { get; set; }
        public string Total { get; set; }
        public string Quantity { get; set; }


        public List<Project.DataAccess.Cart> List()
        {
            Project.DataAccess.WebsiteEntities ent = new DataAccess.WebsiteEntities();
            var s = ent.Carts.OrderByDescending(p => p.CartId).ToList();
            return s;
        }
        public string DataAdd(Project.DataAccess.Cart obj)
        {
            Project.DataAccess.WebsiteEntities add = new DataAccess.WebsiteEntities();
            Project.DataAccess.Cart n = new DataAccess.Cart();
            n.Subtotal = obj.Subtotal;
            n.Delivery = obj.Delivery;
            n.Discount = obj.Discount;
            n.Total = obj.Total;
            n.Quantity = obj.Quantity;

            add.SaveChanges();
            // var v = List();
            return "1";


        }

        public string DataUpdate(Project.DataAccess.Cart obj)
        {
            Project.DataAccess.WebsiteEntities update = new DataAccess.WebsiteEntities();
            Project.DataAccess.Cart n = new DataAccess.Cart();
            var search = update.Carts.Where(p => p.CartId == CartId).FirstOrDefault();

            search.Subtotal = obj.Subtotal;
            search.Delivery = obj.Delivery;
            search.Discount = obj.Discount;
            search.Total = obj.Total;
            search.Quantity = obj.Quantity;

            update.SaveChanges();
            // var v = List();
            return "1";


        }

        public string DataRemov(Project.DataAccess.Cart obj)
        {
            Project.DataAccess.WebsiteEntities remov = new DataAccess.WebsiteEntities();
            Project.DataAccess.Cart n = new DataAccess.Cart();
            var search = remov.Carts.Where(p => p.ProductId == ProductId).FirstOrDefault();

            search.Subtotal = obj.Subtotal;
            search.Delivery = obj.Delivery;
            search.Discount = obj.Discount;
            search.Total = obj.Total;
            search.Quantity = obj.Quantity;
            remov.Carts.Remove(search);
            remov.SaveChanges();
            // var v = List();
            return "1";


        }
    }
}
