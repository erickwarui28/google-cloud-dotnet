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

namespace Google.Cloud.RecommendationEngine.V1Beta1.Snippets
{
    // [START recommendationengine_v1beta1_generated_UserEventService_WriteUserEvent_async_flattened]
    using Google.Cloud.RecommendationEngine.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedUserEventServiceClientSnippets
    {
        /// <summary>Snippet for WriteUserEventAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task WriteUserEventAsync()
        {
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            UserEvent userEvent = new UserEvent();
            // Make the request
            UserEvent response = await userEventServiceClient.WriteUserEventAsync(parent, userEvent);
        }
    }
    // [END recommendationengine_v1beta1_generated_UserEventService_WriteUserEvent_async_flattened]
}