package com.ignite;

import org.apache.ignite.Ignite;
import org.apache.ignite.Ignition;
import org.apache.ignite.IgniteCache;

public class IgniteWorld 
{
	public static void main(String []args)
	{
		try(Ignite ignite = Ignition.start("examples/config/example-ignite.xml"))
		{
			IgniteCache <Integer,String> cache = ignite.getOrCreateCache("mycache");
			cache.put(1, "hello");
			cache.put(2, "ignite");
			cache.put(3, "world");
			
			ignite.compute().broadcast(() ->
			{
				String helloStr = cache.get(1);
				String igniteStr = cache.get(2);
				String worldStr = cache.get(3);
				
				System.out.println(helloStr  + "," + igniteStr + "," + worldStr);
			
			});
		}
	}
	
}
