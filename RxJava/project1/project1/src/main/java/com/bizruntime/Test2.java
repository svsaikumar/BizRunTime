package com.bizruntime;

import io.reactivex.Observable;





public class Test2 
{
	public static void main(String[] args)
	{
		String greeting = "Hello world!";

		Observable<String> observable = Observable.just(greeting);

		observable.subscribe(item -> System.out.println(item));
	}
}
