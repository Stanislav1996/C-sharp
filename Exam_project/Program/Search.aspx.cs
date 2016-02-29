using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (int.Parse(toggleActivebox.SelectedValue) == 1)
            {
                Search1.Visible = true;
                Searching.Visible = true;
                FromLabel.Visible = false;
                ToLabel.Visible = false;
                From.Visible = false;
                To.Visible = false;

            }
            if (int.Parse(toggleActivebox.SelectedValue) == 2)
            {
                Search1.Visible = true;
                Searching.Visible = true;
                FromLabel.Visible = false;
                ToLabel.Visible = false;
                From.Visible = false;
                To.Visible = false;

            }
            if (int.Parse(toggleActivebox.SelectedValue) == 3)
            {
                FromLabel.Visible = true;
                ToLabel.Visible = true;
                From.Visible = true;
                To.Visible = true;
                Search1.Visible = false;
                Searching.Visible = false;

            }
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            var Countriesinlibrary = FileOperation.ReadCountryfromdatabase();

            var Countries = new List<Country>();
            foreach (var country in Countriesinlibrary)
            {
                if (int.Parse(toggleActivebox.SelectedValue) == 3 && int.Parse(From.Text)<country.Population && int.Parse(To.Text) > country.Population)
                {
                    Countries.Add(country);
                    this.Error.Text = "";
                }
                if (int.Parse(toggleActivebox.SelectedValue) == 2 && Searching.Text==country.Capital)
                {
                    Countries.Add(country);
                    this.Error.Text = "";
                }
                if (int.Parse(toggleActivebox.SelectedValue) == 1 && Searching.Text == country.Name)
                {
                    Countries.Add(country);
                    this.Error.Text = "";
                }
            }
            if (Countries.Count == 0)
            {
                this.Error.Text = "No results found";
            }
            this.CountryRepeater.DataSource = Countries;
            this.CountryRepeater.DataBind();
        }
    }
}