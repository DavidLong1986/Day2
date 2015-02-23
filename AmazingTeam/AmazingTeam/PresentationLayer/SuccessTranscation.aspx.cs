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
        public const string StrConn = "Server=tcp:j5ldchdajd.database.windows.net,1433;Database=AmazingTeamDatabase;User ID=AmazingTeam@j5ldchdajd;Password=Baist3990?;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
        
        void Send_download_link(string from, string to, string subject, string body)
        {
            try
            {  // Construct a new e-mail message 
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("davidlong1986@gmail.com", "Castlevania9826159st?");
                client.Send(from, to, subject, body);

            }
            catch (SmtpException ex)
            {
                debuggy.Text = "Send_download_link: " + ex.Message;

            }
        } // --- end of Send_downloa
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

            //for proxy
            //WebProxy proxy = new WebProxy(new Uri("http://url:port#"));
            //req.Proxy = proxy;

            //Send the request to PayPal and get the response
            StreamWriter streamOut = new StreamWriter(req.GetRequestStream(), System.Text.Encoding.ASCII);
            streamOut.Write(strRequest);
            streamOut.Close();
            StreamReader streamIn = new StreamReader(req.GetResponse().GetResponseStream());
            string strResponse = streamIn.ReadToEnd();
            streamIn.Close();

            if (strResponse == "VERIFIED")
            {
                //check the payment_status is Completed
                //check that txn_id has not been previously processed
                //check that receiver_email is your Primary PayPal email
                //check that payment_amount/payment_currency are correct
                //process payment

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

                string paid_txn_id = these_argies["txn_id"];
                string paid_mc_gross = these_argies["mc_gross"];
                string receiverEmail = these_argies["receiver_email"];


            // accept a few different date formats because of PST/PDT timezone and slight month difference in sandbox vs. prod.
            string[] dateFormats = { "HH:mm:ss MMM dd, yyyy PST", "HH:mm:ss MMM. dd, yyyy PST", "HH:mm:ss MMM dd, yyyy PDT", "HH:mm:ss MMM. dd, yyyy PDT" };
            DateTime outputDateTime;

            DateTime.TryParseExact(pay_date, dateFormats, new System.Globalization.CultureInfo("en-US"), System.Globalization.DateTimeStyles.None, out outputDateTime);

            // convert to local timezone
            outputDateTime = outputDateTime.AddHours(1);

         

                string List_Item = " Your Items are: " + paid_ItemId_1 + " = " + paid_Quantity_1 + ", " + paid_ItemId_2 + " = " + paid_Quantity_2 + ", " + paid_ItemId_3 + " = " + paid_Quantity_3 + ", " + paid_ItemId_4 + " = " + paid_Quantity_4 + ", " + paid_Item_5 + " = " + paid_Quantity_5 + ", " + paid_Item_6 + " = " + paid_Quantity_6 + ", " + paid_Item_7 + " = " + paid_Quantity_7 + ", " + paid_Item_8 + " = " + paid_Quantity_8 + ", " + paid_Item_9 + " = " + paid_Quantity_9 + ", " + paid_Item_10 + " = " + paid_Quantity_10;



                if (pay_stat.Equals("Completed"))
                {
                    Send_download_link("davidlong1986@gmail.com", "davidlong1986@gmail.com", "Your order for " + payer_fristName + " " + payer_LastName, "Thanks for your order on " + pay_date + List_Item + " " + System.Environment.NewLine + "TxnId = " + paid_txn_id + " " + System.Environment.NewLine + "Gross = " + paid_mc_gross + " ");


                    //The reason why the Lister is not at the Business Layer is because that speed is need here
                    //Or else Paypal send another IPN a every second. 
                    using (SqlConnection myConnection = new SqlConnection(StrConn))
                    {

                        SqlCommand commamd = new SqlCommand("AddCustomerOrder", myConnection);
                        commamd.CommandType = CommandType.StoredProcedure;

                        commamd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = user_email;
                        commamd.Parameters.Add("@CustomerFirstName", SqlDbType.NVarChar).Value = payer_fristName;
                        commamd.Parameters.Add("@CustomerLastName", SqlDbType.NVarChar).Value = payer_LastName;


                        commamd.Parameters.Add("@ProductIDOne", SqlDbType.Int).Value = Convert.ToInt32(paid_ItemId_1);
                        commamd.Parameters.Add("@ProductIDTwo", SqlDbType.Int).Value = Convert.ToInt32(paid_ItemId_2);
                        commamd.Parameters.Add("@ProductIDThree", SqlDbType.Int).Value = Convert.ToInt32(paid_ItemId_3);
                        commamd.Parameters.Add("@ProductIDFour", SqlDbType.Int).Value = Convert.ToInt32(paid_ItemId_4);
                        commamd.Parameters.Add("@ProductIDFive", SqlDbType.Int).Value = Convert.ToInt32(paid_ItemId_5);
                        commamd.Parameters.Add("@ProductIDSix", SqlDbType.Int).Value = Convert.ToInt32(paid_ItemId_6);
                        commamd.Parameters.Add("@ProductIDSeven", SqlDbType.Int).Value = Convert.ToInt32(paid_ItemId_7);
                        commamd.Parameters.Add("@ProductIDEight", SqlDbType.Int).Value = Convert.ToInt32(paid_ItemId_8);
                        commamd.Parameters.Add("@ProductIDNine", SqlDbType.Int).Value = Convert.ToInt32(paid_ItemId_9);
                        commamd.Parameters.Add("@ProductIDTen", SqlDbType.Int).Value = Convert.ToInt32(paid_ItemId_10);


                        commamd.Parameters.Add("@TranscationID", SqlDbType.NVarChar).Value = paid_txn_id;
                        commamd.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = Convert.ToDateTime(outputDateTime);

                        commamd.Connection.Open();
                        commamd.ExecuteNonQuery();
                    }
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