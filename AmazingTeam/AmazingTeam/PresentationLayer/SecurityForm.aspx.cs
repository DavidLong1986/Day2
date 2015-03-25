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
    public partial class SecurityForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                Control placeholder = PreviousPage.Controls[0].FindControl("ContentPlaceHolderBody");
                TextBox SourceTextBox =
                    (TextBox)placeholder.FindControl("UserName");
                if (SourceTextBox != null)
                {
                    MessageLine1.Text = SourceTextBox.Text;
                }
            }

            if (PreviousPage != null)
            {
                Control placeholder = PreviousPage.Controls[0].FindControl("ContentPlaceHolderBody");
                TextBox SourceTextBox2 =
                    (TextBox)placeholder.FindControl("Password");
                if (SourceTextBox2 != null)
                {
                    MessageLine2.Text = SourceTextBox2.Text;
                }

                MessageLine1.Visible = false;
                MessageLine2.Visible = false;
            }
        }

        protected void BtnSumit_Click(object sender, EventArgs e)
        {
            try
            {
                AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

                DataTable Mytable = null;
                Mytable = Controller.LookupSecretQuestionRespond(MessageLine1.Text, MessageLine2.Text, Respond.Text).Tables[0];
 
                if (Mytable.Rows.Count == 0)
                {
                    MessageLine3.Text = "Invalid Respond ";

                }
                else
                {
                    Server.Transfer("~/PresentationLayer/AddFindUpdateDeleteMenu.aspx");
                }

            }
            catch (Exception ex)
            {
                MessageLine3.Text = ex.Message;
            }
        }
    }
    
}