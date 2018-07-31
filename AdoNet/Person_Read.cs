using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado.Net
{
    class Person_Read
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-069RJJH; database=person; integrated security=true");
                SqlCommand query = new SqlCommand("Select * from person", con);
                con.Open();
                SqlDataReader data = query.ExecuteReader();
                int count = data.FieldCount;
                //int rows = data.
                while (data.Read())
                {
                    for(int i = 0; i < count; i++)
                    {
                        Console.Write(data[i] + ",");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }

            finally
            {
                con.Close();
            }
        }

    }
}
