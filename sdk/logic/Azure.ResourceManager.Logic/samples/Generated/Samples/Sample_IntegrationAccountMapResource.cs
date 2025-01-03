// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Logic.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Logic.Samples
{
    public partial class Sample_IntegrationAccountMapResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetMapByName()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountMaps_Get.json
            // this example is just showing the usage of "IntegrationAccountMaps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountMapResource created on azure
            // for more information of creating IntegrationAccountMapResource, please refer to the document of IntegrationAccountMapResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            string mapName = "testMap";
            ResourceIdentifier integrationAccountMapResourceId = IntegrationAccountMapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName, mapName);
            IntegrationAccountMapResource integrationAccountMap = client.GetIntegrationAccountMapResource(integrationAccountMapResourceId);

            // invoke the operation
            IntegrationAccountMapResource result = await integrationAccountMap.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountMapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAMap()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountMaps_Delete.json
            // this example is just showing the usage of "IntegrationAccountMaps_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountMapResource created on azure
            // for more information of creating IntegrationAccountMapResource, please refer to the document of IntegrationAccountMapResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            string mapName = "testMap";
            ResourceIdentifier integrationAccountMapResourceId = IntegrationAccountMapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName, mapName);
            IntegrationAccountMapResource integrationAccountMap = client.GetIntegrationAccountMapResource(integrationAccountMapResourceId);

            // invoke the operation
            await integrationAccountMap.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateAMap()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountMaps_CreateOrUpdate.json
            // this example is just showing the usage of "IntegrationAccountMaps_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountMapResource created on azure
            // for more information of creating IntegrationAccountMapResource, please refer to the document of IntegrationAccountMapResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            string mapName = "testMap";
            ResourceIdentifier integrationAccountMapResourceId = IntegrationAccountMapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName, mapName);
            IntegrationAccountMapResource integrationAccountMap = client.GetIntegrationAccountMapResource(integrationAccountMapResourceId);

            // invoke the operation
            IntegrationAccountMapData data = new IntegrationAccountMapData(new AzureLocation("westus"), IntegrationAccountMapType.Xslt)
            {
                Content = BinaryData.FromObjectAsJson("<?xml version=\"1.0\" encoding=\"UTF-16\"?>\r\n<xsl:stylesheet xmlns:xsl=\"http://www.w3.org/1999/XSL/Transform\" xmlns:msxsl=\"urn:schemas-microsoft-com:xslt\" xmlns:var=\"http://schemas.microsoft.com/BizTalk/2003/var\" exclude-result-prefixes=\"msxsl var s0 userCSharp\" version=\"1.0\" xmlns:ns0=\"http://BizTalk_Server_Project4.StringFunctoidsDestinationSchema\" xmlns:s0=\"http://BizTalk_Server_Project4.StringFunctoidsSourceSchema\" xmlns:userCSharp=\"http://schemas.microsoft.com/BizTalk/2003/userCSharp\">\r\n  <xsl:import href=\"http://btsfunctoids.blob.core.windows.net/functoids/functoids.xslt\" />\r\n  <xsl:output omit-xml-declaration=\"yes\" method=\"xml\" version=\"1.0\" />\r\n  <xsl:template match=\"/\">\r\n    <xsl:apply-templates select=\"/s0:Root\" />\r\n  </xsl:template>\r\n  <xsl:template match=\"/s0:Root\">\r\n    <xsl:variable name=\"var:v1\" select=\"userCSharp:StringFind(string(StringFindSource/text()) , &quot;SearchString&quot;)\" />\r\n    <xsl:variable name=\"var:v2\" select=\"userCSharp:StringLeft(string(StringLeftSource/text()) , &quot;2&quot;)\" />\r\n    <xsl:variable name=\"var:v3\" select=\"userCSharp:StringRight(string(StringRightSource/text()) , &quot;2&quot;)\" />\r\n    <xsl:variable name=\"var:v4\" select=\"userCSharp:StringUpperCase(string(UppercaseSource/text()))\" />\r\n    <xsl:variable name=\"var:v5\" select=\"userCSharp:StringLowerCase(string(LowercaseSource/text()))\" />\r\n    <xsl:variable name=\"var:v6\" select=\"userCSharp:StringSize(string(SizeSource/text()))\" />\r\n    <xsl:variable name=\"var:v7\" select=\"userCSharp:StringSubstring(string(StringExtractSource/text()) , &quot;0&quot; , &quot;2&quot;)\" />\r\n    <xsl:variable name=\"var:v8\" select=\"userCSharp:StringConcat(string(StringConcatSource/text()))\" />\r\n    <xsl:variable name=\"var:v9\" select=\"userCSharp:StringTrimLeft(string(StringLeftTrimSource/text()))\" />\r\n    <xsl:variable name=\"var:v10\" select=\"userCSharp:StringTrimRight(string(StringRightTrimSource/text()))\" />\r\n    <ns0:Root>\r\n      <StringFindDestination>\r\n        <xsl:value-of select=\"$var:v1\" />\r\n      </StringFindDestination>\r\n      <StringLeftDestination>\r\n        <xsl:value-of select=\"$var:v2\" />\r\n      </StringLeftDestination>\r\n      <StringRightDestination>\r\n        <xsl:value-of select=\"$var:v3\" />\r\n      </StringRightDestination>\r\n      <UppercaseDestination>\r\n        <xsl:value-of select=\"$var:v4\" />\r\n      </UppercaseDestination>\r\n      <LowercaseDestination>\r\n        <xsl:value-of select=\"$var:v5\" />\r\n      </LowercaseDestination>\r\n      <SizeDestination>\r\n        <xsl:value-of select=\"$var:v6\" />\r\n      </SizeDestination>\r\n      <StringExtractDestination>\r\n        <xsl:value-of select=\"$var:v7\" />\r\n      </StringExtractDestination>\r\n      <StringConcatDestination>\r\n        <xsl:value-of select=\"$var:v8\" />\r\n      </StringConcatDestination>\r\n      <StringLeftTrimDestination>\r\n        <xsl:value-of select=\"$var:v9\" />\r\n      </StringLeftTrimDestination>\r\n      <StringRightTrimDestination>\r\n        <xsl:value-of select=\"$var:v10\" />\r\n      </StringRightTrimDestination>\r\n    </ns0:Root>\r\n  </xsl:template>\r\n</xsl:stylesheet>"),
                ContentType = new ContentType("application/xml"),
                Metadata = BinaryData.FromObjectAsJson(new object()),
            };
            ArmOperation<IntegrationAccountMapResource> lro = await integrationAccountMap.UpdateAsync(WaitUntil.Completed, data);
            IntegrationAccountMapResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountMapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateAMapLargerThan4MB()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountLargeMaps_CreateOrUpdate.json
            // this example is just showing the usage of "IntegrationAccountMaps_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountMapResource created on azure
            // for more information of creating IntegrationAccountMapResource, please refer to the document of IntegrationAccountMapResource
            string subscriptionId = "<Azure-subscription-ID>";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            string mapName = "testMap";
            ResourceIdentifier integrationAccountMapResourceId = IntegrationAccountMapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName, mapName);
            IntegrationAccountMapResource integrationAccountMap = client.GetIntegrationAccountMapResource(integrationAccountMapResourceId);

            // invoke the operation
            IntegrationAccountMapData data = new IntegrationAccountMapData(new AzureLocation("westus"), IntegrationAccountMapType.Xslt)
            {
                ContentType = new ContentType("application/xml"),
                Metadata = BinaryData.FromObjectAsJson(new object()),
            };
            ArmOperation<IntegrationAccountMapResource> lro = await integrationAccountMap.UpdateAsync(WaitUntil.Completed, data);
            IntegrationAccountMapResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountMapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetContentCallbackUrl_GetTheContentCallbackUrl()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountMaps_ListContentCallbackUrl.json
            // this example is just showing the usage of "IntegrationAccountMaps_ListContentCallbackUrl" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountMapResource created on azure
            // for more information of creating IntegrationAccountMapResource, please refer to the document of IntegrationAccountMapResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            string mapName = "testMap";
            ResourceIdentifier integrationAccountMapResourceId = IntegrationAccountMapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName, mapName);
            IntegrationAccountMapResource integrationAccountMap = client.GetIntegrationAccountMapResource(integrationAccountMapResourceId);

            // invoke the operation
            ListOperationCallbackUrlParameterInfo info = new ListOperationCallbackUrlParameterInfo
            {
                NotAfter = DateTimeOffset.Parse("2018-04-19T16:00:00Z"),
                KeyType = LogicKeyType.Primary,
            };
            LogicWorkflowTriggerCallbackUri result = await integrationAccountMap.GetContentCallbackUrlAsync(info);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
