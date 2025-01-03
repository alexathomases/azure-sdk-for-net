// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearningCompute.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.MachineLearningCompute.Samples
{
    public partial class Sample_TenantResourceExtensions
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAvailableOperationsMachineLearningComputes_MachineLearningComputeListAvailableOperations()
        {
            // Generated from example definition: specification/machinelearningcompute/resource-manager/Microsoft.MachineLearningCompute/preview/2017-08-01-preview/examples/MachineLearningCompute_ListAvailableOperations.json
            // this example is just showing the usage of "MachineLearningCompute_ListAvailableOperations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            TenantResource tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation and iterate over the result
            await foreach (ResourceOperation item in tenantResource.GetAvailableOperationsMachineLearningComputesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
