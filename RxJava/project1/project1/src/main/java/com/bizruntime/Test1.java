package com.bizruntime;

import io.reactivex.Flowable;

public class Test1 
{
    public static void main(String[] args)
    {
    	
    	
        Flowable.just("Hello world").subscribe(System.out::println);
    }
}
