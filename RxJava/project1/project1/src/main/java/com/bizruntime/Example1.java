package com.bizruntime;

import io.reactivex.Observable;
import io.reactivex.ObservableEmitter;
import io.reactivex.ObservableOnSubscribe;
import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;




public class Example1
{
	public static void main(String [] args)
	{
		Observable<String> observable = Observable.create(new ObservableOnSubscribe<String>() 
		{			
			@Override			 
			public void subscribe(ObservableEmitter<String> e) throws Exception 
			{
				e.onNext("one");
				e.onNext("two");
				e.onNext("Three");
				e.onComplete();
			}
		});
		Observer<String> observer = new Observer<String>() 
		{
			  @Override	
			  public void onSubscribe(Disposable d)
			  {				  			
				  System.out.println("observer subscribed to observable - on subscribe");
			  }
			  @Override
			  public void onNext(String value)
			  {				 
				  System.out.println("observer-onNext: " + value);
			  }
			 
			  @Override
			  public void onError(Throwable e)
			  {				
				  System.out.println("observer - onError");
			  }
			 
			  @Override
			  public void onComplete() 
			  {				
				  System.out.println("observer-on complete");
			  }			
			};				
			observable.subscribe(observer);
	}
}
