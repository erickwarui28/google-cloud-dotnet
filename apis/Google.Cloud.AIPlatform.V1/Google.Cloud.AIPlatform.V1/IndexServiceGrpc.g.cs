// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/index_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.AIPlatform.V1 {
  /// <summary>
  /// A service for creating and managing Vertex AI's Index resources.
  /// </summary>
  public static partial class IndexService
  {
    static readonly string __ServiceName = "google.cloud.aiplatform.v1.IndexService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.CreateIndexRequest> __Marshaller_google_cloud_aiplatform_v1_CreateIndexRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.CreateIndexRequest.Parser));
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.GetIndexRequest> __Marshaller_google_cloud_aiplatform_v1_GetIndexRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.GetIndexRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.Index> __Marshaller_google_cloud_aiplatform_v1_Index = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.Index.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.ListIndexesRequest> __Marshaller_google_cloud_aiplatform_v1_ListIndexesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.ListIndexesRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.ListIndexesResponse> __Marshaller_google_cloud_aiplatform_v1_ListIndexesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.ListIndexesResponse.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.UpdateIndexRequest> __Marshaller_google_cloud_aiplatform_v1_UpdateIndexRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.UpdateIndexRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.DeleteIndexRequest> __Marshaller_google_cloud_aiplatform_v1_DeleteIndexRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.DeleteIndexRequest.Parser));

    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1.CreateIndexRequest, global::Google.LongRunning.Operation> __Method_CreateIndex = new grpc::Method<global::Google.Cloud.AIPlatform.V1.CreateIndexRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateIndex",
        __Marshaller_google_cloud_aiplatform_v1_CreateIndexRequest,
        __Marshaller_google_longrunning_Operation);

    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1.GetIndexRequest, global::Google.Cloud.AIPlatform.V1.Index> __Method_GetIndex = new grpc::Method<global::Google.Cloud.AIPlatform.V1.GetIndexRequest, global::Google.Cloud.AIPlatform.V1.Index>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetIndex",
        __Marshaller_google_cloud_aiplatform_v1_GetIndexRequest,
        __Marshaller_google_cloud_aiplatform_v1_Index);

    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1.ListIndexesRequest, global::Google.Cloud.AIPlatform.V1.ListIndexesResponse> __Method_ListIndexes = new grpc::Method<global::Google.Cloud.AIPlatform.V1.ListIndexesRequest, global::Google.Cloud.AIPlatform.V1.ListIndexesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListIndexes",
        __Marshaller_google_cloud_aiplatform_v1_ListIndexesRequest,
        __Marshaller_google_cloud_aiplatform_v1_ListIndexesResponse);

    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1.UpdateIndexRequest, global::Google.LongRunning.Operation> __Method_UpdateIndex = new grpc::Method<global::Google.Cloud.AIPlatform.V1.UpdateIndexRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateIndex",
        __Marshaller_google_cloud_aiplatform_v1_UpdateIndexRequest,
        __Marshaller_google_longrunning_Operation);

    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1.DeleteIndexRequest, global::Google.LongRunning.Operation> __Method_DeleteIndex = new grpc::Method<global::Google.Cloud.AIPlatform.V1.DeleteIndexRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteIndex",
        __Marshaller_google_cloud_aiplatform_v1_DeleteIndexRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.AIPlatform.V1.IndexServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of IndexService</summary>
    [grpc::BindServiceMethod(typeof(IndexService), "BindService")]
    public abstract partial class IndexServiceBase
    {
      /// <summary>
      /// Creates an Index.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> CreateIndex(global::Google.Cloud.AIPlatform.V1.CreateIndexRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets an Index.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.AIPlatform.V1.Index> GetIndex(global::Google.Cloud.AIPlatform.V1.GetIndexRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists Indexes in a Location.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.AIPlatform.V1.ListIndexesResponse> ListIndexes(global::Google.Cloud.AIPlatform.V1.ListIndexesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates an Index.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> UpdateIndex(global::Google.Cloud.AIPlatform.V1.UpdateIndexRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes an Index.
      /// An Index can only be deleted when all its
      /// [DeployedIndexes][google.cloud.aiplatform.v1.Index.deployed_indexes] had been undeployed.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> DeleteIndex(global::Google.Cloud.AIPlatform.V1.DeleteIndexRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for IndexService</summary>
    public partial class IndexServiceClient : grpc::ClientBase<IndexServiceClient>
    {
      /// <summary>Creates a new client for IndexService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public IndexServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for IndexService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public IndexServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected IndexServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected IndexServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates an Index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation CreateIndex(global::Google.Cloud.AIPlatform.V1.CreateIndexRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateIndex(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates an Index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation CreateIndex(global::Google.Cloud.AIPlatform.V1.CreateIndexRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateIndex, null, options, request);
      }
      /// <summary>
      /// Creates an Index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateIndexAsync(global::Google.Cloud.AIPlatform.V1.CreateIndexRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateIndexAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates an Index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateIndexAsync(global::Google.Cloud.AIPlatform.V1.CreateIndexRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateIndex, null, options, request);
      }
      /// <summary>
      /// Gets an Index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.AIPlatform.V1.Index GetIndex(global::Google.Cloud.AIPlatform.V1.GetIndexRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetIndex(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets an Index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.AIPlatform.V1.Index GetIndex(global::Google.Cloud.AIPlatform.V1.GetIndexRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetIndex, null, options, request);
      }
      /// <summary>
      /// Gets an Index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1.Index> GetIndexAsync(global::Google.Cloud.AIPlatform.V1.GetIndexRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetIndexAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets an Index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1.Index> GetIndexAsync(global::Google.Cloud.AIPlatform.V1.GetIndexRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetIndex, null, options, request);
      }
      /// <summary>
      /// Lists Indexes in a Location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.AIPlatform.V1.ListIndexesResponse ListIndexes(global::Google.Cloud.AIPlatform.V1.ListIndexesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListIndexes(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists Indexes in a Location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.AIPlatform.V1.ListIndexesResponse ListIndexes(global::Google.Cloud.AIPlatform.V1.ListIndexesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListIndexes, null, options, request);
      }
      /// <summary>
      /// Lists Indexes in a Location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1.ListIndexesResponse> ListIndexesAsync(global::Google.Cloud.AIPlatform.V1.ListIndexesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListIndexesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists Indexes in a Location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1.ListIndexesResponse> ListIndexesAsync(global::Google.Cloud.AIPlatform.V1.ListIndexesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListIndexes, null, options, request);
      }
      /// <summary>
      /// Updates an Index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation UpdateIndex(global::Google.Cloud.AIPlatform.V1.UpdateIndexRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateIndex(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates an Index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation UpdateIndex(global::Google.Cloud.AIPlatform.V1.UpdateIndexRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateIndex, null, options, request);
      }
      /// <summary>
      /// Updates an Index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> UpdateIndexAsync(global::Google.Cloud.AIPlatform.V1.UpdateIndexRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateIndexAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates an Index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> UpdateIndexAsync(global::Google.Cloud.AIPlatform.V1.UpdateIndexRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateIndex, null, options, request);
      }
      /// <summary>
      /// Deletes an Index.
      /// An Index can only be deleted when all its
      /// [DeployedIndexes][google.cloud.aiplatform.v1.Index.deployed_indexes] had been undeployed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation DeleteIndex(global::Google.Cloud.AIPlatform.V1.DeleteIndexRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteIndex(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes an Index.
      /// An Index can only be deleted when all its
      /// [DeployedIndexes][google.cloud.aiplatform.v1.Index.deployed_indexes] had been undeployed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation DeleteIndex(global::Google.Cloud.AIPlatform.V1.DeleteIndexRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteIndex, null, options, request);
      }
      /// <summary>
      /// Deletes an Index.
      /// An Index can only be deleted when all its
      /// [DeployedIndexes][google.cloud.aiplatform.v1.Index.deployed_indexes] had been undeployed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteIndexAsync(global::Google.Cloud.AIPlatform.V1.DeleteIndexRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteIndexAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes an Index.
      /// An Index can only be deleted when all its
      /// [DeployedIndexes][google.cloud.aiplatform.v1.Index.deployed_indexes] had been undeployed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteIndexAsync(global::Google.Cloud.AIPlatform.V1.DeleteIndexRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteIndex, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override IndexServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new IndexServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(IndexServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateIndex, serviceImpl.CreateIndex)
          .AddMethod(__Method_GetIndex, serviceImpl.GetIndex)
          .AddMethod(__Method_ListIndexes, serviceImpl.ListIndexes)
          .AddMethod(__Method_UpdateIndex, serviceImpl.UpdateIndex)
          .AddMethod(__Method_DeleteIndex, serviceImpl.DeleteIndex).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, IndexServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateIndex, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AIPlatform.V1.CreateIndexRequest, global::Google.LongRunning.Operation>(serviceImpl.CreateIndex));
      serviceBinder.AddMethod(__Method_GetIndex, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AIPlatform.V1.GetIndexRequest, global::Google.Cloud.AIPlatform.V1.Index>(serviceImpl.GetIndex));
      serviceBinder.AddMethod(__Method_ListIndexes, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AIPlatform.V1.ListIndexesRequest, global::Google.Cloud.AIPlatform.V1.ListIndexesResponse>(serviceImpl.ListIndexes));
      serviceBinder.AddMethod(__Method_UpdateIndex, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AIPlatform.V1.UpdateIndexRequest, global::Google.LongRunning.Operation>(serviceImpl.UpdateIndex));
      serviceBinder.AddMethod(__Method_DeleteIndex, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AIPlatform.V1.DeleteIndexRequest, global::Google.LongRunning.Operation>(serviceImpl.DeleteIndex));
    }

  }
}
#endregion