package com.ignite;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import org.apache.ignite.Ignite;
import org.apache.ignite.Ignition;


public class JDBC_DELETE
{
	public static void main(String[] args) throws Exception,ClassNotFoundException
	{
		Ignite ignite = Ignition.start();
		ignite.cluster().active(true);
		
		Class.forName("org.apache.ignite.IgniteJdbcThinDriver");
		Connection conn = DriverManager.getConnection("jdbc:ignite:thin://192.168.1.9/");
		
		String sql;int id = 0; String name = null; int age = 0;
		try (Statement stmt = conn.createStatement()) 
		{
			
			sql = "DELETE EMPLOYEE";
			stmt.executeUpdate(sql);		
		}
		catch(SQLException ex)
		{
			ex.printStackTrace();
		}
		System.out.println("table employee deleted");
	}
}
