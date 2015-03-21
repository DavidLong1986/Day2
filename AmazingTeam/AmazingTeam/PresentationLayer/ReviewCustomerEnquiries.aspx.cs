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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoadActiveEnquires_Click(object sender, EventArgs e)
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
                    lbMsg.Text = "  No Active Enquiry...";
                }
            }
        }
        protected void gvAllActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedEnq = Convert.ToInt32(gvAllActive.Rows[gvAllActive.SelectedIndex].Cells[1].Text.ToString());

            
            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

            if (Controller.DeactiveSelectedEnq(selectedEnq))
            {
                lbMsg.Text = "Selected Enquiry Deactivated Successfully...";
                DataSet EnqDataSet;

                EnqDataSet = Controller.LoadAllActiveEnquiries();
                if (EnqDataSet.Tables[0].Rows.Count > 0)
                {
                    gvAllActive.DataSource = EnqDataSet;
                    gvAllActive.DataBind();
                }
                else
                {
                    lbMsg.Text = "No more Active Enquiries...";
                    gvAllActive.Visible = false;
                }

            }
            else
            {
                lbMsg.Text = "Selected Enquiry Could not be De-Activated/Deleted...";
            }

        }
    }
}