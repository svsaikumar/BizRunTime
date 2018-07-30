using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado.Net
{
    class Emp_Create
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
           
            try
            {
                con = new SqlConnection("data source=DESKTOP-069RJJH; database=Employee; integrated security=true");
                SqlCommand query = new SqlCommand("create table employee(id int, name varchar(100), city varchar(100))", con);
                con.Open();
                query.ExecuteNonQuery();
                Console.WriteLine("Table created Successfully");
            }
            catch(Exception e)
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
