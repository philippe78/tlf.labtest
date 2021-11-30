using CrmEarlyBound;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfl.test
{
    [TestClass]
    public class RetentionTest
    {

         private List<Guid> accounts = new List<Guid>();


        [TestInitialize]
        public void BaseSetUp()
        {
            
        } 


        [TestCleanup]
        public void BaseTearDown() { /* ... */ } // Exception thrown!


        [TestMethod]
        public void TeamTestDeleteAccountAndCase()
        {

            using (var svc = new CrmServiceClient(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
               var  _serviceClient = svc;


            var AccountName = "Test_" + Guid.NewGuid().ToString();
            
            var account = new Account();
                // set attribute values
                // string primary name
            account.Name = AccountName;
            // Boolean (Two option)
            account.CreditOnHold = false;
            // DateTime
            account.LastOnHoldTime = new DateTime(2017, 1, 1);
            // Double
            account.Address1_Latitude = 47.642311;
            account.Address1_Longitude = -122.136841;
            // Int
            account.NumberOfEmployees = 500;
            // Money
            account.Revenue = new Money(new decimal(5000000.00));
            // Picklist (Option set)
            account.AccountCategoryCode = Account_AccountCategoryCode.PreferredCustomer;//Preferred customer
            Guid accountid = _serviceClient.Create(account);
            account.Id = accountid;

            accounts.Add(accountid);
            var incident = new Incident();


            incident.CustomerId = account.ToEntityReference();
            incident.Description = "Test lab";
            incident.Title = "Case " + AccountName;
            Guid incidentID = _serviceClient.Create(incident);
                incident.Id = incidentID;

                _serviceClient.Delete(account.LogicalName,account.Id);

                    ConditionExpression condition1 = new ConditionExpression();
                    condition1.AttributeName = "incidentid";
                    condition1.Operator = ConditionOperator.Equal;
                    condition1.Values.Add(incidentID);

                    FilterExpression filter1 = new FilterExpression();
                    filter1.Conditions.Add(condition1);

                    QueryExpression query = new QueryExpression("incident");

                    query.Criteria.AddFilter(filter1);


                    EntityCollection result1 = _serviceClient.RetrieveMultiple(query);

                    Assert.AreEqual(0, result1.Entities.Count);
               




            }

        }





    }
}
