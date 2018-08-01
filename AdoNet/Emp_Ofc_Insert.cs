using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado.Net
{
    class Emp_Ofc_Insert
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection("data source=.; database=Joins; integrated security=true");
                SqlCommand query1 = new SqlCommand("insert into emp_ofc values(1, 'venkat', 20, 'venkat@gmail.com')", con);
                SqlCommand query2 = new SqlCommand("insert into emp_ofc values(2, 'sai', 25, 'sai@gmail.com')", con);
                SqlCommand query3 = new SqlCommand("insert into emp_ofc values(3, 'kumar', 30, 'kumar@gmail.com')", con);
                SqlCommand query4 = new SqlCommand("insert into emp_ofc values(4, 'yadav', 35, 'yadav@gmail.com')", con);
                con.Open();
                query1.ExecuteNonQuery();
                query2.ExecuteNonQuery();
                query3.ExecuteNonQuery();
                query4.ExecuteNonQuery();
                Console.WriteLine("Records insergerdc Successfully");
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
