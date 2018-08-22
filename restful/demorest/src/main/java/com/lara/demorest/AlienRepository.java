package com.lara.demorest;

import java.util.ArrayList;
import java.util.List;

public class AlienRepository 
{
	List<Alien> aliens;
	
	public AlienRepository()
	{
		aliens = new ArrayList<Alien>();
		
		Alien a1 = new Alien();
		a1.setId(101);
		a1.setName("venkat");
		a1.setPoints(10);
		
		
		Alien a2 = new Alien();
		a2.setId(102);
		a2.setName("sai");
		a2.setPoints(20);
		
		Alien a3 = new Alien();
		a3.setId(103);
		a3.setName("kumar");
		a3.setPoints(30);
		
		
		aliens.add(a1);
		aliens.add(a2);
		aliens.add(a3);
		
	}
	public List<Alien> getAliens()
	{		
		return aliens;
	} 
	public Alien getAlien(int id)
	{			
		for(Alien a : aliens)
		{
			if(a.getId() == id)
			{
				return a;
			}
		}
		return  null;
	}
	public void create(Alien a1)
	{
		aliens.add(a1);
	}
	/*public void update(int id, Alien a1)
	{
		ArrayList<Alien> aliens = (ArrayList<Alien>) getAliens();
		for(Alien a : aliens)
		{
			if(a.getId() == id)
			{
				a.setName(a1.getName());
				a.setPoints(a1.getPoints());
			}
		}
		getAliens();
	}*/
}
