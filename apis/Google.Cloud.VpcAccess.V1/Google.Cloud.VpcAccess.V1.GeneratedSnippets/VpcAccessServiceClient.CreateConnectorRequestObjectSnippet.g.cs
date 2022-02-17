// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.VpcAccess.V1.Snippets
{
    // [START vpcaccess_v1_generated_VpcAccessService_CreateConnector_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.VpcAccess.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedVpcAccessServiceClientSnippets
    {
        /// <summary>Snippet for CreateConnector</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateConnectorRequestObject()
        {
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = VpcAccessServiceClient.Create();
            // Initialize request argument(s)
            CreateConnectorRequest request = new CreateConnectorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectorId = "",
                Connector = new Connector(),
            };
            // Make the request
            Operation<Connector, OperationMetadata> response = vpcAccessServiceClient.CreateConnector(request);

            // Poll until the returned long-running operation is complete
            Operation<Connector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connector, OperationMetadata> retrievedResponse = vpcAccessServiceClient.PollOnceCreateConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connector retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END vpcaccess_v1_generated_VpcAccessService_CreateConnector_sync]
}