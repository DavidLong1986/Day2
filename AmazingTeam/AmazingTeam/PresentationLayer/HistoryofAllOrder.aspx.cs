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
using System.Globalization;

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
            string Status = "GO";
            string Message1 = "";
            string Message2 = "";
            string ValdateDateFrom = "00/00/0000";
            string ValdateDateTo = "00/00/0000";

            DateTime CheckDateFrom;
            DateTime CheckDateTo;

            if (DateTime.TryParseExact(OrderFromDate.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out CheckDateFrom))
            {
                ValdateDateFrom = CheckDateFrom.ToString();
            }
            else
            {
                Status = "Stop";
                Message1 = "-Order From Date must be a date and must be in this format: MM/DD/YYYY" + " " + System.Environment.NewLine + Message1 + " " + System.Environment.NewLine;
            }

            if (DateTime.TryParseExact(OrderToDate.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out CheckDateTo))
            {
                ValdateDateTo = CheckDateTo.ToString();
            }
            else
            {
                Status = "Stop";
                Message2 = "-Order To Date must be a date and must be in this format: MM/DD/YYYY" + " " + System.Environment.NewLine + Message2 + " " + System.Environment.NewLine;
            }



            if (Status != "Stop")
            {
                HistoryOfAllOrderTable = Controller.HistoryOfAllOrders(ValdateDateFrom, ValdateDateTo).Tables[0];

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
            else
            {
                MessageLine.Text = Message1;
                MessageLineTwo.Text = Message2;
            }

        }
    }
}