// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Media.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Media.Samples
{
    public partial class Sample_ContentKeyPolicyCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsContentKeyPoliciesOrderedByLastModified()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/content-key-policies-list-by-lastModified.json
            // this example is just showing the usage of "ContentKeyPolicies_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this ContentKeyPolicyResource
            ContentKeyPolicyCollection collection = mediaServicesAccount.GetContentKeyPolicies();

            // invoke the operation and iterate over the result
            string orderby = "properties/lastModified";
            await foreach (ContentKeyPolicyResource item in collection.GetAllAsync(orderby: orderby))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContentKeyPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsContentKeyPoliciesWithCreatedAndLastModifiedFilters()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/content-key-policies-list-in-date-range.json
            // this example is just showing the usage of "ContentKeyPolicies_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this ContentKeyPolicyResource
            ContentKeyPolicyCollection collection = mediaServicesAccount.GetContentKeyPolicies();

            // invoke the operation and iterate over the result
            string filter = "properties/lastModified gt 2016-06-01 and properties/created lt 2013-07-01";
            await foreach (ContentKeyPolicyResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContentKeyPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsAllContentKeyPolicies()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/content-key-policies-list-all.json
            // this example is just showing the usage of "ContentKeyPolicies_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this ContentKeyPolicyResource
            ContentKeyPolicyCollection collection = mediaServicesAccount.GetContentKeyPolicies();

            // invoke the operation and iterate over the result
            await foreach (ContentKeyPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContentKeyPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAContentKeyPolicyByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/content-key-policies-get-by-name.json
            // this example is just showing the usage of "ContentKeyPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this ContentKeyPolicyResource
            ContentKeyPolicyCollection collection = mediaServicesAccount.GetContentKeyPolicies();

            // invoke the operation
            string contentKeyPolicyName = "PolicyWithMultipleOptions";
            ContentKeyPolicyResource result = await collection.GetAsync(contentKeyPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContentKeyPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAContentKeyPolicyByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/content-key-policies-get-by-name.json
            // this example is just showing the usage of "ContentKeyPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this ContentKeyPolicyResource
            ContentKeyPolicyCollection collection = mediaServicesAccount.GetContentKeyPolicies();

            // invoke the operation
            string contentKeyPolicyName = "PolicyWithMultipleOptions";
            bool result = await collection.ExistsAsync(contentKeyPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAContentKeyPolicyByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/content-key-policies-get-by-name.json
            // this example is just showing the usage of "ContentKeyPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this ContentKeyPolicyResource
            ContentKeyPolicyCollection collection = mediaServicesAccount.GetContentKeyPolicies();

            // invoke the operation
            string contentKeyPolicyName = "PolicyWithMultipleOptions";
            NullableResponse<ContentKeyPolicyResource> response = await collection.GetIfExistsAsync(contentKeyPolicyName);
            ContentKeyPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContentKeyPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesAContentKeyPolicyWithClearKeyOptionAndTokenRestriction()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/content-key-policies-create-nodrm-token.json
            // this example is just showing the usage of "ContentKeyPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this ContentKeyPolicyResource
            ContentKeyPolicyCollection collection = mediaServicesAccount.GetContentKeyPolicies();

            // invoke the operation
            string contentKeyPolicyName = "PolicyWithClearKeyOptionAndSwtTokenRestriction";
            ContentKeyPolicyData data = new ContentKeyPolicyData()
            {
                Description = "ArmPolicyDescription",
                Options =
{
new ContentKeyPolicyOption(new ContentKeyPolicyClearKeyConfiguration(),new ContentKeyPolicyTokenRestriction("urn:issuer","urn:audience",new ContentKeyPolicySymmetricTokenKey(Convert.FromBase64String("AAAAAAAAAAAAAAAAAAAAAA==")),ContentKeyPolicyRestrictionTokenType.Swt))
{
Name = "ClearKeyOption",
}
},
            };
            ArmOperation<ContentKeyPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, contentKeyPolicyName, data);
            ContentKeyPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContentKeyPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesAContentKeyPolicyWithPlayReadyOptionAndOpenRestriction()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/content-key-policies-create-playready-open.json
            // this example is just showing the usage of "ContentKeyPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this ContentKeyPolicyResource
            ContentKeyPolicyCollection collection = mediaServicesAccount.GetContentKeyPolicies();

            // invoke the operation
            string contentKeyPolicyName = "PolicyWithPlayReadyOptionAndOpenRestriction";
            ContentKeyPolicyData data = new ContentKeyPolicyData()
            {
                Description = "ArmPolicyDescription",
                Options =
{
new ContentKeyPolicyOption(new ContentKeyPolicyPlayReadyConfiguration(new ContentKeyPolicyPlayReadyLicense[]
{
new ContentKeyPolicyPlayReadyLicense(true,ContentKeyPolicyPlayReadyLicenseType.Persistent,new ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader(),ContentKeyPolicyPlayReadyContentType.UltraVioletDownload)
{
SecurityLevel = PlayReadySecurityLevel.SL150,
BeginOn = DateTimeOffset.Parse("2017-10-16T18:22:53.46Z"),
PlayRight = new ContentKeyPolicyPlayReadyPlayRight(false,true,false,ContentKeyPolicyPlayReadyUnknownOutputPassingOption.NotAllowed)
{
ScmsRestriction = 2,
},
}
}),new ContentKeyPolicyOpenRestriction())
{
Name = "ArmPolicyOptionName",
}
},
            };
            ArmOperation<ContentKeyPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, contentKeyPolicyName, data);
            ContentKeyPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContentKeyPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesAContentKeyPolicyWithWidevineOptionAndTokenRestriction()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/content-key-policies-create-widevine-token.json
            // this example is just showing the usage of "ContentKeyPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this ContentKeyPolicyResource
            ContentKeyPolicyCollection collection = mediaServicesAccount.GetContentKeyPolicies();

            // invoke the operation
            string contentKeyPolicyName = "PolicyWithWidevineOptionAndJwtTokenRestriction";
            ContentKeyPolicyData data = new ContentKeyPolicyData()
            {
                Description = "ArmPolicyDescription",
                Options =
{
new ContentKeyPolicyOption(new ContentKeyPolicyWidevineConfiguration("{\"allowed_track_types\":\"SD_HD\",\"content_key_specs\":[{\"track_type\":\"SD\",\"security_level\":1,\"required_output_protection\":{\"hdcp\":\"HDCP_V2\"}}],\"policy_overrides\":{\"can_play\":true,\"can_persist\":true,\"can_renew\":false}}"),new ContentKeyPolicyTokenRestriction("urn:issuer","urn:audience",new ContentKeyPolicyRsaTokenKey(Convert.FromBase64String("AQAB"),Convert.FromBase64String("AQAD")),ContentKeyPolicyRestrictionTokenType.Jwt)
{
AlternateVerificationKeys =
{
new ContentKeyPolicySymmetricTokenKey(Convert.FromBase64String("AAAAAAAAAAAAAAAAAAAAAA=="))
},
})
{
Name = "widevineoption",
}
},
            };
            ArmOperation<ContentKeyPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, contentKeyPolicyName, data);
            ContentKeyPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContentKeyPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesAContentKeyPolicyWithMultipleOptions()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/content-key-policies-create-multiple-options.json
            // this example is just showing the usage of "ContentKeyPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this ContentKeyPolicyResource
            ContentKeyPolicyCollection collection = mediaServicesAccount.GetContentKeyPolicies();

            // invoke the operation
            string contentKeyPolicyName = "PolicyCreatedWithMultipleOptions";
            ContentKeyPolicyData data = new ContentKeyPolicyData()
            {
                Description = "ArmPolicyDescription",
                Options =
{
new ContentKeyPolicyOption(new ContentKeyPolicyClearKeyConfiguration(),new ContentKeyPolicyTokenRestriction("urn:issuer","urn:audience",new ContentKeyPolicySymmetricTokenKey(Convert.FromBase64String("AAAAAAAAAAAAAAAAAAAAAA==")),ContentKeyPolicyRestrictionTokenType.Swt))
{
Name = "ClearKeyOption",
},new ContentKeyPolicyOption(new ContentKeyPolicyWidevineConfiguration("{\"allowed_track_types\":\"SD_HD\",\"content_key_specs\":[{\"track_type\":\"SD\",\"security_level\":1,\"required_output_protection\":{\"hdcp\":\"HDCP_V2\"}}],\"policy_overrides\":{\"can_play\":true,\"can_persist\":true,\"can_renew\":false}}"),new ContentKeyPolicyOpenRestriction())
{
Name = "widevineoption",
}
},
            };
            ArmOperation<ContentKeyPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, contentKeyPolicyName, data);
            ContentKeyPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContentKeyPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
