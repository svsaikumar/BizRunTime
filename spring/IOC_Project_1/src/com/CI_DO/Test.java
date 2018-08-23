package com.CI_DO;

import org.springframework.beans.factory.BeanFactory;  
import org.springframework.beans.factory.xml.XmlBeanFactory;  
import org.springframework.core.io.*;  
  
public class Test 
{  
    public static void main(String[] args)
    {  
          
        Resource r=new ClassPathResource("com/pack3/applicationContext.xml");  
        BeanFactory factory=new XmlBeanFactory(r);  
          
        Employee s=(Employee)factory.getBean("e");  
        s.show();  
          
    }  
}  
