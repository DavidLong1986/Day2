using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Collections;
using System.Diagnostics;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Mail;
using System.Xml.Linq;
using System.Collections.Specialized;
using System.Net.Mime;
using System.ComponentModel;

namespace AmazingTeam.PresentationLayer
{
    public partial class ApproveTestimonial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

            DataSet TestDataSet;

            TestDataSet = Controller.FindTestimonial(); //Controller.LoadAllActiveOrders();
            if (TestDataSet.Tables[0].Rows.Count > 0)
            {
                DynamicTable.DataSource = TestDataSet;
                DynamicTable.DataBind();

                MessageLabel.Text = DynamicTable.Rows.Count + " Testimonial Retrieved ...";
            }
            else
            {
                {
                    MessageLabel.Text = "No Testimonial Retrieved...";
                }
            }
       
        }    
  

protected void Like_Click(object sender, EventArgs e)
{
    AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

    int ActiveStatus = 1;
    string Status = "GO";
    int TestimonialID = 0;

    int TestQuantity;
    if (int.TryParse(TestimonialNumber.Text, out TestQuantity))
    {
        TestimonialID = TestQuantity;
    }
    else
    {
        Status = "Stop";
        MessageLabel.Text = "-Testimonial ID must exist and must be Numeric";
    }

    if (Status != "Stop")
    {
        if (Controller.LikeTestimonial(ActiveStatus, TestimonialID))
        {
            MessageLabel.Text = "Testimonial is approved";
        }
        else
        {
            MessageLabel.Text = "Testimonial is not approved";
        }
        Response.Redirect(Request.RawUrl);
    }
}

protected void Dislike_Click(object sender, EventArgs e)
{
    AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

    int ActiveStatus = 0;
    string Status = "GO";
    int TestimonialID = 0;

    int TestQuantity;
    if (int.TryParse(TestimonialNumber.Text, out TestQuantity))
    {
        TestimonialID = TestQuantity;
    }
    else
    {
        Status = "Stop";
        MessageLabel.Text = "-Testimonial ID must exist and must be Numeric";
    }


    if (Status != "Stop")
    {
        if (Controller.DislikeTestimonial(ActiveStatus, TestimonialID))
        {
            MessageLabel.Text = "Testimonial is unpproved";
        }
        else
        {
            MessageLabel.Text = "Testimonial is not unapproved";
        }
        Response.Redirect(Request.RawUrl);
    }
}

}
        
    }