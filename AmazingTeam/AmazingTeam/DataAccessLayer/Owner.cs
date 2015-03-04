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

    }
}