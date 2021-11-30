using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Tooling.Connector;
using System.Configuration;

namespace tfl.test
{
    [TestClass]
    public class TeamTest
    {

        /* 
         * follow the istruction on this website to create a secret ID https://optimallogics.com/connect-to-ms-dynamics-365-crm-using-oauth-in-c-sharp/
        */

        private CrmServiceClient _serviceClient;

        [TestInitialize]
        public void BaseSetUp() {

            if (_serviceClient != null)
            {
                return;
            }
            using (var svc = new CrmServiceClient(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {

                WhoAmIRequest request = new WhoAmIRequest();

                WhoAmIResponse response = (WhoAmIResponse)svc.Execute(request);

                Console.WriteLine("Your UserId is {0}", response.UserId);
                _serviceClient = svc;

             }
        } // Exception thrown!


        [TestCleanup]
        public void BaseTearDown() { /* ... */ } // Exception thrown!


        [TestMethod]
        public void TeamTestCreateNewUser()
        {
        }

        [TestMethod]
        public void TeamTestCreateTeam()
        {
        }

        
    }
}
