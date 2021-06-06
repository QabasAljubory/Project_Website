using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Website.electro_master.electro_master
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }

      

        public void Button1_Click1(object sender, EventArgs e)
        {
            Project.Business.Cart object1 = new Business.Cart();
            Project.DataAccess.Cart object2 = new DataAccess.Cart();
            object1.ProdectName = Label6.Text;
            object1.CategoryName = Label5.Text;
            object1.Price = Label1.Text;

            object1.Size = Select1.SelectedIndex.ToString();
            object1.Color = Select2.SelectedIndex.ToString();
            var i = object1.DataAdd(object2);
        }
    }
}