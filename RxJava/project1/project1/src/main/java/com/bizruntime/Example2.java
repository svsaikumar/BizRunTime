package com.bizruntime;

import io.reactivex.Observable;

import io.reactivex.disposables.Disposable;
import io.reactivex.observers.DisposableObserver;




public class Example2
{
	public static void main(String [] args)
	{
		Disposable d = Observable.just("Hello world!")
				
				.subscribeWith(new DisposableObserver<String>()
				{
				        @Override public void onStart()
				        {
				            System.out.println("Start!");
				        }
				        @Override public void onNext(String t) 
				        {
				            System.out.println(t);
				        }
				        @Override public void onError(Throwable t) 
				        {
				            t.printStackTrace();
				        }
				        @Override public void onComplete()
				        {
				            System.out.println("Done!");
				        }
				});

			d.dispose();//the connection between observable and observer is disconnected

	}
}
