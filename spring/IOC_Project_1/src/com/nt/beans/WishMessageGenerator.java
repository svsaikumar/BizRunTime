package com.nt.beans;

import java.util.Date;

public class WishMessageGenerator 
{
	private Date date;
	public void setDate(Date date)
	{
		this.date = date;
	}
	public String GenerateWishMessages(String name)
	{
		int hour = 0;
		hour = date.getHours();
		if(hour < 12)
			return "Good Morning:" + name;
		else if(hour < 16)
			return "Good afternoon:" + name;
		else if(hour < 20)
			return "Good evening:" + name;
		else
			return "Good Night:" + name;
		
	}
}
