using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tlf.labtest.Setup
{
    public class CreateBulkDeleteJob : CodeActivity
    {
        protected override void Execute(CodeActivityContext executionContext)
        {
            //Create the tracing service
            ITracingService tracingService = executionContext.GetExtension<ITracingService>();

            //Create the context
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

            createBulkDelete(service);
            tracingService.Trace("Creating Account");

        }

        private  void createBulkDelete(IOrganizationService _serviceClient)
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
            bulkDeleteRequest.ToRecipients = new Guid[] { new Guid("00000000-0000-0000-0000-000000000000") };
            bulkDeleteRequest.CCRecipients = new Guid[] { };

            // Submit the bulk delete job.
            // NOTE: Because this is an asynchronous operation, the response will be immediate.

            var _bulkDeleteResponse = (BulkDeleteResponse)_serviceClient.Execute(bulkDeleteRequest);
          
        }



        private QueryExpression BuildAccountQuery()
        {
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
    }
}
