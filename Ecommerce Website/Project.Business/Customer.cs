using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerFullName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Conutry { get; set; }
        public int Phone { get; set; }


        public List<Project.DataAccess.Customer> List()
        {
            Project.DataAccess.Website4Entities ent = new DataAccess.Website4Entities();
            var s = ent.Customers.ToList();
            return s;
        }
        public string DataAdd(Project.DataAccess.Customer obj)
        {
            Project.DataAccess.Website4Entities add = new DataAccess.Website4Entities();
            Project.DataAccess.Customer n = new DataAccess.Customer();
            n.CustomerFullName = obj.CustomerFullName;
            n.Address = obj.Address;
            n.City = obj.City;
            n.Conutry = obj.Conutry;
            n.Phone = obj.Phone;

            add.SaveChanges();
           // var v = List();
            return "1";


        }

        public string DataUpdate(Project.DataAccess.Customer obj)
        {
            Project.DataAccess.Website4Entities update = new DataAccess.Website4Entities();
            Project.DataAccess.Customer n = new DataAccess.Customer();
            var search = update.Customers.Where(p => p.CustomerID == CustomerID).FirstOrDefault();

            search.CustomerFullName = obj.CustomerFullName;
            search.Address = obj.Address;
            search.City = obj.City;
            search.Conutry = obj.Conutry;
            search.Phone = obj.Phone;

            update.SaveChanges();
            // var v = List();
            return "1";


        }

        public string DataRemov(Project.DataAccess.Customer obj)
        {
            Project.DataAccess.Website4Entities remov = new DataAccess.Website4Entities();
            Project.DataAccess.Customer n = new DataAccess.Customer();
            var search = remov.Customers.Where(p => p.CustomerID == CustomerID).FirstOrDefault();

            search.CustomerFullName = obj.CustomerFullName;
            search.Address = obj.Address;
            search.City = obj.City;
            search.Conutry = obj.Conutry;
            search.Phone = obj.Phone;
            remov.Customers.Remove(search);
            remov.SaveChanges();
            // var v = List();
            return "1";


        }
    }
}
