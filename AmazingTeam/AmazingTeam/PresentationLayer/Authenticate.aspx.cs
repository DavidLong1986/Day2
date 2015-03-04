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
    public partial class Authenticate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void LoginIn_Click1(object sender, EventArgs e)
        {
            
            try
            {

                AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

                DataTable Mytable = null;


                Mytable = Controller.LookupUserIDPassword(UserName.Text, Password.Text, SecretAnswer.Text).Tables[0];




                if (Mytable.Rows.Count == 0)
                {
                    MessageLine.Text = "Invalid User ID or Password or secret question's respond";

                }
                else
                {
                    Server.Transfer("~/PresentationLayer/AddFindUpdateDeleteMenu.aspx");
                }

            }
            catch (Exception ex)
            {
                MessageLine.Text = ex.Message;
            }
        }
    }
}