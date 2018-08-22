package com.pack2;

import org.springframework.beans.factory.BeanFactory;  
import org.springframework.beans.factory.xml.XmlBeanFactory;  
import org.springframework.core.io.*;  
  
public class TestEmployee
{  
    public static void main(String[] args) 
    {  
          
        Resource r=new ClassPathResource("com/pack2/applicationContext.xml");  
        BeanFactory factory=new XmlBeanFactory(r);  
          
        Employee s=(Employee)factory.getBean("emp");  
        s.show();  
    }  
}  
