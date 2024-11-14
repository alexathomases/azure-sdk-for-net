// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ServiceApiResolverPolicyCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ApiManagementListGraphQLApiResolverPolicies()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementListGraphQLApiResolverPolicies.json
            // this example is just showing the usage of "GraphQLApiResolverPolicy_ListByResolver" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResolverContractResource created on azure
            // for more information of creating ResolverContractResource, please refer to the document of ResolverContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "599e2953193c3c0bd0b3e2fa";
            string resolverId = "599e29ab193c3c0bd0b3e2fb";
            ResourceIdentifier resolverContractResourceId = ResolverContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, resolverId);
            ResolverContractResource resolverContract = client.GetResolverContractResource(resolverContractResourceId);

            // get the collection of this ServiceApiResolverPolicyResource
            ServiceApiResolverPolicyCollection collection = resolverContract.GetServiceApiResolverPolicies();

            // invoke the operation and iterate over the result
            await foreach (ServiceApiResolverPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PolicyContractData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetGraphQLApiResolverPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetGraphQLApiResolverPolicy.json
            // this example is just showing the usage of "GraphQLApiResolverPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResolverContractResource created on azure
            // for more information of creating ResolverContractResource, please refer to the document of ResolverContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b539c53f5b0062040001";
            string resolverId = "5600b53ac53f5b0062080006";
            ResourceIdentifier resolverContractResourceId = ResolverContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, resolverId);
            ResolverContractResource resolverContract = client.GetResolverContractResource(resolverContractResourceId);

            // get the collection of this ServiceApiResolverPolicyResource
            ServiceApiResolverPolicyCollection collection = resolverContract.GetServiceApiResolverPolicies();

            // invoke the operation
            PolicyName policyId = PolicyName.Policy;
            ServiceApiResolverPolicyResource result = await collection.GetAsync(policyId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ApiManagementGetGraphQLApiResolverPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetGraphQLApiResolverPolicy.json
            // this example is just showing the usage of "GraphQLApiResolverPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResolverContractResource created on azure
            // for more information of creating ResolverContractResource, please refer to the document of ResolverContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b539c53f5b0062040001";
            string resolverId = "5600b53ac53f5b0062080006";
            ResourceIdentifier resolverContractResourceId = ResolverContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, resolverId);
            ResolverContractResource resolverContract = client.GetResolverContractResource(resolverContractResourceId);

            // get the collection of this ServiceApiResolverPolicyResource
            ServiceApiResolverPolicyCollection collection = resolverContract.GetServiceApiResolverPolicies();

            // invoke the operation
            PolicyName policyId = PolicyName.Policy;
            bool result = await collection.ExistsAsync(policyId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ApiManagementGetGraphQLApiResolverPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetGraphQLApiResolverPolicy.json
            // this example is just showing the usage of "GraphQLApiResolverPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResolverContractResource created on azure
            // for more information of creating ResolverContractResource, please refer to the document of ResolverContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b539c53f5b0062040001";
            string resolverId = "5600b53ac53f5b0062080006";
            ResourceIdentifier resolverContractResourceId = ResolverContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, resolverId);
            ResolverContractResource resolverContract = client.GetResolverContractResource(resolverContractResourceId);

            // get the collection of this ServiceApiResolverPolicyResource
            ServiceApiResolverPolicyCollection collection = resolverContract.GetServiceApiResolverPolicies();

            // invoke the operation
            PolicyName policyId = PolicyName.Policy;
            NullableResponse<ServiceApiResolverPolicyResource> response = await collection.GetIfExistsAsync(policyId);
            ServiceApiResolverPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PolicyContractData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApiManagementCreateGraphQLApiResolverPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateGraphQLApiResolverPolicy.json
            // this example is just showing the usage of "GraphQLApiResolverPolicy_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResolverContractResource created on azure
            // for more information of creating ResolverContractResource, please refer to the document of ResolverContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b57e7e8880006a040001";
            string resolverId = "5600b57e7e8880006a080001";
            ResourceIdentifier resolverContractResourceId = ResolverContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, resolverId);
            ResolverContractResource resolverContract = client.GetResolverContractResource(resolverContractResourceId);

            // get the collection of this ServiceApiResolverPolicyResource
            ServiceApiResolverPolicyCollection collection = resolverContract.GetServiceApiResolverPolicies();

            // invoke the operation
            PolicyName policyId = PolicyName.Policy;
            PolicyContractData data = new PolicyContractData()
            {
                Value = "<http-data-source><http-request><set-method>GET</set-method><set-backend-service base-url=\"https://some.service.com\" /><set-url>/api/users</set-url></http-request></http-data-source>",
                Format = PolicyContentFormat.Xml,
            };
            ETag? ifMatch = new ETag("*");
            ArmOperation<ServiceApiResolverPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, policyId, data, ifMatch: ifMatch);
            ServiceApiResolverPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
