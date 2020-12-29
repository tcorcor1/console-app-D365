using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using Microsoft.Xrm.Sdk;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Xrm.Sdk.Messages;

namespace D365_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Setup
            Console.WriteLine("Creating Service Client");
            CrmServiceClient oMSCRMConn = new CrmServiceClient(ConfigurationManager.ConnectionStrings["tldr-profile1"].ConnectionString);
            Console.WriteLine("Setting Up Org Service");
            IOrganizationService service = (IOrganizationService)oMSCRMConn.OrganizationWebProxyClient != null ? (IOrganizationService)oMSCRMConn.OrganizationWebProxyClient : (IOrganizationService)oMSCRMConn.OrganizationServiceProxy;
            Console.WriteLine(oMSCRMConn.IsReady ? "Connected" : "Failed to Connect");
            Console.WriteLine($"Current User: {((WhoAmIResponse)service.Execute(new WhoAmIRequest())).UserId}");
            #endregion

            //Write
            //Some
            //Code

        }
    }
}
