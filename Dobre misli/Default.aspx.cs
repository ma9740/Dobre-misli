using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dobre_misli
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["Misli"] == null) {
                Application["Misli"] = new List<String>();
            }
        }

        protected void dodajMisel_Click(object sender, EventArgs e)
        {
            var misli = (List<String>)Application["Misli"];
            misli.Insert(0, misel.Text);

            foreach (var text in misli) {
                var label = new Label();
                label.Text = "\"" + text + "\"" + new HtmlString("<br />");
                FindControl("misli").Controls.Add(label);
            }
        }
    }
    
}