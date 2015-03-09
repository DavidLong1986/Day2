using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualBasic;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;



namespace AmazingTeam.DataAccessLayer
{


    public class Owner
    {
        //Remember there's two place where database are:
        //public const string StrConn = "Data Source=SABER\\SQLEXPRESS; Initial Catalog=C2; Integrated Security=SSPI"; // LocalHost
        public const string StrConn = "Server=tcp:j5ldchdajd.database.windows.net,1433;Database=AmazingTeamDatabase;User ID=AmazingTeam@j5ldchdajd;Password=Baist3990?;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
      

        public static DataSet LookupUserIDPassword(string UserID, string Password, string Respond)
        {
            SqlConnection MyConn = new SqlConnection(StrConn);
            SqlDataAdapter MyAdapter = new SqlDataAdapter("Exec LookupUserIDandPassword @Userid, @Password, @Respond", MyConn);
            MyAdapter.SelectCommand.Parameters.Add("@UserID", SqlDbType.NChar).Value = UserID;
            MyAdapter.SelectCommand.Parameters.Add("@Password", SqlDbType.NChar).Value = Password;
            MyAdapter.SelectCommand.Parameters.Add("@Respond", SqlDbType.NChar).Value = Respond;

            DataSet MyDataset = new DataSet();
            MyAdapter.Fill(MyDataset);
            return MyDataset;
        }

        public static bool AddProduct(string ProductName, string CategoryID, string QuantityPerUnit, string UnitPrice, string UnitsinStock, string UnitsonOrder, string ProductDescription)
        {
            SqlConnection MyConnection = new SqlConnection(StrConn);
          
            SqlCommand MyCommand = new SqlCommand();
            MyCommand.CommandType = CommandType.StoredProcedure;
            MyCommand.Connection = MyConnection;
            MyCommand.CommandText = "AddProduct";


            SqlParameter productname = new SqlParameter();
            productname.ParameterName = "@ProductName";
            productname.SqlDbType = SqlDbType.NChar;
            productname.Value = ProductName;
            productname.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(productname);

            SqlParameter categoryid = new SqlParameter();
            categoryid.ParameterName = "@CategoryID";
            categoryid.SqlDbType = SqlDbType.Int;
            categoryid.Value = CategoryID;
            categoryid.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(categoryid);

            SqlParameter quantityperunit = new SqlParameter();
            quantityperunit.ParameterName = "@Quantity";
            quantityperunit.SqlDbType = SqlDbType.Int;
            quantityperunit.Value = QuantityPerUnit;
            quantityperunit.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(quantityperunit);

            SqlParameter unitprice = new SqlParameter();
            unitprice.ParameterName = "@UnitPrice";
            unitprice.SqlDbType = SqlDbType.Money;
            unitprice.Value = UnitPrice;
            unitprice.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(unitprice);

            SqlParameter unitsinstock = new SqlParameter();
            unitsinstock.ParameterName = "@UnitsInStock";
            unitsinstock.SqlDbType = SqlDbType.Int;
            unitsinstock.Value = UnitsinStock;
            unitsinstock.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(unitsinstock);

            SqlParameter unitsonorder = new SqlParameter();
            unitsonorder.ParameterName = "@UnitsOnOrder";
            unitsonorder.SqlDbType = SqlDbType.Int;
            unitsonorder.Value = UnitsonOrder;
            unitsonorder.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(unitsonorder);

            SqlParameter Description = new SqlParameter();
            Description.ParameterName = "@Description";
            Description.SqlDbType = SqlDbType.Text;
            Description.Value = ProductDescription;
            Description.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(Description);


            MyConnection.Open();
            int rowsAffected;
            rowsAffected = MyCommand.ExecuteNonQuery();

            MyConnection.Close();

            bool success;

            if (rowsAffected == 0)
            {
                success = false;
            }
            else
            {
                success = true;
            }
            return success;
        }

        public static DataSet FindProducts(string ProductID)
        {
            SqlConnection MyConnection = new SqlConnection(StrConn);

            SqlCommand MyCommand = new SqlCommand();
            MyCommand.CommandType = CommandType.StoredProcedure;
            MyCommand.Connection = MyConnection;
            MyCommand.CommandText = "FindProduct";

            SqlParameter productid = new SqlParameter();
            productid.ParameterName = "@ProductID";
            productid.SqlDbType = SqlDbType.Int;
            productid.Value = ProductID;
            productid.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(productid);


            MyConnection.Open();

            SqlDataAdapter MyDataAdapter = new SqlDataAdapter();
            MyDataAdapter.SelectCommand = MyCommand;
            DataSet MyDataSet = new DataSet();
            MyDataSet.Tables.Add("Products");
            MyDataAdapter.Fill(MyDataSet);

            MyConnection.Close();
            return MyDataSet;
        }

        public static bool UpdateProduct(string ProductID, string ProductName, string CategoryID, string QuantityPerUnit, string UnitPrice, string UnitsinStock, string UnitsonOrder, string ProductDescription)
        {
            SqlConnection MyConnection = new SqlConnection(StrConn);

            SqlCommand MyCommand = new SqlCommand();
            MyCommand.CommandType = CommandType.StoredProcedure;
            MyCommand.Connection = MyConnection;
            MyCommand.CommandText = "UpdateProducts";

            SqlParameter productid = new SqlParameter();
            productid.ParameterName = "@ProductID";
            productid.SqlDbType = SqlDbType.Int;
            productid.Value = ProductID;
            productid.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(productid);

            SqlParameter productname = new SqlParameter();
            productname.ParameterName = "@ProductName";
            productname.SqlDbType = SqlDbType.NChar;
            productname.Value = ProductName;
            productname.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(productname);

            SqlParameter categoryid = new SqlParameter();
            categoryid.ParameterName = "@CategoryID";
            categoryid.SqlDbType = SqlDbType.Int;
            categoryid.Value = CategoryID;
            categoryid.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(categoryid);

            SqlParameter quantityperunit = new SqlParameter();
            quantityperunit.ParameterName = "@Quantity";
            quantityperunit.SqlDbType = SqlDbType.Int;
            quantityperunit.Value = QuantityPerUnit;
            quantityperunit.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(quantityperunit);

            SqlParameter unitprice = new SqlParameter();
            unitprice.ParameterName = "@UnitPrice";
            unitprice.SqlDbType = SqlDbType.Money;
            unitprice.Value = UnitPrice;
            unitprice.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(unitprice);

            SqlParameter unitsinstock = new SqlParameter();
            unitsinstock.ParameterName = "@UnitsInStock";
            unitsinstock.SqlDbType = SqlDbType.Int;
            unitsinstock.Value = UnitsinStock;
            unitsinstock.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(unitsinstock);

            SqlParameter unitsonorder = new SqlParameter();
            unitsonorder.ParameterName = "@UnitsOnOrder";
            unitsonorder.SqlDbType = SqlDbType.Int;
            unitsonorder.Value = UnitsonOrder;
            unitsonorder.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(unitsonorder);

            SqlParameter Description = new SqlParameter();
            Description.ParameterName = "@Description";
            Description.SqlDbType = SqlDbType.Text;
            Description.Value = ProductDescription;
            Description.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(Description);


            MyConnection.Open();
            int rowsAffected;
            rowsAffected = MyCommand.ExecuteNonQuery();

            MyConnection.Close();

            bool success;

            if (rowsAffected == 0)
            {
                success = false;
            }
            else
            {
                success = true;
            }
            return success;
        }

        public static bool DeleteProduct(string ProductID)
        {
            SqlConnection MyConnection = new SqlConnection(StrConn);

            SqlCommand MyCommand = new SqlCommand();
            MyCommand.CommandType = CommandType.StoredProcedure;
            MyCommand.Connection = MyConnection;
            MyCommand.CommandText = "DeleteProduct";

            SqlParameter productid = new SqlParameter();
            productid.ParameterName = "@ProductID";
            productid.SqlDbType = SqlDbType.Int;
            productid.Value = ProductID;
            productid.Direction = ParameterDirection.Input;
            MyCommand.Parameters.Add(productid);

            MyConnection.Open();
            int rowsAffected;
            rowsAffected = MyCommand.ExecuteNonQuery();

            MyConnection.Close();
            bool success;

            if (rowsAffected == 0)
            {
                success = false;
            }
            else
            {
                success = true;
            }
            return success;
        }
        public static void VerifedCustomerOrderData(string user_email, string payer_fristName, string payer_LastName, string paid_ItemId_1, string paid_ItemId_2, string paid_ItemId_3, string paid_ItemId_4, string paid_ItemId_5, string paid_ItemId_6, string paid_ItemId_7, string paid_ItemId_8, string paid_ItemId_9, string paid_ItemId_10, string paid_ItemId_11, string paid_ItemId_12, string paid_txn_id, DateTime outputDateTime)
        {

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
                commamd.Parameters.Add("@ProductIDEleven", SqlDbType.Int).Value = Convert.ToInt32(paid_ItemId_11);
                commamd.Parameters.Add("@ProductIDTwelve", SqlDbType.Int).Value = Convert.ToInt32(paid_ItemId_12);


                commamd.Parameters.Add("@TranscationID", SqlDbType.NVarChar).Value = paid_txn_id;
                commamd.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = Convert.ToDateTime(outputDateTime);

                commamd.Connection.Open();
                commamd.ExecuteNonQuery();
            }

        }

    }
}