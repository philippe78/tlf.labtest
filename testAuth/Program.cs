using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAuth
{
    class Program
    {
        static void Main(string[] args)
        {

           

                // e.g. https://yourorg.crm.dynamics.com
                string url = "https://orgea88443b.crm4.dynamics.com/";
                // e.g. you@yourorg.onmicrosoft.com
                string userName = "P.Guarino@leedsbeckett.ac.uk";
                // e.g. y0urp455w0rd 
                string password = "P.Guarino@leedsbeckett.ac.uk";

                string conn = $@"
                    Url = {url};
                    AuthType = ClientSecret;
                    ClientId=183590e6-147a-44bf-8cee-02907f55f0d7;
                    ClientSecret=~CR7Q~jqSc1ksRdwMcld0V~gqezYM6NFa66As;";


                // AppId = 53addc73-864b-ec11-8f8e-6045bd88dcc1;
                // RedirectUri = app://58145B91-0C36-4500-8554-080854F2AC97;
                // LoginPrompt=Auto;
                // RequireNewInstance = True";

                using (var svc = new CrmServiceClient(conn))
                {

                    WhoAmIRequest request = new WhoAmIRequest();

                    WhoAmIResponse response = (WhoAmIResponse)svc.Execute(request);

                    Console.WriteLine("Your UserId is {0}", response.UserId);

                    Console.WriteLine("Press any key to exit.");
                    Console.ReadLine();
            }
        }

    }
}
