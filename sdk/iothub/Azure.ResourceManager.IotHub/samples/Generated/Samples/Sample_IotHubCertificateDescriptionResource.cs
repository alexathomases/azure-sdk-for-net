// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.IotHub.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.IotHub.Samples
{
    public partial class Sample_IotHubCertificateDescriptionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CertificatesGet()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_getcertificate.json
            // this example is just showing the usage of "Certificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubCertificateDescriptionResource created on azure
            // for more information of creating IotHubCertificateDescriptionResource, please refer to the document of IotHubCertificateDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testhub";
            string certificateName = "cert";
            ResourceIdentifier iotHubCertificateDescriptionResourceId = IotHubCertificateDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, certificateName);
            IotHubCertificateDescriptionResource iotHubCertificateDescription = client.GetIotHubCertificateDescriptionResource(iotHubCertificateDescriptionResourceId);

            // invoke the operation
            IotHubCertificateDescriptionResource result = await iotHubCertificateDescription.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotHubCertificateDescriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CertificatesCreateOrUpdate()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_certificatescreateorupdate.json
            // this example is just showing the usage of "Certificates_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubCertificateDescriptionResource created on azure
            // for more information of creating IotHubCertificateDescriptionResource, please refer to the document of IotHubCertificateDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "iothub";
            string certificateName = "cert";
            ResourceIdentifier iotHubCertificateDescriptionResourceId = IotHubCertificateDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, certificateName);
            IotHubCertificateDescriptionResource iotHubCertificateDescription = client.GetIotHubCertificateDescriptionResource(iotHubCertificateDescriptionResourceId);

            // invoke the operation
            IotHubCertificateDescriptionData data = new IotHubCertificateDescriptionData()
            {
                Properties = new IotHubCertificateProperties()
                {
                    Certificate = BinaryData.FromString("\"############################################\""),
                },
            };
            ArmOperation<IotHubCertificateDescriptionResource> lro = await iotHubCertificateDescription.UpdateAsync(WaitUntil.Completed, data);
            IotHubCertificateDescriptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotHubCertificateDescriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_CertificatesDelete()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_certificatesdelete.json
            // this example is just showing the usage of "Certificates_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubCertificateDescriptionResource created on azure
            // for more information of creating IotHubCertificateDescriptionResource, please refer to the document of IotHubCertificateDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "myhub";
            string certificateName = "cert";
            ResourceIdentifier iotHubCertificateDescriptionResourceId = IotHubCertificateDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, certificateName);
            IotHubCertificateDescriptionResource iotHubCertificateDescription = client.GetIotHubCertificateDescriptionResource(iotHubCertificateDescriptionResourceId);

            // invoke the operation
            string ifMatch = "AAAAAAAADGk=";
            await iotHubCertificateDescription.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GenerateVerificationCode_CertificatesGenerateVerificationCode()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_generateverificationcode.json
            // this example is just showing the usage of "Certificates_GenerateVerificationCode" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubCertificateDescriptionResource created on azure
            // for more information of creating IotHubCertificateDescriptionResource, please refer to the document of IotHubCertificateDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testHub";
            string certificateName = "cert";
            ResourceIdentifier iotHubCertificateDescriptionResourceId = IotHubCertificateDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, certificateName);
            IotHubCertificateDescriptionResource iotHubCertificateDescription = client.GetIotHubCertificateDescriptionResource(iotHubCertificateDescriptionResourceId);

            // invoke the operation
            string ifMatch = "AAAAAAAADGk=";
            IotHubCertificateWithNonceDescription result = await iotHubCertificateDescription.GenerateVerificationCodeAsync(ifMatch);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Verify_CertificatesVerify()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_certverify.json
            // this example is just showing the usage of "Certificates_Verify" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubCertificateDescriptionResource created on azure
            // for more information of creating IotHubCertificateDescriptionResource, please refer to the document of IotHubCertificateDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "myFirstProvisioningService";
            string certificateName = "cert";
            ResourceIdentifier iotHubCertificateDescriptionResourceId = IotHubCertificateDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, certificateName);
            IotHubCertificateDescriptionResource iotHubCertificateDescription = client.GetIotHubCertificateDescriptionResource(iotHubCertificateDescriptionResourceId);

            // invoke the operation
            string ifMatch = "AAAAAAAADGk=";
            IotHubCertificateVerificationContent content = new IotHubCertificateVerificationContent()
            {
                Certificate = BinaryData.FromString("\"#####################################\""),
            };
            IotHubCertificateDescriptionResource result = await iotHubCertificateDescription.VerifyAsync(ifMatch, content);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotHubCertificateDescriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
