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


namespace AmazingTeam.PresentationLayer
{
    public partial class AddUpdateDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

            string ProductNames = ProductName.Text;
            string CategoryIDs = CategoryID.Text;
            string Quantity = QuantityPerUnit.Text;
            string UnitPrices = UnitPrice.Text;
            string UnitsinStock = UnitInStock.Text;
            string UnitsonOrder = UnitOnOrder.Text;
            //Missing Product Description


            if (Controller.AddProduct(ProductNames, CategoryIDs, Quantity, UnitPrices, UnitsinStock, UnitsonOrder))
            {

                MessageLine.Text = "Product was added successfully";
            }
            else
            {
                MessageLine.Text = "Product was not added";
            }
        }

        protected void Find_Click(object sender, EventArgs e)
        {
            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

            string ProductIDs = ProductID.Text;

            DataSet ProductDataSet = Controller.FindProduct(ProductIDs);

            // Should only have one product coming back 
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
            string Quantity = QuantityPerUnit.Text;
            string UnitPrices = UnitPrice.Text;
            string UnitsinStock = UnitInStock.Text;
            string UnitsonOrder = UnitOnOrder.Text;
            //Missing Product Description

            if (Controller.UpdateProduct(ProductIDs, ProductNames, CategoryIDs, Quantity, UnitPrices, UnitsinStock, UnitsonOrder))
            {
                MessageLine.Text = "Product is Updated Successfully";
            }
            else
            {
                MessageLine.Text = "Product is not Updated";
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            AmazingTeam.BusinessLayer.BusinessLayer Controller = new AmazingTeam.BusinessLayer.BusinessLayer();

            string ProductIDs = ProductID.Text;

            if (Controller.DeleteProduct(ProductIDs))
            {
                MessageLine.Text = "Pruduct is Deleted Successfully";
            }
            else
            {
                MessageLine.Text = "Product is not Deleted";
            }
        }
    }
}