using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoNet2
{
    class Person_Insert
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            SqlCommand query;
            string decision;
            try
            {
                con = new SqlConnection("data source=.;database=Person; integrated security=SSPI");
                con.Open();
                do
                {
                    Console.WriteLine("enter id:");
                    int id = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("enter name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("enter age:");
                    int age = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("enter email:");
                    string email = Console.ReadLine();

                    query = new SqlCommand("insert into person values(" + id + ",'"  + name + "'," + age + ",'" + email + "')", con);
                    
                    query.ExecuteNonQuery();
                    //query.ExecuteReader();
                   // query.ExecuteScalar();
                    
                    
                    Console.WriteLine("Do u Want to insert one more record?Y/N");
                    decision = Console.ReadLine();
                }
                while (decision.ToLower() == "Y");
                Console.WriteLine("records inserted successfully");
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
