using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solo_project
{
    public partial class Sorting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var listofstudents = FileOperations.ReadStudentsfromdatabase();
            var sortedlist = listofstudents.OrderByDescending(x => x.Avg);


            this.Studenttorepeat.DataSource = sortedlist;
            this.Studenttorepeat.DataBind();
        }
    }
}