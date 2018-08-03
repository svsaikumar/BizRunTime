using System;
using System.Data.SqlClient;


namespace Joins
{
    class Emp_Pc_Insert
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection("data source=.; database=Joins; integrated security=true");
                SqlCommand query1 = new SqlCommand("insert into emp_pc values(1, 123, 'red')", con);
                SqlCommand query2 = new SqlCommand("insert into emp_pc values(2, 456, 'blue')", con);
                SqlCommand query3 = new SqlCommand("insert into emp_pc values(5, 789, 'orange')", con);
                SqlCommand query4 = new SqlCommand("insert into emp_pc values(6, 121, 'yellow')", con);
                con.Open();
                query1.ExecuteNonQuery();
                query2.ExecuteNonQuery();
                query3.ExecuteNonQuery();
                query4.ExecuteNonQuery();
                Console.WriteLine("Records inserted into Emp_Pc Successfully");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("some thing went wrong:" + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
