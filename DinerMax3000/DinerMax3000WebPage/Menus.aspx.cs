using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Menus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MenusPageCount"] == null)
        {
            Session["MenusPageCount"] = 0;
        }
        Session["MenusPageCount"] = (int) Session["MenusPageCount"]+1;
    }
    protected void gvMenu_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //This is how the inner Grid is going to pull in its data from the Bussiness Layer for Menu Items
            GridView innerGridView = (GridView)e.Row.FindControl("gvMenuItems");
            //THis is setting the data for that inner grid to the actual menu items
            innerGridView.DataSource = ((DinerMax3000.BusinessLayer.Menu)e.Row.DataItem).items;
            innerGridView.DataBind();
        }
    }
}