package com.SI_DO;

import org.springframework.beans.factory.BeanFactory;  
import org.springframework.beans.factory.xml.XmlBeanFactory;  
import org.springframework.context.ApplicationContext;  
import org.springframework.context.support.ClassPathXmlApplicationContext;  
import org.springframework.core.io.ClassPathResource;  
import org.springframework.core.io.Resource;  
  
public class Test
{  
	public static void main(String[] args) 
	{  
	    Resource r=new ClassPathResource("com/SI_DO/applicationContext.xml");  
	    BeanFactory factory=new XmlBeanFactory(r);  
	      
	    Employee e = (Employee)factory.getBean("obj");  
	    e.displayInfo();  
	      
	}  
}  
