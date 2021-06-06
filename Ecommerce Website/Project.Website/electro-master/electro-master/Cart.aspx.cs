using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Website.electro_master.electro_master
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Project.Business.Cart object1 = new Business.Cart ();

            var i = object1.Liste();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                Project.Business.Cart object1 = new Business.Cart();
                Project.DataAccess.Cart object2 = new DataAccess.Cart();
            object1.ProdectName = Label1.Text;
            object1.CategoryName = Label2.Text;
            object1.Price = Label3.Text;
            object1.Size = Label4.Text;
            object1.Color = Label5.Text;
            var i = object1.DataRemov(object2);
                
            
            
        }
    }
}