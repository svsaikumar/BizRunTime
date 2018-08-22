package pack1;

import org.apache.rocketmq.client.producer.DefaultMQProducer;
import org.apache.rocketmq.client.producer.SendResult;
import org.apache.rocketmq.common.message.Message;
import org.apache.rocketmq.remoting.common.RemotingHelper;

public class test1 
{
	public static void main(String []args) throws Exception
	{		
		DefaultMQProducer producer = new DefaultMQProducer("producer1");
		producer.start();
		for(int i = 0; i < 10; i++)
		{
			Message message = new Message("TopicTest10", "first_tag", ("hello from topictest10" + i).getBytes(RemotingHelper.DEFAULT_CHARSET));
			SendResult result = producer.send(message);
			System.out.printf("%s%n", result);
		}
		producer.shutdown();		 
	}
}
