// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Billing.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingEnrollmentAccountResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetBillingPermissions_BillingPermissionsListByEnrollmentAccount()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingPermissionsListByEnrollmentAccount.json
            // this example is just showing the usage of "BillingPermissions_ListByEnrollmentAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingEnrollmentAccountResource created on azure
            // for more information of creating BillingEnrollmentAccountResource, please refer to the document of BillingEnrollmentAccountResource
            string billingAccountName = "6100092";
            string enrollmentAccountName = "123456";
            ResourceIdentifier billingEnrollmentAccountResourceId = BillingEnrollmentAccountResource.CreateResourceIdentifier(billingAccountName, enrollmentAccountName);
            BillingEnrollmentAccountResource billingEnrollmentAccount = client.GetBillingEnrollmentAccountResource(billingEnrollmentAccountResourceId);

            // invoke the operation and iterate over the result
            await foreach (BillingPermission item in billingEnrollmentAccount.GetBillingPermissionsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckAccessBillingPermissions_CheckAccessByEnrollmentAccount()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/checkAccessByEnrollmentAccount.json
            // this example is just showing the usage of "BillingPermissions_CheckAccessByEnrollmentAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingEnrollmentAccountResource created on azure
            // for more information of creating BillingEnrollmentAccountResource, please refer to the document of BillingEnrollmentAccountResource
            string billingAccountName = "10000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string enrollmentAccountName = "123456";
            ResourceIdentifier billingEnrollmentAccountResourceId = BillingEnrollmentAccountResource.CreateResourceIdentifier(billingAccountName, enrollmentAccountName);
            BillingEnrollmentAccountResource billingEnrollmentAccount = client.GetBillingEnrollmentAccountResource(billingEnrollmentAccountResourceId);

            // invoke the operation and iterate over the result
            BillingCheckAccessContent content = new BillingCheckAccessContent()
            {
                Actions =
{
"Microsoft.Billing/billingAccounts/read","Microsoft.Subscription/subscriptions/write"
},
            };
            await foreach (BillingCheckAccessResult item in billingEnrollmentAccount.CheckAccessBillingPermissionsAsync(content))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetBillingSubscriptions_BillingSubscriptionsListByEnrollmentAccount()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingSubscriptionsListByEnrollmentAccount.json
            // this example is just showing the usage of "BillingSubscriptions_ListByEnrollmentAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingEnrollmentAccountResource created on azure
            // for more information of creating BillingEnrollmentAccountResource, please refer to the document of BillingEnrollmentAccountResource
            string billingAccountName = "6564892";
            string enrollmentAccountName = "172988";
            ResourceIdentifier billingEnrollmentAccountResourceId = BillingEnrollmentAccountResource.CreateResourceIdentifier(billingAccountName, enrollmentAccountName);
            BillingEnrollmentAccountResource billingEnrollmentAccount = client.GetBillingEnrollmentAccountResource(billingEnrollmentAccountResourceId);

            // invoke the operation and iterate over the result
            BillingEnrollmentAccountResourceGetBillingSubscriptionsOptions options = new BillingEnrollmentAccountResourceGetBillingSubscriptionsOptions() { };
            await foreach (BillingSubscriptionData item in billingEnrollmentAccount.GetBillingSubscriptionsAsync(options))
            {
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {item.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_EnrollmentAccountGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/enrollmentAccountGet.json
            // this example is just showing the usage of "EnrollmentAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingEnrollmentAccountResource created on azure
            // for more information of creating BillingEnrollmentAccountResource, please refer to the document of BillingEnrollmentAccountResource
            string billingAccountName = "6564892";
            string enrollmentAccountName = "257698";
            ResourceIdentifier billingEnrollmentAccountResourceId = BillingEnrollmentAccountResource.CreateResourceIdentifier(billingAccountName, enrollmentAccountName);
            BillingEnrollmentAccountResource billingEnrollmentAccount = client.GetBillingEnrollmentAccountResource(billingEnrollmentAccountResourceId);

            // invoke the operation
            BillingEnrollmentAccountResource result = await billingEnrollmentAccount.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingEnrollmentAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
