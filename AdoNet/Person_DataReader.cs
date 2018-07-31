using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoNet2
{
    class Person_DataReader
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            SqlCommand query;
            try
            {
                con = new SqlConnection("data source=.;database=Person; integrated security=SSPI");
                query = new SqlCommand("select * from person", con);
                con.Open();
                SqlDataReader data = query.ExecuteReader();  
                while(data.Read())
                {
                    Console.WriteLine(data[0] + ","  + data[1] + "," + data[2] + "," + data[3]);
                    
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
