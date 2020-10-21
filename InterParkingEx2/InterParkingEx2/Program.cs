using InterParkingEx2.Message;
using System;
using System.Collections.Generic;

namespace InterParkingEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseMessage> messages = new List<BaseMessage>()
            {
                new MessageA(),
                new MessageB(),
                new MessageC()
            };


            foreach (var message in messages)
            {
                message.MyCustomMethod();
                if(message is MessageB messageB)
                {
                    messageB.SomeAdditionalMethodOnB();
                }
            }
        }
    }
}
