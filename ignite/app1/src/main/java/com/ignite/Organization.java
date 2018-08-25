package com.ignite;

import java.io.Serializable;

import org.apache.ignite.cache.query.annotations.QuerySqlField;

public class Organization implements Serializable
{
	@QuerySqlField(index = true)
	private int id;
	
	@QuerySqlField(index = true)
	private String name;
	
	@QuerySqlField(index = true)
	private double salary;
	
	public Organization(int id, String name, double salary)
	{
		this.id = id;
		this.name = name;
		this.salary = salary;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
	
	@Override
	public String toString()
	{
		return "Organization [id=" + id + ", name=" + name + ']';
	}
}
