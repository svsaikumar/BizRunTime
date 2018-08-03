using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_CRUD_CORE.Models
{
    public class EmployeeDataAccessLayer
    {
        string connectionString = "data source=.;database=master; integrated security=SSPI";
        //To View all employees details    
        public IEnumerable<Employee> GetAllEmployees()
        {
            List<Employee> employee_list = new List<Employee>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select_employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    Employee employee = new Employee();
                    employee.ID = Convert.ToInt32(data["id"]);
                    employee.NAME = data["name"].ToString();
                    employee.CITY = data["city"].ToString();
                    employee.AGE = data["age"].ToString();
                    employee_list.Add(employee);
                }
                con.Close();
            }
            return employee_list;
        }
        //To Add new employee record    
        public void AddEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("insert_employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.AddWithValue("@name", employee.NAME);
                cmd.Parameters.AddWithValue("@city", employee.CITY);
                cmd.Parameters.AddWithValue("@age", employee.AGE);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //To Update the records of a particluar employee  
        public void UpdateEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("update_employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", employee.ID);
                cmd.Parameters.AddWithValue("@name", employee.NAME);
                cmd.Parameters.AddWithValue("@city", employee.CITY);
                cmd.Parameters.AddWithValue("@age", employee.AGE);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //Get the details of a particular employee  
        public Employee GetEmployeeData(int? id)
        {
            Employee employee = new Employee();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM employee WHERE id= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    employee.ID = Convert.ToInt32(rdr["id"]);
                    employee.NAME = rdr["name"].ToString();
                    employee.CITY = rdr["city"].ToString();
                    employee.AGE = rdr["age"].ToString();
                   
                }
            }
            return employee;
        }
        //To Delete the record on a particular employee  
        public void DeleteEmployee(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("delete_employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
