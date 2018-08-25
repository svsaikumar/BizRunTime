package com.ignite;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

import org.apache.ignite.Ignite;
import org.apache.ignite.Ignition;


public class JDBC_INSERT
{
	public static void main(String[] args) throws Exception,ClassNotFoundException
	{
		Ignite ignite = Ignition.start();
		ignite.cluster().active(true);
		
		Class.forName("org.apache.ignite.IgniteJdbcThinDriver");
		Connection conn = DriverManager.getConnection("jdbc:ignite:thin://192.168.1.9/");
		
		String sql1;
		
		try (Statement stmt = conn.createStatement()) 
		{			
			sql1 = "insert into employee(id, name, age) values(1, 'sai',10)";			
			stmt.executeUpdate(sql1);		
			
		}
		catch(SQLException ex)
		{
			ex.printStackTrace();
		}
		System.out.println("values inserted into employee ");
	}
}
