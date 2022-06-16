using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace codebaseexam4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private List<float> prices = new List<float>();
        private List<String> products = new List<String>();


        protected void Page_Load(object sender, EventArgs e)
        {
            products.Add("Camera");
            products.Add("Headphone");
            products.Add("Mobile");
            products.Add("Smartwatch");
            prices.Add((float)30000.00);
            prices.Add((float)25000.00);
            prices.Add((float)15000.00);
            prices.Add((float)40000.00);

        }
        protected void ProductDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductDropDown.SelectedItem.Value.Equals(""))
            {
                ProductImage.Visible = false;
                ProductPrice.Visible = false;
                Price.Visible = false;
                Message.Text = "Select one product";
            }
            else
            {
                Message.Text = "You Selected: " + ProductDropDown.SelectedItem.Value;
                ProductImage.ImageUrl = "~/Content/" + ProductDropDown.SelectedItem.Value + ".jpg";
                ProductImage.Visible = true;
                Price.Visible = true;

            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            ProductPrice.Visible = true;
            ProductPrice.Text = "Price Rs. " + prices.ElementAt(products.IndexOf(ProductDropDown.SelectedItem.Value));
        }
    }
}