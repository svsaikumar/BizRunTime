package com.ignite;

import org.apache.ignite.IgniteException;
import org.apache.ignite.Ignition;

public class IgniteNodeStartUp 
{
	public static void main(String [] args) throws IgniteException
	{
		Ignition.start("examples/config/example-ignite.xml");
	}
}
