package pack1;

import org.apache.rocketmq.client.consumer.DefaultMQPushConsumer;
import org.apache.rocketmq.client.consumer.listener.ConsumeConcurrentlyContext;
import org.apache.rocketmq.client.consumer.listener.ConsumeConcurrentlyStatus;
import org.apache.rocketmq.client.consumer.listener.MessageListenerConcurrently;
import org.apache.rocketmq.common.message.MessageExt;
import java.util.List;
   
public class ScheduledMessageConsumer {
   
    public static void main(String[] args) throws Exception
    {
        
        DefaultMQPushConsumer consumer = new DefaultMQPushConsumer("ExampleConsumer");
        
        consumer.subscribe("TestTopic", "*");
        
        consumer.registerMessageListener(new MessageListenerConcurrently() 
        {
            @Override
            public ConsumeConcurrentlyStatus consumeMessage(List<MessageExt> messages, ConsumeConcurrentlyContext context)
            {
                for (MessageExt message : messages)
                {
                  
                    System.out.println("Receive message[msgId=" + message.getMsgId() + "] "
                            + (System.currentTimeMillis() - message.getStoreTimestamp()) + "ms later");
                }
                return ConsumeConcurrentlyStatus.CONSUME_SUCCESS;
            }
        });
        consumer.start();
    }
}
