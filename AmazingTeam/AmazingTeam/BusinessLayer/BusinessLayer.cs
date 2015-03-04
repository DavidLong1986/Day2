using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualBasic;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;


namespace AmazingTeam.BusinessLayer
{
    public class BusinessLayer
    {
        //Authenticate---------------------------------------------------------------------------------
        public DataSet LookupUserIDPassword(string UserID, string Password, string Respond)
        {
            return AmazingTeam.DataAccessLayer.Owner.LookupUserIDPassword (UserID, Password, Respond);
        }
        //Owner----------------------------------------------------------------------------------------
        public bool AddProduct(string ProductNames, string CategoryIDs, string QuantityPerUnits, string UnitPrices, string UnitsinStock, string UnitsonOrder, string ProductDescription)
        {
            bool Success = false;
            Success = AmazingTeam.DataAccessLayer.Owner.AddProduct(ProductNames, CategoryIDs, QuantityPerUnits, UnitPrices, UnitsinStock, UnitsonOrder, ProductDescription);
            return Success;
        }
        public DataSet FindProduct(string ProductID)
        {
            DataSet ProductDataSet = new DataSet();
            ProductDataSet = AmazingTeam.DataAccessLayer.Owner.FindProducts(ProductID);
            return ProductDataSet;
        }
        public bool UpdateProduct(string ProductIDs, string ProductNames, string CategoryIDs, string QuantityPerUnits, string UnitPrices, string UnitsinStock, string UnitsonOrder, string ProductDescription)
        {
            bool Success = false;
            Success = AmazingTeam.DataAccessLayer.Owner.UpdateProduct(ProductIDs, ProductNames, CategoryIDs, QuantityPerUnits, UnitPrices, UnitsinStock, UnitsonOrder, ProductDescription);
            return Success;
        }
        public bool DeleteProduct(string ProductID)
        {
            bool Success = false;
            Success = AmazingTeam.DataAccessLayer.Owner.DeleteProduct(ProductID);
            return Success;
        }
        //-----------------------Customer Enquire------------------------
        public void AddCustomerEnquries(string TypeOfQuestion, string Name, string Email, string Message)
        {
            AmazingTeam.DataAccessLayer.Customer.AddCustomerEnquries(TypeOfQuestion, Name, Email, Message);
        }
    }
}