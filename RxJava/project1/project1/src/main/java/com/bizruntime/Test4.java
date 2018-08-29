package com.bizruntime;

import org.reactivestreams.Subscriber;
import org.reactivestreams.Subscription;

import io.reactivex.Observable;
import io.reactivex.ObservableEmitter;
import io.reactivex.ObservableOnSubscribe;
import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;

public class Test4
{
	public static void main(String[] args) 
	{
		@SuppressWarnings("unchecked")
		Observable<String> myObservable = Observable.create(new ObservableOnSubscribe() 
		{
			@SuppressWarnings("unused")
			public void call(Subscriber<? super String>sub)
			{
				sub.onNext("Hello World");
				sub.onComplete();
			}

			@Override
			public void subscribe(ObservableEmitter arg0) throws Exception 
			{
				// TODO Auto-generated method stub
				
			}
		});
			
		
		Subscriber<String> mySubscriber = new Subscriber<String>() 
		{
            @Override
            public void onNext(String s) 
            {
                System.out.println(s);
            }

            @Override
            public void onComplete() 
            {
            }

            @Override
            public void onError(Throwable e) 
            {
            	
            }
			@Override
			public void onSubscribe(Subscription arg0)
			{
				// TODO Auto-generated method stub
				
			}
        };

        Observer<String> myObserver = new Observer<String>() 
        {
            @Override
            public void onNext(String s)
            {
                System.out.println("MyObserver onNext(): "+ s);
            }

            @Override
            public void onComplete()
            {
                System.out.println("Observer complete");
            }

            @Override
            public void onError(Throwable e) 
            {
            	
            }

			@Override
			public void onSubscribe(Disposable arg0)
			{
				// TODO Auto-generated method stub
				
			}
        };
	}
	

}
