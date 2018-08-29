package com.bizruntime;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import io.reactivex.Observable;

public class Test3 
{
	public static void main(String[] args) 
	{
		List<Integer> list = new ArrayList<>(Arrays.asList(1, 2, 3, 4, 5, 6, 7, 8));

		Observable<Integer> observable = Observable.fromIterable(list);

		observable.subscribe(item -> System.out.println(item),
						    error -> error.printStackTrace(), 
						    () -> System.out.println("Done"));
	}
}
