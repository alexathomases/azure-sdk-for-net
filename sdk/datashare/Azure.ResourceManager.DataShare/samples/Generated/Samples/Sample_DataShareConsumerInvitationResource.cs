// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.DataShare.Samples
{
    public partial class Sample_DataShareConsumerInvitationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ConsumerInvitationsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ConsumerInvitations_Get.json
            // this example is just showing the usage of "ConsumerInvitations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareConsumerInvitationResource created on azure
            // for more information of creating DataShareConsumerInvitationResource, please refer to the document of DataShareConsumerInvitationResource
            AzureLocation location = new AzureLocation("East US 2");
            Guid invitationId = Guid.Parse("dfbbc788-19eb-4607-a5a1-c74181bfff03");
            ResourceIdentifier dataShareConsumerInvitationResourceId = DataShareConsumerInvitationResource.CreateResourceIdentifier(location, invitationId);
            DataShareConsumerInvitationResource dataShareConsumerInvitation = client.GetDataShareConsumerInvitationResource(dataShareConsumerInvitationResourceId);

            // invoke the operation
            DataShareConsumerInvitationResource result = await dataShareConsumerInvitation.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataShareConsumerInvitationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
