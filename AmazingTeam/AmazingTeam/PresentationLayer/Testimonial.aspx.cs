﻿using System;
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
    public partial class Testimonial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

            DataSet TestDataSet = Controller.FindApprovedTestimonial();

            foreach (DataTable Table in TestDataSet.Tables)
            {
                TableRow tblrow = new TableRow();
                DynamicTable.Rows.Add(tblrow);

                foreach (DataColumn Column in Table.Columns)
                {
                    TableCell tblcell = new TableCell();
                    tblcell.Text = Column.ColumnName;
                    tblrow.Cells.Add(tblcell);
                }
                foreach (DataRow row in Table.Rows)
                {
                    tblrow = new TableRow();
                    DynamicTable.Rows.Add(tblrow);
                    for (int index = 0; index <= Table.Columns.Count - 1; index++)
                    {
                        TableCell newcell = new TableCell();
                        newcell.Text = row[index].ToString();
                        tblrow.Cells.Add(newcell);
                    }
                }
            }

       

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

            try
            {

                Controller.AddCustomerTestimonial(RateC2.SelectedValue, Name.Text, InputComments.Text);

                MessageLabel.Text = "Thanks for your testimonial";
            }
            catch (Exception ex)
            {
                MessageLabel.Text = ex.Message;
            }
        }

    }
}