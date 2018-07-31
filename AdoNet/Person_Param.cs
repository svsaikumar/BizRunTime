using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado.Net
{
    class Person_Param
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            string str = "sai";
            try
            {               
                con = new SqlConnection("data source= DESKTOP-069RJJH; database=Person; integrated security=true");
                SqlCommand cm = new SqlCommand("select * from person where name = @text", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@text";
                param.Value = str;
                cm.Parameters.Add(param);
                con.Open();
                SqlDataReader data = cm.ExecuteReader();
                while(data.Read())
                {
                    Console.WriteLine(data[0] + "," + data[1] + "," + data[2] + "," + data[3]);
                }
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
