using CrmEarlyBound;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var svc = new CrmServiceClient(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {

                WhoAmIRequest request = new WhoAmIRequest();

                WhoAmIResponse response = (WhoAmIResponse)svc.Execute(request);

                Console.WriteLine("Your UserId is {0}", response.UserId);
                var _serviceClient = svc;

                var appUser = new EntityReference("systemuser", new Guid("adf1e42b-a24e-ec11-8c62-000d3a4439ae"));
                var role = new EntityReference("role", new Guid("9f572d55-6090-493b-904a-3956bdc55343"));
                createBulkDelete(_serviceClient);

                //assigntoteam(_serviceClient, appUser, role);



            }



        }


        private static void createBulkDelete(CrmServiceClient _serviceClient)
        {
            // Create a condition for a bulk delete request.
            // NOTE: This sample uses very specific queries for deleting records
            // that have been manually exported in order to free space.
            var opportunitiesQuery = BuildAccountQuery();

            // Create the bulk delete request.
            var bulkDeleteRequest = new BulkDeleteRequest();

            // Set the request properties.
            bulkDeleteRequest.JobName = "Retention Policy Daily";

            // Querying activities
            bulkDeleteRequest.QuerySet = new QueryExpression[]
            {
                 opportunitiesQuery
            };

            // Set the start time for the bulk delete.
            bulkDeleteRequest.StartDateTime = DateTime.Now;

            // Set the required recurrence pattern.
            bulkDeleteRequest.RecurrencePattern = "FREQ=DAILY;";

            // Set email activity properties.
            bulkDeleteRequest.SendEmailNotification = false;
            bulkDeleteRequest.ToRecipients = new Guid[] { new Guid("00000000-0000-0000-0000-000000000000" )};
            bulkDeleteRequest.CCRecipients = new Guid[] { };

            // Submit the bulk delete job.
            // NOTE: Because this is an asynchronous operation, the response will be immediate.

            var _bulkDeleteResponse =                 (BulkDeleteResponse)_serviceClient.Execute(bulkDeleteRequest);
            Console.WriteLine("The bulk delete operation has been requested.");
        }

        private static QueryExpression BuildAccountQuery()
        {
            //  Query using ConditionExpression and FilterExpression  
                ConditionExpression condition1 = new ConditionExpression();
                condition1.AttributeName = "cr66d_last_case_update";
                condition1.Operator = ConditionOperator.OlderThanXYears;
                condition1.Values.Add(3);


                ConditionExpression condition2 = new ConditionExpression();
                condition2.AttributeName = "cr66d_opencases";
                condition2.Operator = ConditionOperator.Equal;
                condition2.Values.Add(0);


                ConditionExpression condition3 = new ConditionExpression();
                condition3.AttributeName = "cr66d_legacyhold";
                condition3.Operator = ConditionOperator.Equal;
                condition3.Values.Add(false);



                FilterExpression filter1 = new FilterExpression();
                filter1.Conditions.Add(condition1);
                filter1.Conditions.Add(condition2);
            filter1.Conditions.Add(condition3);

            QueryExpression query = new QueryExpression("account");
            
                query.Criteria.AddFilter(filter1);
                return query;

        }

        private static void assigntoteam(CrmServiceClient _serviceClient, EntityReference User, EntityReference RoleEF)
        {

            String _roleName = "CEO-Business Manager";

         

            // find ROle CEO-Business Manager
            // Retrieve a role from CRM.
            QueryExpression query_Team = new QueryExpression
            {
                EntityName = Team.EntityLogicalName,
                ColumnSet = new ColumnSet(true),
                Criteria = new FilterExpression
                {
                    Conditions =
                        {
                            // You would replace the condition below with an actual role
                            // name, or skip this query if you had a role id.
                            new ConditionExpression
                            {
                                AttributeName = "name",
                                Operator = ConditionOperator.Equal,
                                Values = {_roleName}
                            }
                        }
                }
            };
            Team team = _serviceClient.RetrieveMultiple(query_Team).Entities.Cast<Team>().FirstOrDefault();
         


            // Retrieve a role from CRM.
            QueryExpression query_Role = new QueryExpression
            {
                EntityName = Role.EntityLogicalName,
                ColumnSet = new ColumnSet(true),
                Criteria = new FilterExpression
                {
                    Conditions =
                        {
                            // You would replace the condition below with an actual role
                            // name, or skip this query if you had a role id.
                            new ConditionExpression
                            {
                                AttributeName = "name",
                                Operator = ConditionOperator.Equal,
                                Values = {_roleName}
                            }
                        }
                }
            };

            Role role = _serviceClient.RetrieveMultiple(query_Role).Entities.Cast<Role>().FirstOrDefault();

            // Add the role to the team.
            _serviceClient.Associate(
                   Team.EntityLogicalName,
                   team.Id,
                   new Relationship("teamroles_association"),
                   new EntityReferenceCollection() { new EntityReference(Role.EntityLogicalName, role.Id) });

        }
    } 
}
