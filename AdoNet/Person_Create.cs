using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoNet2
{
    class Person_Create
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            SqlCommand query;
            try
            {
                con = new SqlConnection("data source=.;database=Person; integrated security=SSPI");
                query = new SqlCommand("create table person(id int, name varchar(99), age int, email varchar(99))", con);
                con.Open();
                query.ExecuteNonQuery();
                Console.WriteLine("Table created successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("some error occured:" + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
