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
    public class Customer
    {
        //Remember there's two place where database are:
        //public const string StrConn = "Data Source=SABER\\SQLEXPRESS; Initial Catalog=C2; Integrated Security=SSPI"; // LocalHost
        //public const string StrConn = "Server=tcp:j5ldchdajd.database.windows.net,1433;Database=AmazingTeamDatabase;User ID=AmazingTeam@j5ldchdajd;Password=Baist3990?;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";

        //public static bool AddCustomerOrder(string CustomerEmailID, string CustomerFirstName, string CustomerLastName, string paid_ItemId_1, string paid_ItemId_2 , string paid_ItemId_3, string paid_ItemId_4, string paid_ItemId_5, string paid_ItemId_6, string paid_ItemId_7, string paid_ItemId_8,  string paid_ItemId_9, string paid_ItemId_10, string OwnerTranscationID, string pay_date)
        //{
        //    bool success;
            
        //        //This is for the RequireDate because products needs time to make ask Cori 
        //        //Product id is require to be known here

        //        // Required date will be found in the SQL
 
        //        SqlConnection MyConnection = new SqlConnection(StrConn);

        //        SqlCommand MyCommand = new SqlCommand();
        //        MyCommand.CommandType = CommandType.StoredProcedure;
        //        MyCommand.Connection = MyConnection;
        //        MyCommand.CommandText = "AddCustomerOrder";

        //        SqlParameter PayerIDEmail = new SqlParameter();
        //        PayerIDEmail.ParameterName = "@CustomerID";
        //        PayerIDEmail.SqlDbType = SqlDbType.NChar;
        //        PayerIDEmail.Value = CustomerEmailID;
        //        PayerIDEmail.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PayerIDEmail);

        //        SqlParameter PayerFirstName = new SqlParameter();
        //        PayerFirstName.ParameterName = "@CustomerFirstName";
        //        PayerFirstName.SqlDbType = SqlDbType.NChar;
        //        PayerFirstName.Value = CustomerFirstName;
        //        PayerFirstName.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PayerFirstName);

        //        SqlParameter PayerLastName = new SqlParameter();
        //        PayerLastName.ParameterName = "@CustomerLastName";
        //        PayerLastName.SqlDbType = SqlDbType.NChar;
        //        PayerLastName.Value = CustomerLastName;
        //        PayerLastName.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PayerLastName);
                
        //        //---- All the ProductsID will been sent here it may not be the best way but it works--//
        //        SqlParameter PaypalProductIDOne = new SqlParameter();
        //        PaypalProductIDOne.ParameterName = "@ProductIDOne";
        //        PaypalProductIDOne.SqlDbType = SqlDbType.Int;
        //        PaypalProductIDOne.Value = paid_ItemId_1;
        //        PaypalProductIDOne.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PaypalProductIDOne);

        //        SqlParameter PaypalProductIDTwo = new SqlParameter();
        //        PaypalProductIDTwo.ParameterName = "@ProductIDTwo";
        //        PaypalProductIDTwo.SqlDbType = SqlDbType.Int;
        //        PaypalProductIDTwo.Value = paid_ItemId_2;
        //        PaypalProductIDTwo.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PaypalProductIDTwo);

        //        SqlParameter PaypalProductIDThree = new SqlParameter();
        //        PaypalProductIDThree.ParameterName = "@ProductIDThree";
        //        PaypalProductIDThree.SqlDbType = SqlDbType.Int;
        //        PaypalProductIDThree.Value = paid_ItemId_3;
        //        PaypalProductIDThree.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PaypalProductIDThree);

        //        SqlParameter PaypalProductIDFour = new SqlParameter();
        //        PaypalProductIDFour.ParameterName = "@ProductIDFour";
        //        PaypalProductIDFour.SqlDbType = SqlDbType.Int;
        //        PaypalProductIDFour.Value = paid_ItemId_4;
        //        PaypalProductIDFour.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PaypalProductIDFour);

        //        SqlParameter PaypalProductIDFive = new SqlParameter();
        //        PaypalProductIDFive.ParameterName = "@ProductIDFive";
        //        PaypalProductIDFive.SqlDbType = SqlDbType.Int;
        //        PaypalProductIDFive.Value = paid_ItemId_5;
        //        PaypalProductIDFive.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PaypalProductIDFive);

        //        SqlParameter PaypalProductIDSix = new SqlParameter();
        //        PaypalProductIDSix.ParameterName = "@ProductIDSix";
        //        PaypalProductIDSix.SqlDbType = SqlDbType.Int;
        //        PaypalProductIDSix.Value = paid_ItemId_6;
        //        PaypalProductIDSix.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PaypalProductIDSix);

        //        SqlParameter PaypalProductIDSeven = new SqlParameter();
        //        PaypalProductIDSeven.ParameterName = "@ProductIDSeven";
        //        PaypalProductIDSeven.SqlDbType = SqlDbType.Int;
        //        PaypalProductIDSeven.Value = paid_ItemId_7;
        //        PaypalProductIDSeven.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PaypalProductIDSeven);

        //        SqlParameter PaypalProductIDEight = new SqlParameter();
        //        PaypalProductIDEight.ParameterName = "@ProductIDEight";
        //        PaypalProductIDEight.SqlDbType = SqlDbType.Int;
        //        PaypalProductIDEight.Value = paid_ItemId_8;
        //        PaypalProductIDEight.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PaypalProductIDEight);

        //        SqlParameter PaypalProductIDNine = new SqlParameter();
        //        PaypalProductIDNine.ParameterName = "@ProductIDNine";
        //        PaypalProductIDNine.SqlDbType = SqlDbType.Int;
        //        PaypalProductIDNine.Value = paid_ItemId_9;
        //        PaypalProductIDNine.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PaypalProductIDNine);

        //        SqlParameter PaypalProductIDTen = new SqlParameter();
        //        PaypalProductIDTen.ParameterName = "@ProductIDTen";
        //        PaypalProductIDTen.SqlDbType = SqlDbType.Int;
        //        PaypalProductIDTen.Value = paid_ItemId_10;
        //        PaypalProductIDTen.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PaypalProductIDTen);

        //        //----Ends HERE---------------------------------//
        //        SqlParameter PayPalTranID = new SqlParameter();
        //        PayPalTranID.ParameterName = "@TranscationID";
        //        PayPalTranID.SqlDbType = SqlDbType.NChar;
        //        PayPalTranID.Value = OwnerTranscationID;
        //        PayPalTranID.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PayPalTranID);

        //        SqlParameter PaidDate = new SqlParameter();
        //        PaidDate.ParameterName = "@OrderDate";
        //        PaidDate.SqlDbType = SqlDbType.DateTime;
        //        PaidDate.Value = pay_date;
        //        PaidDate.Direction = ParameterDirection.Input;
        //        MyCommand.Parameters.Add(PaidDate);

        //        MyConnection.Open();
        //        int rowsAffected;
        //        rowsAffected = MyCommand.ExecuteNonQuery();

        //        MyConnection.Close();

        //        if (rowsAffected == 0)
        //        {
        //            success = false;
        //        }
        //        else
        //        {
        //            success = true;
        //        }
                
        //        return success; 
        //        } 
            
        }        
}
