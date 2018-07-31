using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoNet2
{
    class Person_Delete
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            SqlCommand query;
           
            try
            {
                con = new SqlConnection("data source=.; database=Person; integrated security=SSPI");

                con.Open();
                query = new SqlCommand("delete person where id = 3", con);
               
                int status = query.ExecuteNonQuery();
               if(status == 1)
                {
                   Console.WriteLine("deleted succssfully :" + status);
                }   
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
