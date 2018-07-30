using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado.Net
{
    class Emp_Insert
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                
                con = new SqlConnection("data source= DESKTOP-069RJJH; database=Employee; integrated security=true");                
                SqlCommand cm = new SqlCommand("insert into employee(id, name, city) values(101, 'world', 'bengaluru')", con);               
                con.Open();               
                cm.ExecuteNonQuery();
               Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            
            finally
            {
                con.Close();
            }
        }

    }
}
