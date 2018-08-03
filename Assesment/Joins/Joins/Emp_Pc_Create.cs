﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joins
{
    class Emp_Pc_Create
    {
        static void Main(string[] args)
        { 
            SqlConnection con = null;

            try
            {
                con = new SqlConnection("data source=.; database=Joins; integrated security=true");
                SqlCommand query = new SqlCommand("create table emp_pc(sno int, mobile int, f_color varchar(90))", con);
                con.Open();
                query.ExecuteNonQuery();
                Console.WriteLine("Table Emp_Pc created Successfully");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("some thing went wrong:" + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
