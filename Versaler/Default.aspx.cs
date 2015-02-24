using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(Page.IsPostBack) {
                int count = TextAnalyzer.GetNumberOfCapitals(TextBox1.Text);

                //Gör fältet gråmarkerat
                TextBox1.Enabled = false;

                //Skriv ut antalet versaler
                Message.Text = String.Format("Det finns {0} versaler i texten.",count);

                if (Button1.Text == "Rensa")
                {
                    //Ta bort gråmarkering från fältet
                    TextBox1.Enabled = true;
                    TextBox1.Text = "";
                    Message.Text = "";
                    Button1.Text = "Bestäm antalet versaler";
                }
                else
                {
                    Button1.Text = "Rensa";
                }


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
            }
        }
    }
}