using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado.Net
{
    class Person_ExecuteScalar
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {

                con = new SqlConnection("data source=DESKTOP-069RJJH; database=person; integrated security=true");

                SqlCommand query = new SqlCommand("Select count(*) from person", con);

                con.Open();

                int count = (int)query.ExecuteScalar();
                Console.WriteLine("Total No. Of Records in table are:" + count);                
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
