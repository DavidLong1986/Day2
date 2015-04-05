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
    public partial class ReviewCustomerEnquiries : System.Web.UI.Page
    {


            protected void gvAllActive_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedEnq =Convert.ToInt32( gvAllActive.Rows[gvAllActive.SelectedIndex].Cells[1].Text.ToString());
       
       

        AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();
        
        if (Controller.DeactiveSelectedEnq(selectedEnq))
        {
            DataSet EnqDataSet;
            
            EnqDataSet = Controller.LoadAllActiveEnquiries();
            if (EnqDataSet.Tables[0].Rows.Count > 0)
            {
//------------ * New Line ------------------------
		int deactivatedEnq = 0;
                
		gvAllActive.DataSource = EnqDataSet;
                gvAllActive.DataBind();

                

                lbMsg.Text = gvAllActive.Rows.Count + " Active Customer Enquiries Retrived ... \n";

//------------ * New Line ------------------------                
		deactivatedEnq++;
                lbDAMsg.Text = deactivatedEnq + " Customer Enquiries Deactivated ...\n";
            }
            else  
            {
                gvAllActive.DataSource = EnqDataSet;
                gvAllActive.DataBind();

                lbMsg.Text = gvAllActive.Rows.Count + " Active Customer Enquiries Retrived ...";


                gvAllActive.Visible = false;
            }
            
        }
        else
        {
            lbMsg.Text = "Selected Enquiry Could not be De-Activated/Deleted...";
        }
        
    }

//------------ * New Line ------------------------

    protected void Page_Load(object sender, EventArgs e)
    {


        AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();
        DataSet EnqDataSet;

        EnqDataSet = Controller.LoadAllActiveEnquiries();
        if (EnqDataSet.Tables[0].Rows.Count > 0)
        {
            gvAllActive.DataSource = EnqDataSet;
            gvAllActive.DataBind();

            lbMsg.Text = gvAllActive.Rows.Count + " Active Customer Enquiries Retrived ...";
        }
        else
        {
            {
                lbMsg.Text = gvAllActive.Rows.Count + " Active Customer Enquiries Retrived ...";

            }
        }

    }
    }
}