using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
using System.Collections;
using System.Data;
using System.Diagnostics;

namespace AmazingTeam.PresentationLayer
{
    public partial class HistoryofAllOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitDates_Click(object sender, EventArgs e)
        {   
            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

            DataTable HistoryOfAllOrderTable = null;

            HistoryOfAllOrderTable = Controller.HistoryOfAllOrders(OrderFromDate.Text, OrderToDate.Text).Tables[0];

            if (HistoryOfAllOrderTable.Rows.Count == 0)
            {
                HistoryOfAllOrderGrid.Visible = false;

                MessageLine.Text = "";
                MessageLine.Text = HistoryOfAllOrderTable.Rows.Count + "  History of all  Orders Found";

            }

            else
            {
                HistoryOfAllOrderTable.DefaultView.Sort = "CustomerID";

                //bind this to the grid
                HistoryOfAllOrderGrid.DataSource = HistoryOfAllOrderTable;
                HistoryOfAllOrderGrid.DataBind();
                HistoryOfAllOrderGrid.Visible = true;
                MessageLine.Text = HistoryOfAllOrderTable.Rows.Count + "  History of all  Orders Found";
            }

        }
    }
}