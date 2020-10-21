using System;
using System.Collections.Generic;
using System.Text;

namespace InterParkingEx2.Message
{
    public class MessageA : BaseMessage
    {
        public override void MyCustomMethod()
        {
            Console.WriteLine("Method is call from A");
        }
    }
}
