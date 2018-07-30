using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado.Net
{
    class Emp_Delete
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                
                con = new SqlConnection("data source=DESKTOP-069RJJH; database=Employee; integrated security=true");              
                SqlCommand cm = new SqlCommand("delete from employee where id = 101", con);                
                con.Open();               
                cm.ExecuteNonQuery();
                Console.WriteLine("Record Deleted Successfully");
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
