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
        public bool AddProduct(string ProductNames, string CategoryIDs, string QuantityPerUnits, string UnitPrices, string UnitsinStock, string UnitsonOrder)
        {
            bool Success = false;
            Success = AmazingTeam.DataAccessLayer.Owner.AddProduct(ProductNames, CategoryIDs, QuantityPerUnits, UnitPrices, UnitsinStock, UnitsonOrder);
            return Success;
        }

        public DataSet FindProduct(string ProductID)
        {
            DataSet ProductDataSet = new DataSet();
            ProductDataSet = AmazingTeam.DataAccessLayer.Owner.FindProducts(ProductID);
            return ProductDataSet;
        }

        public bool UpdateProduct(string ProductIDs, string ProductNames, string CategoryIDs, string QuantityPerUnits, string UnitPrices, string UnitsinStock, string UnitsonOrder)
        {
            bool Success = false;
            Success = AmazingTeam.DataAccessLayer.Owner.UpdateProduct(ProductIDs, ProductNames, CategoryIDs, QuantityPerUnits, UnitPrices, UnitsinStock, UnitsonOrder);
            return Success;
        }

        public bool DeleteProduct(string ProductID)
        {
            bool Success = false;
            Success = AmazingTeam.DataAccessLayer.Owner.DeleteProduct(ProductID);
            return Success;
        }
        //Customer----------------------------------------------------------------------------------------

        //public bool AddCustomerOrder(string CustomerEmailID, string CustomerFirstName, string CustomerLastName, string paid_ItemId_1, string paid_ItemId_2, string paid_ItemId_3, string paid_ItemId_4, string paid_ItemId_5, string paid_ItemId_6, string paid_ItemId_7, string paid_ItemId_8, string paid_ItemId_9, string paid_ItemId_10, string OwnerTranscationID, string pay_date)
        //{
        //    bool Success = false;
        //    Success = AmazingTeam.DataAccessLayer.Customer.AddCustomerOrder(CustomerEmailID, CustomerFirstName, CustomerLastName, paid_ItemId_1, paid_ItemId_2, paid_ItemId_3, paid_ItemId_4, paid_ItemId_5, paid_ItemId_6, paid_ItemId_7, paid_ItemId_8, paid_ItemId_9, paid_ItemId_10, OwnerTranscationID, pay_date);
        //    return Success;
        //}
    }
}