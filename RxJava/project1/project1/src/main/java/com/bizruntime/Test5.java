package com.bizruntime;


import io.reactivex.Observable;
import static org.junit.Assert.assertTrue;

public class Test5 
{
	static String result;
	public static void main(String[] args) 
	{				
		Observable<String> observable = Observable.just("Hello");
		observable.subscribe(s -> result = s);
		  
		assertTrue(result.equals("Hello"));
	}

}
