using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado.Net
{
    class Emp_Read
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
 
                con = new SqlConnection("data source=DESKTOP-069RJJH; database=employee; integrated security=true");
                
                SqlCommand query = new SqlCommand("Select * from employee", con);
                  
                con.Open();
               
                SqlDataReader data = query.ExecuteReader();
                
                while (data.Read())
                {
                    Console.WriteLine(data["id"] + " " + data["name"] + " " + data["city"]); 
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
        public void CreateTable()
        {

        }
    }
}
