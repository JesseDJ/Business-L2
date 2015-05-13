using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if the form was not submitted, clear out message
            if(!IsPostBack)
            {
                lblMessage.Text = "";
            }
        }

        protected void btnCopyText_Click(object sender, EventArgs e)
        {
            //copythe textbox text to the label
            lblMessage.Text = txtMessage.Text;
            btnCopyText.Enabled = false;

        }

        protected void btnShowSelections_Click(object sender, EventArgs e)
        {
            //clear out the previous label first
            lblToppings.Text = "";
            //loop through the list of checkboxes
            foreach (ListItem topping in cblToppings.Items)
            {
                //check if the current item is checked or not
                if (topping.Selected)
                {
                    lblToppings.Text += topping.Text + " ";
                }
            }

            //display the users selected choice
            lblSize.Text = ddlSize.SelectedItem.Text;
        }

        protected void cblToppings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}