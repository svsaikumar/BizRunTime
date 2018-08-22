package com.pack1;

import org.springframework.beans.factory.BeanFactory;  
import org.springframework.beans.factory.xml.XmlBeanFactory;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;
import org.springframework.core.io.ClassPathResource;  
import org.springframework.core.io.Resource;  
  
public class studentTest 
{  
	public static void main(String[] args)
	{  
		//Resource resource=new ClassPathResource("com/pack1/applicationContext.xml");  
		//BeanFactory factory=new XmlBeanFactory(resource);  
		
		
		ApplicationContext context = new ClassPathXmlApplicationContext("com/pack1/applicationContext.xml");
      
		student student=(student)context.getBean("studentbean");  
		student.displayInfo();  
	}  
}  


