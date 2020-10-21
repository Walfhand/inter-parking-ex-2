using System;
using System.Collections.Generic;
using System.Text;

namespace InterParkingEx2.Message
{
    public class MessageB : BaseMessage
    {
        public override void MyCustomMethod()
        {
            Console.WriteLine("Method is call from B");
        }

        public void SomeAdditionalMethodOnB()
        {
            Console.WriteLine("Additional method on B");
        }
    }
}
