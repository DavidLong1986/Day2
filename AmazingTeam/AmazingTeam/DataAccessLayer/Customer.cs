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
        public const string StrConn = "Server=tcp:j5ldchdajd.database.windows.net,1433;Database=AmazingTeamDatabase;User ID=AmazingTeam@j5ldchdajd;Password=Baist3990?;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
      
        //----------------------------------Customer Enquire----------------------------------------------------
        public static void AddCustomerEnquries(string TypeOfQuestion, string Name, string Email, string Message)
        {
            //1. Instantiate a new connection object
            SqlConnection MyConn = new SqlConnection(StrConn);
            //2. Instatiate a new Command object
            SqlCommand MyCommand = new SqlCommand("AddCustomer_Enquiries", MyConn);
            //3. the command type must be stored procedure
            MyCommand.CommandType = CommandType.StoredProcedure;
            //4. Create/substitue all 4 parameters:CourseId, Coursename,
            //   
            MyCommand.Parameters.Add("@TypeOfQuestion", SqlDbType.NVarChar).Value = TypeOfQuestion;
            MyCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;

            MyCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
            MyCommand.Parameters.Add("@Message", SqlDbType.NVarChar).Value = Message;


            // execute the command object via Try..Finally block
            MyConn.Open();
            try
            {
                MyCommand.ExecuteNonQuery();
            }
            finally
            {
                MyConn.Close();
            }

        }

        public static void AddCustomerTestimonial(string RateC2, string Name, string InputComments)
        {
            //1. Instantiate a new connection object
            SqlConnection MyConn = new SqlConnection(StrConn);
            //2. Instatiate a new Command object
            SqlCommand MyCommand = new SqlCommand("AddCustomer_Testimonial", MyConn);
            //3. the command type must be stored procedure
            MyCommand.CommandType = CommandType.StoredProcedure;
            //4. Create/substitue all 4 parameters:CourseId, Coursename,
            //   
            MyCommand.Parameters.Add("@Rate", SqlDbType.NVarChar).Value = RateC2 + " out of 5";
            MyCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
            MyCommand.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = InputComments;


            // execute the command object via Try..Finally block
            MyConn.Open();
            try
            {
                MyCommand.ExecuteNonQuery();
            }
            finally
            {
                MyConn.Close();
            }

        }
        public static DataSet FindApprovedTestimonial()
        {
            SqlConnection MyConnection = new SqlConnection(StrConn);

            SqlCommand MyCommand = new SqlCommand();
            MyCommand.CommandType = CommandType.StoredProcedure;
            MyCommand.Connection = MyConnection;
            MyCommand.CommandText = "FindApprovedTestimonial";

            MyConnection.Open();

            SqlDataAdapter MyDataAdapter = new SqlDataAdapter();
            MyDataAdapter.SelectCommand = MyCommand;
            DataSet MyDataSet = new DataSet();
            MyDataSet.Tables.Add("Testimonial");
            MyDataAdapter.Fill(MyDataSet);

            MyConnection.Close();
            return MyDataSet;
        }

        
    }
}