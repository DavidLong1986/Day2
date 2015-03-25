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
        public DataSet LookupUserIDPassword(string UserID, string Password)
        {
            return AmazingTeam.DataAccessLayer.Owner.LookupUserIDPassword (UserID, Password);
        }

        public DataSet LookupSecretQuestionRespond(string UserID, string Password, string Respond)
        {
            return AmazingTeam.DataAccessLayer.Owner.LookupSecretQuestionRespond(UserID, Password, Respond);
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
        public DataSet FindTestimonial()
        {
            DataSet TestDataSet = new DataSet();

            TestDataSet = AmazingTeam.DataAccessLayer.Owner.FindTestimonial();
            return TestDataSet;
        }
        public bool LikeTestimonial(int ActiveStatus, int TestimonialID)
        {
            bool Success = false;

            Success = AmazingTeam.DataAccessLayer.Owner.LikeTestimonial(ActiveStatus, TestimonialID);
            return Success;
        }
        public bool DislikeTestimonial(int ActiveStatus, int TestimonialID)
        {
            bool Success = false;

            Success = AmazingTeam.DataAccessLayer.Owner.DislikeTestimonial(ActiveStatus, TestimonialID);
            return Success;
        }
        public DataSet HistoryOfAllOrders(string OrderFromDate, string OrderToDate)
        {
            return AmazingTeam.DataAccessLayer.Owner.HistoryOfAllOrders(OrderFromDate, OrderToDate);
        }
        public DataSet LoadAllActiveEnquiries()
        {
            DataSet EnqDataSet;
            EnqDataSet = new DataSet();

            EnqDataSet = AmazingTeam.DataAccessLayer.Owner.SelectAllActiveEnquiries();
            return EnqDataSet;
        }
        public bool DeactiveSelectedEnq(int EnqID)
        {
            bool confirmation;
            confirmation = false;

            confirmation =  AmazingTeam.DataAccessLayer.Owner.DelEnq(EnqID);
            return confirmation;
        }
        public DataSet LoadAllActiveOrders()
        {
            DataSet OrderDataSet;
            OrderDataSet = new DataSet();
            OrderDataSet = AmazingTeam.DataAccessLayer.Owner.SelectAllActiveOrders();
            return OrderDataSet;
        }
        public bool DeactiveSelectedOrder(int OrderID)
        {
            bool confirmation;
            confirmation = false;
            confirmation = AmazingTeam.DataAccessLayer.Owner.DelOrder(OrderID);
            return confirmation;
        }


        //-----------------------Customer Enquire------------------------
        public void AddCustomerEnquries(string TypeOfQuestion, string Name, string Email, string Message)
        {
            AmazingTeam.DataAccessLayer.Customer.AddCustomerEnquries(TypeOfQuestion, Name, Email, Message);
        }

        public void VerifedCustomerOrder(string user_email, string payer_fristName, string payer_LastName, string paid_ItemId_1, string paid_ItemId_2, string paid_ItemId_3, string paid_ItemId_4, string paid_ItemId_5, string paid_ItemId_6, string paid_ItemId_7, string paid_ItemId_8, string paid_ItemId_9, string paid_ItemId_10, string paid_ItemId_11, string paid_ItemId_12, string paid_txn_id, DateTime outputDateTime)
        {
            AmazingTeam.DataAccessLayer.Owner.VerifedCustomerOrderData(user_email, payer_fristName, payer_LastName, paid_ItemId_1, paid_ItemId_2, paid_ItemId_3, paid_ItemId_4, paid_ItemId_5, paid_ItemId_6, paid_ItemId_7, paid_ItemId_8, paid_ItemId_9, paid_ItemId_10, paid_ItemId_11, paid_ItemId_12, paid_txn_id, outputDateTime);
        }
        public void AddCustomerTestimonial(string RateC2, string Name, string Comments)
        {
            AmazingTeam.DataAccessLayer.Customer.AddCustomerTestimonial(RateC2, Name, Comments);
        }
        public DataSet FindApprovedTestimonial()
        {
            DataSet TestDataSet = new DataSet();

            TestDataSet = AmazingTeam.DataAccessLayer.Customer.FindApprovedTestimonial();

            return TestDataSet;
        }

        
    }
}