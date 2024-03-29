// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Header.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protocol {

  /// <summary>Holder for reflection information generated from Header.proto</summary>
  public static partial class HeaderReflection {

    #region Descriptor
    /// <summary>File descriptor for Header.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeaderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxIZWFkZXIucHJvdG8SCHByb3RvY29sGg1wcm90b0lELnByb3RvIj4KBkhl",
            "YWRlchIiCgdwcm90b0lEGAEgASgOMhEucHJvdG9jb2wuUHJvdG9JRBIQCghw",
            "bGF5ZXJJRBgCIAEoBGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Protocol.ProtoIDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.Header), global::Protocol.Header.Parser, new[]{ "ProtoID", "PlayerID" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Header : pb::IMessage<Header> {
    private static readonly pb::MessageParser<Header> _parser = new pb::MessageParser<Header>(() => new Header());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Header> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protocol.HeaderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Header() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Header(Header other) : this() {
      protoID_ = other.protoID_;
      playerID_ = other.playerID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Header Clone() {
      return new Header(this);
    }

    /// <summary>Field number for the "protoID" field.</summary>
    public const int ProtoIDFieldNumber = 1;
    private global::Protocol.ProtoID protoID_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Protocol.ProtoID ProtoID {
      get { return protoID_; }
      set {
        protoID_ = value;
      }
    }

    /// <summary>Field number for the "playerID" field.</summary>
    public const int PlayerIDFieldNumber = 2;
    private ulong playerID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong PlayerID {
      get { return playerID_; }
      set {
        playerID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Header);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Header other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProtoID != other.ProtoID) return false;
      if (PlayerID != other.PlayerID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProtoID != 0) hash ^= ProtoID.GetHashCode();
      if (PlayerID != 0UL) hash ^= PlayerID.GetHashCode();
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
      if (ProtoID != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ProtoID);
      }
      if (PlayerID != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(PlayerID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProtoID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ProtoID);
      }
      if (PlayerID != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PlayerID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Header other) {
      if (other == null) {
        return;
      }
      if (other.ProtoID != 0) {
        ProtoID = other.ProtoID;
      }
      if (other.PlayerID != 0UL) {
        PlayerID = other.PlayerID;
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
          case 8: {
            ProtoID = (global::Protocol.ProtoID) input.ReadEnum();
            break;
          }
          case 16: {
            PlayerID = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
