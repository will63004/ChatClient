// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MessageBroadcast.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protocol {

  /// <summary>Holder for reflection information generated from MessageBroadcast.proto</summary>
  public static partial class MessageBroadcastReflection {

    #region Descriptor
    /// <summary>File descriptor for MessageBroadcast.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageBroadcastReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZNZXNzYWdlQnJvYWRjYXN0LnByb3RvEghwcm90b2NvbBoMaGVhZGVyLnBy",
            "b3RvIkEKEE1lc3NhZ2VCcm9hZGNhc3QSIAoGaGVhZGVyGAEgASgLMhAucHJv",
            "dG9jb2wuSGVhZGVyEgsKA21zZxgCIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Protocol.HeaderReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.MessageBroadcast), global::Protocol.MessageBroadcast.Parser, new[]{ "Header", "Msg" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MessageBroadcast : pb::IMessage<MessageBroadcast> {
    private static readonly pb::MessageParser<MessageBroadcast> _parser = new pb::MessageParser<MessageBroadcast>(() => new MessageBroadcast());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MessageBroadcast> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protocol.MessageBroadcastReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageBroadcast() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageBroadcast(MessageBroadcast other) : this() {
      header_ = other.header_ != null ? other.header_.Clone() : null;
      msg_ = other.msg_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageBroadcast Clone() {
      return new MessageBroadcast(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Protocol.Header header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Protocol.Header Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "msg" field.</summary>
    public const int MsgFieldNumber = 2;
    private string msg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Msg {
      get { return msg_; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MessageBroadcast);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MessageBroadcast other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if (Msg != other.Msg) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      if (Msg.Length != 0) hash ^= Msg.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (Msg.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Msg);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (Msg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MessageBroadcast other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          Header = new global::Protocol.Header();
        }
        Header.MergeFrom(other.Header);
      }
      if (other.Msg.Length != 0) {
        Msg = other.Msg;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (header_ == null) {
              Header = new global::Protocol.Header();
            }
            input.ReadMessage(Header);
            break;
          }
          case 18: {
            Msg = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code