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
    public partial class Sample_MediaAssetTrackCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsAllTracks()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/asset-tracks-list-all.json
            // this example is just showing the usage of "Tracks_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaAssetResource created on azure
            // for more information of creating MediaAssetResource, please refer to the document of MediaAssetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string assetName = "ClimbingMountRainer";
            ResourceIdentifier mediaAssetResourceId = MediaAssetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, assetName);
            MediaAssetResource mediaAsset = client.GetMediaAssetResource(mediaAssetResourceId);

            // get the collection of this MediaAssetTrackResource
            MediaAssetTrackCollection collection = mediaAsset.GetMediaAssetTracks();

            // invoke the operation and iterate over the result
            await foreach (MediaAssetTrackResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaAssetTrackData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetATrackByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/asset-tracks-get-by-name.json
            // this example is just showing the usage of "Tracks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaAssetResource created on azure
            // for more information of creating MediaAssetResource, please refer to the document of MediaAssetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string assetName = "ClimbingMountRainer";
            ResourceIdentifier mediaAssetResourceId = MediaAssetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, assetName);
            MediaAssetResource mediaAsset = client.GetMediaAssetResource(mediaAssetResourceId);

            // get the collection of this MediaAssetTrackResource
            MediaAssetTrackCollection collection = mediaAsset.GetMediaAssetTracks();

            // invoke the operation
            string trackName = "text1";
            MediaAssetTrackResource result = await collection.GetAsync(trackName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaAssetTrackData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetATrackByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/asset-tracks-get-by-name.json
            // this example is just showing the usage of "Tracks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaAssetResource created on azure
            // for more information of creating MediaAssetResource, please refer to the document of MediaAssetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string assetName = "ClimbingMountRainer";
            ResourceIdentifier mediaAssetResourceId = MediaAssetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, assetName);
            MediaAssetResource mediaAsset = client.GetMediaAssetResource(mediaAssetResourceId);

            // get the collection of this MediaAssetTrackResource
            MediaAssetTrackCollection collection = mediaAsset.GetMediaAssetTracks();

            // invoke the operation
            string trackName = "text1";
            bool result = await collection.ExistsAsync(trackName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetATrackByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/asset-tracks-get-by-name.json
            // this example is just showing the usage of "Tracks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaAssetResource created on azure
            // for more information of creating MediaAssetResource, please refer to the document of MediaAssetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string assetName = "ClimbingMountRainer";
            ResourceIdentifier mediaAssetResourceId = MediaAssetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, assetName);
            MediaAssetResource mediaAsset = client.GetMediaAssetResource(mediaAssetResourceId);

            // get the collection of this MediaAssetTrackResource
            MediaAssetTrackCollection collection = mediaAsset.GetMediaAssetTracks();

            // invoke the operation
            string trackName = "text1";
            NullableResponse<MediaAssetTrackResource> response = await collection.GetIfExistsAsync(trackName);
            MediaAssetTrackResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaAssetTrackData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesATrack()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/asset-tracks-create.json
            // this example is just showing the usage of "Tracks_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaAssetResource created on azure
            // for more information of creating MediaAssetResource, please refer to the document of MediaAssetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string assetName = "ClimbingMountRainer";
            ResourceIdentifier mediaAssetResourceId = MediaAssetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, assetName);
            MediaAssetResource mediaAsset = client.GetMediaAssetResource(mediaAssetResourceId);

            // get the collection of this MediaAssetTrackResource
            MediaAssetTrackCollection collection = mediaAsset.GetMediaAssetTracks();

            // invoke the operation
            string trackName = "text3";
            MediaAssetTrackData data = new MediaAssetTrackData()
            {
                Track = new TextTrack()
                {
                    FileName = "text3.ttml",
                    DisplayName = "A new track",
                    PlayerVisibility = PlayerVisibility.Visible,
                },
            };
            ArmOperation<MediaAssetTrackResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, trackName, data);
            MediaAssetTrackResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaAssetTrackData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
