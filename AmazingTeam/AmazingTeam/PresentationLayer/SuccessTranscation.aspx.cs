using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Collections;
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
    public partial class SuccessTranscation : System.Web.UI.Page
    {
       // public const string StrConn = "Server=tcp:j5ldchdajd.database.windows.net,1433;Database=AmazingTeamDatabase;User ID=AmazingTeam@j5ldchdajd;Password=Baist3990?;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";

        AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

        void Send_download_link(string from, string to, string subject, string body)
        {
            try
            {  // Construct a new e-mail message 
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("amazingtestbaist3990@gmail.com", "Amazingtest3990?");
                client.Send(from, to, subject, body);

            }
            catch (SmtpException ex)
            {
                debuggy.Text = "Send_download_link: " + ex.Message;

            }
        } 
        protected void Page_Load(object sender, EventArgs e)
        {
            //Post back to either sandbox or live
            string strSandbox = "https://www.sandbox.paypal.com/cgi-bin/webscr";
            string strLive = "https://www.paypal.com/cgi-bin/webscr";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(strSandbox);
            //Set values for the request back
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            byte[] param = Request.BinaryRead(HttpContext.Current.Request.ContentLength);
            string strRequest = Encoding.ASCII.GetString(param);
            string strResponse_copy = strRequest;  //Save a copy of the initial info sent by PayPal
            strRequest += "&cmd=_notify-validate";
            req.ContentLength = strRequest.Length;

            //Send the request to PayPal with sames message and get the response
            StreamWriter streamOut = new StreamWriter(req.GetRequestStream(), System.Text.Encoding.ASCII);
            streamOut.Write(strRequest);
            streamOut.Close();
            StreamReader streamIn = new StreamReader(req.GetResponse().GetResponseStream());
            string strResponse = streamIn.ReadToEnd();
            streamIn.Close();

            if (strResponse == "VERIFIED")
            {
                
                // pull the values passed on the initial message from PayPal

                NameValueCollection these_argies = HttpUtility.ParseQueryString(strResponse_copy);
                string user_email = these_argies["payer_email"];
                string pay_stat = these_argies["payment_status"];
                string payer_fristName = these_argies["first_name"];
                string payer_LastName = these_argies["last_name"];
                string pay_date = these_argies["payment_date"];

                //Item Name
                string paid_Item_1 = these_argies["item_name1"];
                string paid_Item_2 = these_argies["item_name2"];
                string paid_Item_3 = these_argies["item_name3"];
                string paid_Item_4 = these_argies["item_name4"];
                string paid_Item_5 = these_argies["item_name5"];
                string paid_Item_6 = these_argies["item_name6"];
                string paid_Item_7 = these_argies["item_name7"];
                string paid_Item_8 = these_argies["item_name8"];
                string paid_Item_9 = these_argies["item_name9"];
                string paid_Item_10 = these_argies["item_name10"];
                string paid_Item_11 = these_argies["item_name11"];
                string paid_Item_12 = these_argies["item_name12"];

                //Item ID
                string paid_ItemId_1 = these_argies["item_number1"];
                string paid_ItemId_2 = these_argies["item_number2"];
                string paid_ItemId_3 = these_argies["item_number3"];
                string paid_ItemId_4 = these_argies["item_number4"];
                string paid_ItemId_5 = these_argies["item_number5"];
                string paid_ItemId_6 = these_argies["item_number6"];
                string paid_ItemId_7 = these_argies["item_number7"];
                string paid_ItemId_8 = these_argies["item_number8"];
                string paid_ItemId_9 = these_argies["item_number9"];
                string paid_ItemId_10 = these_argies["item_number10"];
                string paid_ItemId_11 = these_argies["item_number11"];
                string paid_ItemId_12 = these_argies["item_number12"];

                // For Quantity 
                string paid_Quantity_1 = these_argies["quantity1"];
                string paid_Quantity_2 = these_argies["quantity2"];
                string paid_Quantity_3 = these_argies["quantity3"];
                string paid_Quantity_4 = these_argies["quantity4"];
                string paid_Quantity_5 = these_argies["quantity5"];
                string paid_Quantity_6 = these_argies["quantity6"];
                string paid_Quantity_7 = these_argies["quantity7"];
                string paid_Quantity_8 = these_argies["quantity8"];
                string paid_Quantity_9 = these_argies["quantity9"];
                string paid_Quantity_10 = these_argies["quantity10"];
                string paid_Quantity_11 = these_argies["quantity11"];
                string paid_Quantity_12 = these_argies["quantity12"];

                string paid_txn_id = these_argies["txn_id"];
                string paid_mc_gross = these_argies["mc_gross"];
                string receiverEmail = these_argies["receiver_email"];


                // accept a few different date formats because of PST/PDT timezone and slight month difference in sandbox vs. prod.

                string[] dateFormats = { "HH:mm:ss MMM dd, yyyy PST", "HH:mm:ss MMM. dd, yyyy PST", "HH:mm:ss MMM dd, yyyy PDT", "HH:mm:ss MMM. dd, yyyy PDT" };
                DateTime outputDateTime;

                DateTime.TryParseExact(pay_date, dateFormats, new System.Globalization.CultureInfo("en-US"), System.Globalization.DateTimeStyles.None, out outputDateTime);

                // convert to local timezone

                outputDateTime = outputDateTime.AddHours(1);



            string List_Item = "Items are: " + paid_Item_1 + " = " + paid_Quantity_1 + ", " + paid_Item_2 + " = " + paid_Quantity_2 + ", " + paid_Item_3 + " = " + paid_Quantity_3 + ", " + paid_Item_4 + " = " + paid_Quantity_4 + ", " + paid_Item_5 + " = " + paid_Quantity_5 + ", " + paid_Item_6 + " = " + paid_Quantity_6 + ", " + paid_Item_7 + " = " + paid_Quantity_7 + ", " + paid_Item_8 + " = " + paid_Quantity_8 + ", " + paid_Item_9 + " = " + paid_Quantity_9 + ", " + paid_Item_10 + " = " + paid_Quantity_10 +", " + paid_Item_11 + " = " + paid_Quantity_11 + ", " + paid_Item_12 + " = " + paid_Quantity_12;



                if (pay_stat.Equals("Completed"))
                {

                    Send_download_link("amazingtestbaist3990@gmail.com", "amazingtestbaist3990@gmail.com", "There is new order " + payer_fristName + " " + payer_LastName, "order on " + pay_date + List_Item + " " + System.Environment.NewLine + "TxnId = " + paid_txn_id + " " + System.Environment.NewLine + "Gross = " + paid_mc_gross + " ");

                    //The reason why the Lister is not at the Business Layer is because that speed is need here
                    //Or else Paypal send another IPN a every second. 

                    Controller.VerifedCustomerOrder(user_email, payer_fristName, payer_LastName, paid_ItemId_1, paid_ItemId_2, paid_ItemId_3, paid_ItemId_4, paid_ItemId_5, paid_ItemId_6, paid_ItemId_7, paid_ItemId_8, paid_ItemId_9, paid_ItemId_10, paid_ItemId_11, paid_ItemId_12, paid_txn_id,outputDateTime);

                }
            }
            else if (strResponse == "INVALID")
            {
                //log for manual investigation
            }
            else
            {
                //log response/ipn data for manual investigation
            }
        }


       
                
                





                    












    }
}