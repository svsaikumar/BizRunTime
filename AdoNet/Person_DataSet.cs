using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ado.Net
{
    class Person_DataSet
    {
        

        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-069RJJH; database=person; integrated security=true");
                con.Open();
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from person", con);
                SqlCommandBuilder dataBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataSet, "table1");
                int i = 0;
                /*foreach (DataTable table in dataSet.Tables)
                { 
                    Console.WriteLine(table.Rows[i].ToString());
                    i++;
                }*/
                Console.WriteLine("id" + "\t" + "name" + "\t" + "age" + "\t" + " email" +  "\t");
                Console.WriteLine("========================================");
                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    Console.WriteLine(dr["id"] + "\t" + dr["name"] + "\t" + dr["age"] + "\t" + dr["email"]);
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
