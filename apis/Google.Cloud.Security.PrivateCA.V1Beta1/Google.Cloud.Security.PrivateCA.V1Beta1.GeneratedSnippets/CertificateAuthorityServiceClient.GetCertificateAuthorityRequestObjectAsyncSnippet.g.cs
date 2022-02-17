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

namespace Google.Cloud.Security.PrivateCA.V1Beta1.Snippets
{
    // [START privateca_v1beta1_generated_CertificateAuthorityService_GetCertificateAuthority_async]
    using Google.Cloud.Security.PrivateCA.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCertificateAuthorityServiceClientSnippets
    {
        /// <summary>Snippet for GetCertificateAuthorityAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetCertificateAuthorityRequestObjectAsync()
        {
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            // Make the request
            CertificateAuthority response = await certificateAuthorityServiceClient.GetCertificateAuthorityAsync(request);
        }
    }
    // [END privateca_v1beta1_generated_CertificateAuthorityService_GetCertificateAuthority_async]
}