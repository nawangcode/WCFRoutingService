using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading;
namespace DemoClient
{
    class Program
    {
  //http://www.codeproject.com/Articles/566691/WCF-From-a-Beginners-perspective-a-Tutorial
        //http://www.codeproject.com/Articles/772854/WCF-Routing-Service-Part-I-Basic-Concept-Simple-Ro
      static void Main(string[] args)
        {

            //RequestReplyRouterClient client = new RequestReplyRouterClient("BasicHttpBinding_IService");
            //var c = client.ChannelFactory.CreateChannel();
            Console.WriteLine("hello client");
          
            var cf = new ChannelFactory<IService>("BasicHttpBinding_IService");
            var channel = cf.CreateChannel();
            int i = 1;
            //while (true)
            {
                Console.WriteLine("\n\n Reply from Server :" + channel.GetData(i++));
                Console.WriteLine("\n\n------------------------------------------------------");
              //  Thread.Sleep(1000);
            }

            var cf2 = new ChannelFactory<IService>("BasicHttpBinding_IService2");
            var channel2 = cf2.CreateChannel();
            int i2 = 11;
            //while (true)
            {
                Console.WriteLine("\n\n Reply from Server :" + channel2.GetData(i2++));
                Console.WriteLine("\n\n------------------------------------------------------");
                Thread.Sleep(1000);
            }

            var cf3 = new ChannelFactory<IService>("BasicHttpBinding_IService3");
            var channel3 = cf3.CreateChannel();
          //channel3.
            //int i2 = 11;
            ////while (true)
            //{
            //    Console.WriteLine("\n\n Reply from Server :" + channel2.GetData(i2++));
            //    Console.WriteLine("\n\n------------------------------------------------------");
            //    Thread.Sleep(1000);
            //}
            //ServiceClient client = new ServiceClient();

            //// Use the 'client' variable to call operations on the service.
            //Console.WriteLine(client.GetData(10));

            //CompositeType type = new CompositeType();
            //type.BoolValue = true;
            //type.StringValue = "NaW";

            //CompositeType var = client.GetDataUsingDataContract(type);
            //Console.WriteLine("1: " + var.BoolValue + " 2: " + var.StringValue);
            //// Always close the client.
            Console.ReadLine();
            ((IClientChannel)channel).Close();
            ((IClientChannel)channel2).Close();
        }
    }
}
