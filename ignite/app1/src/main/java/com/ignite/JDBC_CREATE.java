package com.ignite;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

import org.apache.ignite.Ignite;
import org.apache.ignite.Ignition;


public class JDBC_CREATE
{
	public static void main(String[] args) throws Exception,ClassNotFoundException
	{
		Ignite ignite = Ignition.start();
		ignite.cluster().active(true);
		
		Class.forName("org.apache.ignite.IgniteJdbcThinDriver");
		Connection conn = DriverManager.getConnection("jdbc:ignite:thin://192.168.1.9/");
		
		String sql;
		try (Statement stmt = conn.createStatement()) 
		{
			sql = "create table employee(id int primary key, name varchar2(50), age int)";
			stmt.execute(sql);
		}
		catch(SQLException ex)
		{
			ex.printStackTrace();
		}
		System.out.println("Table employee created");
	}
}
