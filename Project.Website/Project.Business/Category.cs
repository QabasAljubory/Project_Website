using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business
{
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<Project.DataAccess.Category> List()
        {
            Project.DataAccess.WebsiteEntities ent = new DataAccess.WebsiteEntities();
            var s = ent.Categories.OrderByDescending(p => p.CategoryId).ToList();
            return s;
        }
        public string DataAdd(Project.DataAccess.Category obj)
        {
            Project.DataAccess.WebsiteEntities add = new DataAccess.WebsiteEntities();
            Project.DataAccess.Category n = new DataAccess.Category();
            n.CategoryName = obj.CategoryName;


            add.SaveChanges();
            // var v = List();
            return "1";


        }

        public string DataUpdate(Project.DataAccess.Category obj)
        {
            Project.DataAccess.WebsiteEntities update = new DataAccess.WebsiteEntities();
            Project.DataAccess.Category n = new DataAccess.Category();
            var search = update.Categories.Where(p => p.CategoryId == CategoryId).FirstOrDefault();

            search.CategoryName = obj.CategoryName;


            update.SaveChanges();
            // var v = List();
            return "1";


        }

        public string DataRemov(Project.DataAccess.Category obj)
        {
            Project.DataAccess.WebsiteEntities remov = new DataAccess.WebsiteEntities();
            Project.DataAccess.Category n = new DataAccess.Category();
            var search = remov.Categories.Where(p => p.CategoryId == CategoryId).FirstOrDefault();

            search.CategoryName = obj.CategoryName;

            remov.Categories.Remove(search);
            remov.SaveChanges();
            // var v = List();
            return "1";


        }
    }
}
