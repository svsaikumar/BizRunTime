using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Joins
{
    class Emp_Ofc_Create
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=Joins; integrated security=true");
                SqlCommand query = new SqlCommand("create table emp_ofc(id int, name varchar(90), age int, email varchar(90))", con);
                con.Open();
                query.ExecuteNonQuery();
                Console.WriteLine("Table Emp created Successfully");
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
