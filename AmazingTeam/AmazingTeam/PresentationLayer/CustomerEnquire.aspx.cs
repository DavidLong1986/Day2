using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmazingTeam.PresentationLayer
{
    public partial class CustomerEnquire : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

            try
            {

                Controller.AddCustomerEnquries(TypeOfQuestion.SelectedValue, InputName.Text, InputEmail.Text, InputMessage.Text);

                MessageLabel.Text = "Your Enquiry has been submitted";
            }
            catch (Exception ex)
            {
                MessageLabel.Text = ex.Message;
            }
        }
    }
}