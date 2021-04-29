using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business
{
    class Order
    {
        public int OrderId { get; set; }
        public string CustomeFullName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }

        public List<Project.DataAccess.Cart> List()
        {
            Project.DataAccess.WebsiteEntities ent = new DataAccess.WebsiteEntities();
            var s = ent.Orders.OrderByDescending(p => p.OrderId).ToList();
            return s;
        }
        public string DataAdd(Project.DataAccess.Order obj)
        {
            Project.DataAccess.WebsiteEntities add = new DataAccess.WebsiteEntities();
            Project.DataAccess.Order n = new DataAccess.Order();
            n.CustomeFullName = obj.CustomeFullName;
            n.Address = obj.Address;
            n.Country = obj.Country;
            n.City = obj.City;
            n.Phone = obj.Phone;

            add.SaveChanges();
            // var v = List();
            return "1";


        }

        public string DataUpdate(Project.DataAccess.Order obj)
        {
            Project.DataAccess.WebsiteEntities update = new DataAccess.WebsiteEntities();
            Project.DataAccess.Order n = new DataAccess.Order();
            var search = update.Orders.Where(p => p.OrderId == OrderId).FirstOrDefault();

            search.CustomeFullName = obj.CustomeFullName;
            search.Address = obj.Address;
            search.Country = obj.Country;
            search.City = obj.City;
            search.Phone = obj.Phone;

            update.SaveChanges();
            // var v = List();
            return "1";


        }

        public string DataRemov(Project.DataAccess.Order obj)
        {
            Project.DataAccess.WebsiteEntities remov = new DataAccess.WebsiteEntities();
            Project.DataAccess.Order n = new DataAccess.Order();
            var search = remov.Orders.Where(p => p.OrderId == OrderId).FirstOrDefault();

            search.CustomeFullName = obj.CustomeFullName;
            search.Address = obj.Address;
            search.Country = obj.Country;
            search.City = obj.City;
            search.Phone = obj.Phone;
            remov.Orders.Remove(search);
            remov.SaveChanges();
            // var v = List();
            return "1";


        }
    }
}
