package com.lara.demorest;

import java.util.ArrayList;

import javax.ws.rs.DELETE;
import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.PUT;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;
import java.util.List;

@Path("aliens")
public class AlienResource
{
	 
	AlienRepository repo = new AlienRepository(); 
	@GET
	@Produces({MediaType.APPLICATION_XML, MediaType.APPLICATION_JSON})
	public ArrayList<Alien> getAliens()
	{		
		System.out.println("alien called");
		return (ArrayList<Alien>) repo.getAliens();
	}
	
	@GET
	@Path("alien/{id}")
	public Alien getAlien(@PathParam("id")int id)
	{		
		return repo.getAlien(id);
	}
	@POST
	@Path("alien")
	public Alien createAlien(Alien a1)
	{
		System.out.println(a1 + "done");
		repo.create(a1);
		return a1;
	}
	@PUT
	@Path("alien/{id}")
	public ArrayList<Alien> UpdateAlien(@PathParam("id") int id, Alien a1)
	{
		//System.out.println("this is calling");
		//repo.update(id, a1);
		//return (ArrayList<Alien>) repo.getAliens();
		
		ArrayList<Alien> aliens = (ArrayList<Alien>) repo.getAliens();		
		for(Alien a : aliens)
		{
			if(a.getId() == id)
			{
				a.setName(a1.getName());
				a.setPoints(a1.getPoints());
			}
		}
		return (ArrayList<Alien>) repo.getAliens();
	}
	
	@DELETE
	@Path("alien/{id}")
	public ArrayList<Alien>  deleteAlien(@PathParam("id") int id)
	{	
		int i = 0; int index = 0;
		ArrayList<Alien> aliens = (ArrayList<Alien>) repo.getAliens();
		for(Alien a : aliens)
		{		
			if(a.getId() == id)
			{
				index = i;
				System.out.println("delete calleds");
				break;
			}
			i++;
		}
		aliens.remove(index);
		return (ArrayList<Alien>) repo.getAliens();
	}

}
