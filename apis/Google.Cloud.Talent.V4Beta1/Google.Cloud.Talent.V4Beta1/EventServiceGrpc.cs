// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/talent/v4beta1/event_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
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

namespace Google.Cloud.Talent.V4Beta1 {
  /// <summary>
  /// A service handles client event report.
  /// </summary>
  public static partial class EventService
  {
    static readonly string __ServiceName = "google.cloud.talent.v4beta1.EventService";

    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.CreateClientEventRequest> __Marshaller_google_cloud_talent_v4beta1_CreateClientEventRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.CreateClientEventRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.ClientEvent> __Marshaller_google_cloud_talent_v4beta1_ClientEvent = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.ClientEvent.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Talent.V4Beta1.CreateClientEventRequest, global::Google.Cloud.Talent.V4Beta1.ClientEvent> __Method_CreateClientEvent = new grpc::Method<global::Google.Cloud.Talent.V4Beta1.CreateClientEventRequest, global::Google.Cloud.Talent.V4Beta1.ClientEvent>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateClientEvent",
        __Marshaller_google_cloud_talent_v4beta1_CreateClientEventRequest,
        __Marshaller_google_cloud_talent_v4beta1_ClientEvent);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Talent.V4Beta1.EventServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of EventService</summary>
    [grpc::BindServiceMethod(typeof(EventService), "BindService")]
    public abstract partial class EventServiceBase
    {
      /// <summary>
      /// Report events issued when end user interacts with customer's application
      /// that uses Cloud Talent Solution. You may inspect the created events in
      /// [self service
      /// tools](https://console.cloud.google.com/talent-solution/overview).
      /// [Learn
      /// more](https://cloud.google.com/talent-solution/docs/management-tools)
      /// about self service tools.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Talent.V4Beta1.ClientEvent> CreateClientEvent(global::Google.Cloud.Talent.V4Beta1.CreateClientEventRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for EventService</summary>
    public partial class EventServiceClient : grpc::ClientBase<EventServiceClient>
    {
      /// <summary>Creates a new client for EventService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public EventServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for EventService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public EventServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected EventServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected EventServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Report events issued when end user interacts with customer's application
      /// that uses Cloud Talent Solution. You may inspect the created events in
      /// [self service
      /// tools](https://console.cloud.google.com/talent-solution/overview).
      /// [Learn
      /// more](https://cloud.google.com/talent-solution/docs/management-tools)
      /// about self service tools.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.ClientEvent CreateClientEvent(global::Google.Cloud.Talent.V4Beta1.CreateClientEventRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateClientEvent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Report events issued when end user interacts with customer's application
      /// that uses Cloud Talent Solution. You may inspect the created events in
      /// [self service
      /// tools](https://console.cloud.google.com/talent-solution/overview).
      /// [Learn
      /// more](https://cloud.google.com/talent-solution/docs/management-tools)
      /// about self service tools.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.ClientEvent CreateClientEvent(global::Google.Cloud.Talent.V4Beta1.CreateClientEventRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateClientEvent, null, options, request);
      }
      /// <summary>
      /// Report events issued when end user interacts with customer's application
      /// that uses Cloud Talent Solution. You may inspect the created events in
      /// [self service
      /// tools](https://console.cloud.google.com/talent-solution/overview).
      /// [Learn
      /// more](https://cloud.google.com/talent-solution/docs/management-tools)
      /// about self service tools.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.ClientEvent> CreateClientEventAsync(global::Google.Cloud.Talent.V4Beta1.CreateClientEventRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateClientEventAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Report events issued when end user interacts with customer's application
      /// that uses Cloud Talent Solution. You may inspect the created events in
      /// [self service
      /// tools](https://console.cloud.google.com/talent-solution/overview).
      /// [Learn
      /// more](https://cloud.google.com/talent-solution/docs/management-tools)
      /// about self service tools.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.ClientEvent> CreateClientEventAsync(global::Google.Cloud.Talent.V4Beta1.CreateClientEventRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateClientEvent, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override EventServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new EventServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(EventServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateClientEvent, serviceImpl.CreateClientEvent).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EventServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateClientEvent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Talent.V4Beta1.CreateClientEventRequest, global::Google.Cloud.Talent.V4Beta1.ClientEvent>(serviceImpl.CreateClientEvent));
    }

  }
}
#endregion