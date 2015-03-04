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
    public partial class AddUpdateDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


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
                MessageLine.Text = "Send_download_link: " + ex.Message;

            }
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();



            string ProductNames = ProductName.Text;
            string CategoryIDs = CategoryID.Text;
            string ProductDescription = Description.Text;
            string Quantity = "";
            string UnitsinStock = "";
            string UnitPrices = "";
            string UnitsonOrder = "";
            string Message = "";
            string Status = "GO";

           
            if (string.IsNullOrWhiteSpace(ProductName.Text))
            {
                Status = "Stop";
                Message = "-Product Name Must not be null or have whitespace" + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(Description.Text))
            {
                Status = "Stop";
                Message = "-Description Must not be null or have whitespace" + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine; 
            }

            if (string.IsNullOrWhiteSpace(QuantityPerUnit.Text))
            {
                Status = "Stop";
                Message = "-Quantity Per Unit Must not be null or have whitespace" + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(UnitInStock.Text))
            {
                Status = "Stop";
                Message = "-Unit In Stock Must not be null or have whitespace"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(UnitPrice.Text))
            {
                Status = "Stop";
                Message = "-Unit Price Must not be null or have whitespace"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(UnitOnOrder.Text))
            {
                Status = "Stop";
                Message = "-Units on Order Must not be null or have whitespace"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            int TestQuantity;
            if (int.TryParse(QuantityPerUnit.Text, out TestQuantity))
            {
                 Quantity = TestQuantity.ToString();
            }
            else
            {
                Status = "Stop";
                Message = "-Quantity must be Numeric" + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            int TestUnitsinStock;
            if (int.TryParse(UnitInStock.Text, out TestUnitsinStock))
            {
                 UnitsinStock = TestUnitsinStock.ToString();
            }
            else
            {
                Status = "Stop";
                Message = "-Units in Stock must be Numeric"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            int TestUnitPrices;
            if (int.TryParse(UnitPrice.Text, out TestUnitPrices))
            {
                 UnitPrices = TestUnitPrices.ToString();
            }
            else
            {
                Status = "Stop";
                Message = "-Unit Prices must be Numeric"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            int TestUnitOnOrder;
            if (int.TryParse(UnitOnOrder.Text, out TestUnitOnOrder))
            {
                 UnitsonOrder = TestUnitOnOrder.ToString();
            }
            else
            {
                Status = "Stop";
                Message = "-Unit On Order must be Numeric" + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            MessageLine.Text = Message;

             if (Status != "Stop")
             { 
            
                if (Controller.AddProduct(ProductNames, CategoryIDs, Quantity, UnitPrices, UnitsinStock, UnitsonOrder, ProductDescription))
                {
                    MessageLine.Text = "Product was added successfully into Records and Email has been sent to developer!";

                    string List_Item = "ProductNames = " + ProductNames + " " + System.Environment.NewLine + "CategoryIDs = " + CategoryIDs + " " + System.Environment.NewLine + "Quantity = " + Quantity + " " + System.Environment.NewLine + "UnitPrices = " + UnitPrices + " " + System.Environment.NewLine + "UnitsinStock = " + UnitsinStock + " " + System.Environment.NewLine + "UnitsonOrder = " + UnitsonOrder;
                    Send_download_link("davidlong1986@gmail.com", "davidlong1986@gmail.com", "C2: New Product Need to be added!", "These are the following variable and add new paypal button: " + System.Environment.NewLine + System.Environment.NewLine + List_Item + System.Environment.NewLine + System.Environment.NewLine + "Thank you");

                }
                else
                {
                    MessageLine.Text = "Product was not added";
                }
             }
        }

        protected void Find_Click(object sender, EventArgs e)
        {
            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

            string ProductIDs = ProductID.Text;

            DataSet ProductDataSet = Controller.FindProduct(ProductIDs);

            foreach (DataTable Table in ProductDataSet.Tables)
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

        protected void Update_Click(object sender, EventArgs e)
        {

            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

            string ProductIDs = ProductID.Text;
            string ProductNames = ProductName.Text;
            string CategoryIDs = CategoryID.Text;
            string ProductDescription = Description.Text;
            string Quantity = "";
            string UnitsinStock = "";
            string UnitPrices = "";
            string UnitsonOrder = "";
            string Message = "";
            string Status = "GO";


            if (string.IsNullOrWhiteSpace(ProductID.Text))
            {
                Status = "Stop";
                Message = "-Product ID Must not be null or have whitespace"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(ProductName.Text))
            {
                Status = "Stop";
                Message = "-Product Name Must not be null or have whitespace"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(Description.Text))
            {
                Status = "Stop";
                Message = "-Description Must not be null or have whitespace"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(QuantityPerUnit.Text))
            {
                Status = "Stop";
                Message = "-Quantity Per Unit Must not be null or have whitespace"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(UnitInStock.Text))
            {
                Status = "Stop";
                Message = "-Unit In Stock Must not be null or have whitespace"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(UnitPrice.Text))
            {
                Status = "Stop";
                Message = "-Unit Price Must not be null or have whitespace"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(UnitOnOrder.Text))
            {
                Status = "Stop";
                Message = "-Units on Order Must not be null or have whitespace"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            int TestQuantity;
            if (int.TryParse(QuantityPerUnit.Text, out TestQuantity))
            {
                Quantity = TestQuantity.ToString();
            }
            else
            {
                Status = "Stop";
                Message = "-Quantity must be Numeric"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            int TestUnitsinStock;
            if (int.TryParse(UnitInStock.Text, out TestUnitsinStock))
            {
                UnitsinStock = TestUnitsinStock.ToString();
            }
            else
            {
                Status = "Stop";
                Message = "-Units in Stock must be Numeric"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            int TestUnitPrices;
            if (int.TryParse(UnitPrice.Text, out TestUnitPrices))
            {
                UnitPrices = TestUnitPrices.ToString();
            }
            else
            {
                Status = "Stop";
                Message = "-Unit Prices must be Numeric"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            int TestUnitOnOrder;
            if (int.TryParse(UnitOnOrder.Text, out TestUnitOnOrder))
            {
                UnitsonOrder = TestUnitOnOrder.ToString();
            }
            else
            {
                Status = "Stop";
                Message = "-Unit On Order must be Numeric"  + " " + System.Environment.NewLine + Message + " " + System.Environment.NewLine;
            }

            MessageLine.Text = Message;

            if (Status != "Stop")
            {

                if (Controller.UpdateProduct(ProductIDs, ProductNames, CategoryIDs, Quantity, UnitPrices, UnitsinStock, UnitsonOrder, ProductDescription))
                {
                    MessageLine.Text = "Product is Updated successfully into Records and Email has been sent to developer!";

                    string List_Item = "ProductNames = " + ProductNames + " " + System.Environment.NewLine + "CategoryIDs = " + CategoryIDs + " " + System.Environment.NewLine + "Quantity = " + Quantity + " " + System.Environment.NewLine + "UnitPrices = " + UnitPrices + " " + System.Environment.NewLine + "UnitsinStock = " + UnitsinStock + " " + System.Environment.NewLine + "UnitsonOrder = " + UnitsonOrder;
                    Send_download_link("davidlong1986@gmail.com", "davidlong1986@gmail.com", "C2: Update Product is Needed!", "These are the following variable and update paypal's button: " + System.Environment.NewLine + System.Environment.NewLine + List_Item + System.Environment.NewLine + System.Environment.NewLine + "Thank you");
                }
                else
                {
                    MessageLine.Text = "Product is not Updated";
                }
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

            string ProductIDs = ProductID.Text;

            if (Controller.DeleteProduct(ProductIDs))
            {

                MessageLine.Text = "Product is Deleted successfully from Records and Email has been sent to developer!";

                string List_Item = "ProductIDs = " + ProductIDs + " " + System.Environment.NewLine;
                Send_download_link("davidlong1986@gmail.com", "davidlong1986@gmail.com", "C2: Delete Product!", "These are the following variable and delete paypal's button: " + System.Environment.NewLine + System.Environment.NewLine + List_Item + System.Environment.NewLine + "Thank you");
            
            }
            else
            {
                MessageLine.Text = "Product is not Deleted";
            }
        }
    }
}