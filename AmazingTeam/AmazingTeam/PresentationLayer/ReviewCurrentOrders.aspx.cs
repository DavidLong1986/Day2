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
    public partial class ReviewCurrentOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();
           

            DataSet OrderDataSet;
            OrderDataSet = Controller.LoadAllActiveOrders();
            if (OrderDataSet.Tables[0].Rows.Count > 0)
            {
                gvAllActiveOrders.DataSource = OrderDataSet;
                gvAllActiveOrders.DataBind();

                lbMsg.Text = gvAllActiveOrders.Rows.Count + " Active Customer Orders Retrieved ...";
            }
            else
            {
                {
                    lbMsg.Text = gvAllActiveOrders.Rows.Count + " Active Customer Orders Retrieved ...";

                }
            }

        }
        protected void gvAllActiveOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedOrder = Convert.ToInt32(gvAllActiveOrders.Rows[gvAllActiveOrders.SelectedIndex].Cells[1].Text.ToString());

            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

            if (Controller.DeactiveSelectedOrder(selectedOrder))
            {

                lbMsg.Text = "Selected Order Deactivated/Deleted Successfully...";
                DataSet EnqDataSet;
                EnqDataSet = Controller.LoadAllActiveOrders();
                if (EnqDataSet.Tables[0].Rows.Count > 0)
                {

                    gvAllActiveOrders.DataSource = EnqDataSet;
                    gvAllActiveOrders.DataBind();

                }
                else
                {

                    gvAllActiveOrders.DataSource = EnqDataSet;
                    gvAllActiveOrders.DataBind();

                    lbMsg.Text = gvAllActiveOrders.Rows.Count + " Active Customer Orders Retrieved ...";

                    gvAllActiveOrders.Visible = false;

                }

            }
            else
            {
                lbMsg.Text = "Selected Order Could not be De-Activated/Deleted...";
            }


        }


    }
}