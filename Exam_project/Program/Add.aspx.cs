using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_Click(object sender, EventArgs e)
        {
            var Countriesinlibrary = FileOperation.ReadCountryfromdatabase();
            int counter = 0;
            var Countrytoadd = new Country(this.Country.Text,this.Capital.Text,int.Parse(this.Population.Text));
            foreach (var item in Countriesinlibrary)
            {
                if (Country.Text.ToLower()==item.Name.ToLower())
                {
                    counter++;
                }
            }
            if (FileOperation.Addcountrytodatabase(Countrytoadd)&&counter==0)
            {
                this.messageLabel.Text = "Successfully added country";
                this.Country.Text = string.Empty;
                this.Capital.Text = string.Empty;
                this.Population.Text = string.Empty;
                counter = 0;
            }
          
            else
            {
                this.messageLabel.ForeColor = System.Drawing.Color.Red;
                this.messageLabel.Text = "An error occured while adding the country";
            }
        }
    }
}
