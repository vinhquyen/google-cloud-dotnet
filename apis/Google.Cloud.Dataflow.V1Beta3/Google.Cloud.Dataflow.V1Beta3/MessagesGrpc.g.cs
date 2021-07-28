// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/dataflow/v1beta3/messages.proto
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

namespace Google.Cloud.Dataflow.V1Beta3 {
  /// <summary>
  /// The Dataflow Messages API is used for monitoring the progress of
  /// Dataflow jobs.
  /// </summary>
  public static partial class MessagesV1Beta3
  {
    static readonly string __ServiceName = "google.dataflow.v1beta3.MessagesV1Beta3";

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

    static readonly grpc::Marshaller<global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesRequest> __Marshaller_google_dataflow_v1beta3_ListJobMessagesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesResponse> __Marshaller_google_dataflow_v1beta3_ListJobMessagesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesResponse.Parser));

    static readonly grpc::Method<global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesRequest, global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesResponse> __Method_ListJobMessages = new grpc::Method<global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesRequest, global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListJobMessages",
        __Marshaller_google_dataflow_v1beta3_ListJobMessagesRequest,
        __Marshaller_google_dataflow_v1beta3_ListJobMessagesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dataflow.V1Beta3.MessagesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MessagesV1Beta3</summary>
    [grpc::BindServiceMethod(typeof(MessagesV1Beta3), "BindService")]
    public abstract partial class MessagesV1Beta3Base
    {
      /// <summary>
      /// Request the job status.
      ///
      /// To request the status of a job, we recommend using
      /// `projects.locations.jobs.messages.list` with a [regional endpoint]
      /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
      /// `projects.jobs.messages.list` is not recommended, as you can only request
      /// the status of jobs that are running in `us-central1`.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesResponse> ListJobMessages(global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MessagesV1Beta3</summary>
    public partial class MessagesV1Beta3Client : grpc::ClientBase<MessagesV1Beta3Client>
    {
      /// <summary>Creates a new client for MessagesV1Beta3</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MessagesV1Beta3Client(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MessagesV1Beta3 that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MessagesV1Beta3Client(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MessagesV1Beta3Client() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MessagesV1Beta3Client(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Request the job status.
      ///
      /// To request the status of a job, we recommend using
      /// `projects.locations.jobs.messages.list` with a [regional endpoint]
      /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
      /// `projects.jobs.messages.list` is not recommended, as you can only request
      /// the status of jobs that are running in `us-central1`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesResponse ListJobMessages(global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListJobMessages(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Request the job status.
      ///
      /// To request the status of a job, we recommend using
      /// `projects.locations.jobs.messages.list` with a [regional endpoint]
      /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
      /// `projects.jobs.messages.list` is not recommended, as you can only request
      /// the status of jobs that are running in `us-central1`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesResponse ListJobMessages(global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListJobMessages, null, options, request);
      }
      /// <summary>
      /// Request the job status.
      ///
      /// To request the status of a job, we recommend using
      /// `projects.locations.jobs.messages.list` with a [regional endpoint]
      /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
      /// `projects.jobs.messages.list` is not recommended, as you can only request
      /// the status of jobs that are running in `us-central1`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesResponse> ListJobMessagesAsync(global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListJobMessagesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Request the job status.
      ///
      /// To request the status of a job, we recommend using
      /// `projects.locations.jobs.messages.list` with a [regional endpoint]
      /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
      /// `projects.jobs.messages.list` is not recommended, as you can only request
      /// the status of jobs that are running in `us-central1`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesResponse> ListJobMessagesAsync(global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListJobMessages, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MessagesV1Beta3Client NewInstance(ClientBaseConfiguration configuration)
      {
        return new MessagesV1Beta3Client(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MessagesV1Beta3Base serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListJobMessages, serviceImpl.ListJobMessages).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MessagesV1Beta3Base serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListJobMessages, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesRequest, global::Google.Cloud.Dataflow.V1Beta3.ListJobMessagesResponse>(serviceImpl.ListJobMessages));
    }

  }
}
#endregion