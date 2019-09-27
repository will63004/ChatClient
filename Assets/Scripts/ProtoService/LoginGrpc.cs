// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Login.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Protocol {
  public static partial class echoLogin
  {
    static readonly string __ServiceName = "protocol.echoLogin";

    static readonly grpc::Marshaller<global::Protocol.LoginReq> __Marshaller_protocol_LoginReq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Protocol.LoginReq.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Protocol.LoginAck> __Marshaller_protocol_LoginAck = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Protocol.LoginAck.Parser.ParseFrom);

    static readonly grpc::Method<global::Protocol.LoginReq, global::Protocol.LoginAck> __Method_Login = new grpc::Method<global::Protocol.LoginReq, global::Protocol.LoginAck>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Login",
        __Marshaller_protocol_LoginReq,
        __Marshaller_protocol_LoginAck);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Protocol.LoginReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of echoLogin</summary>
    [grpc::BindServiceMethod(typeof(echoLogin), "BindService")]
    public abstract partial class echoLoginBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Protocol.LoginAck> Login(global::Protocol.LoginReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for echoLogin</summary>
    public partial class echoLoginClient : grpc::ClientBase<echoLoginClient>
    {
      /// <summary>Creates a new client for echoLogin</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public echoLoginClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for echoLogin that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public echoLoginClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected echoLoginClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected echoLoginClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Protocol.LoginAck Login(global::Protocol.LoginReq request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Login(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Protocol.LoginAck Login(global::Protocol.LoginReq request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Login, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Protocol.LoginAck> LoginAsync(global::Protocol.LoginReq request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LoginAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Protocol.LoginAck> LoginAsync(global::Protocol.LoginReq request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Login, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override echoLoginClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new echoLoginClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(echoLoginBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Login, serviceImpl.Login).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, echoLoginBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Login, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Protocol.LoginReq, global::Protocol.LoginAck>(serviceImpl.Login));
    }

  }
}
#endregion
