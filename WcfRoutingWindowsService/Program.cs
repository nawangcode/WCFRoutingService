using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Routing;

namespace WcfRoutingWindowsService
{
    class Program
    {
        static void Main(string[] args)
        {
            //SERVICE HOST
            ServiceHost host = new ServiceHost(typeof(RoutingService));
  //          foreach (var sb in host.Description.Behaviors)
  //          {
  //              ServiceDebugBehavior sdb = sb as ServiceDebugBehavior;
  //              if (sdb != null)
  //              {
  //                  sdb.IncludeExceptionDetailInFaults = true;
  //              }
  //          }

  //          //SERVICE END POINT - three endpoints: the service host (the router) and the two services to which it routes requests
  //          ContractDescription cdRouter = ContractDescription.GetContract(typeof(IRequestReplyRouter));

  //          // ROUTER'S SERVICE END POINT
  //          ServiceEndpoint se = new ServiceEndpoint(cdRouter,
  //new WSHttpBinding(),
  //new EndpointAddress(
  //  "http://localhost:9000/CustomerService/"));
  //          host.AddServiceEndpoint(se);

  //          ServiceEndpoint MainService = new ServiceEndpoint(cdRouter,
  //            new WSHttpBinding(),
  //            new EndpointAddress(
  //              "http://localhost:50281/WCFService/Service.svc"));


  //          MessageFilterTable<IEnumerable<ServiceEndpoint>> mft =
  //new MessageFilterTable<IEnumerable<ServiceEndpoint>>();
  //          RoutingConfiguration rc = new RoutingConfiguration(mft, false);
  //          RoutingBehavior rb = new RoutingBehavior(rc);
  //          host.Description.Behaviors.Add(rb);

  //          List<ServiceEndpoint> primaryEndPoints = new List<ServiceEndpoint>();
  //          primaryEndPoints.Add(MainService);
  //          MessageFilter mamf = new MatchAllMessageFilter();
  //          mft.Add(mamf, primaryEndPoints);

            host.Open();
            Console.WriteLine("Router up");
            Console.ReadLine();
            host.Close();
        }
    }
}
