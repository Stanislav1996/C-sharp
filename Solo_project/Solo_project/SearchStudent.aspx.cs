using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solo_project
{
    public partial class SearchStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {

            var Studentsinlibrary = FileOperations.ReadStudentsfromdatabase();
            foreach (var student in Studentsinlibrary)
            {
                if (student.Faculty_number==int.Parse(this.Fac_searching.Text))
                {
                    this.Name.Text = student.Name;
                    
                    this.Faculty.Text = student.Faculty;
                    this.FACnumber.Text = student.Faculty_number.ToString();
                    this.Avenger.Text = student.Avg.ToString();
                }
            }
        }
    }
}