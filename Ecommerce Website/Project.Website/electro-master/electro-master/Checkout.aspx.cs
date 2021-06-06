using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Project.Website.electro_master.electro_master
{
    public partial class Checkout : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Project.Business.Cart object1 = new Business.Cart();
            
            var i = object1.Liste();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Project.Business.Customer object1 = new Business.Customer();
            Project.DataAccess.Customer object2 = new DataAccess.Customer();
            object1.CustomerFullName = TextBox1.Text;
            object1.Address = TextBox2.Text;
            object1.Conutry = TextBox3.Text;
            object1.City = TextBox4.Text;
            object1.Phone = Convert.ToInt32(TextBox5.Text);
            var i = object1.DataAdd(object2);
        }
    }
}