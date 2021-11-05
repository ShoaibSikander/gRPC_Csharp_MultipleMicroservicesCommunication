// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/file2.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Server_Py {

  /// <summary>Holder for reflection information generated from Protos/file2.proto</summary>
  public static partial class File2Reflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/file2.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static File2Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90b3MvZmlsZTIucHJvdG8iMQoHQ2FsbFJlcRITCgtjYWxsZXJfbmFt",
            "ZRgBIAEoCRIRCgljYWxsZXJfaWQYAiABKAUiNgoIQ2FsbFJlc3ASFQoNcmVj",
            "ZWl2ZXJfbmFtZRgBIAEoCRITCgtyZWNlaXZlcl9pZBgCIAEoBTItCgdDYWxs",
            "aW5nEiIKC0NhbGxTZXJ2aWNlEgguQ2FsbFJlcRoJLkNhbGxSZXNwQgyqAglT",
            "ZXJ2ZXJfUHliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Server_Py.CallReq), global::Server_Py.CallReq.Parser, new[]{ "CallerName", "CallerId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Server_Py.CallResp), global::Server_Py.CallResp.Parser, new[]{ "ReceiverName", "ReceiverId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CallReq : pb::IMessage<CallReq> {
    private static readonly pb::MessageParser<CallReq> _parser = new pb::MessageParser<CallReq>(() => new CallReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CallReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Server_Py.File2Reflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallReq(CallReq other) : this() {
      callerName_ = other.callerName_;
      callerId_ = other.callerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallReq Clone() {
      return new CallReq(this);
    }

    /// <summary>Field number for the "caller_name" field.</summary>
    public const int CallerNameFieldNumber = 1;
    private string callerName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CallerName {
      get { return callerName_; }
      set {
        callerName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "caller_id" field.</summary>
    public const int CallerIdFieldNumber = 2;
    private int callerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CallerId {
      get { return callerId_; }
      set {
        callerId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CallReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CallReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CallerName != other.CallerName) return false;
      if (CallerId != other.CallerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CallerName.Length != 0) hash ^= CallerName.GetHashCode();
      if (CallerId != 0) hash ^= CallerId.GetHashCode();
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
      if (CallerName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CallerName);
      }
      if (CallerId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(CallerId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CallerName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CallerName);
      }
      if (CallerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CallerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CallReq other) {
      if (other == null) {
        return;
      }
      if (other.CallerName.Length != 0) {
        CallerName = other.CallerName;
      }
      if (other.CallerId != 0) {
        CallerId = other.CallerId;
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
            CallerName = input.ReadString();
            break;
          }
          case 16: {
            CallerId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CallResp : pb::IMessage<CallResp> {
    private static readonly pb::MessageParser<CallResp> _parser = new pb::MessageParser<CallResp>(() => new CallResp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CallResp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Server_Py.File2Reflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallResp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallResp(CallResp other) : this() {
      receiverName_ = other.receiverName_;
      receiverId_ = other.receiverId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallResp Clone() {
      return new CallResp(this);
    }

    /// <summary>Field number for the "receiver_name" field.</summary>
    public const int ReceiverNameFieldNumber = 1;
    private string receiverName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ReceiverName {
      get { return receiverName_; }
      set {
        receiverName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "receiver_id" field.</summary>
    public const int ReceiverIdFieldNumber = 2;
    private int receiverId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ReceiverId {
      get { return receiverId_; }
      set {
        receiverId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CallResp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CallResp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ReceiverName != other.ReceiverName) return false;
      if (ReceiverId != other.ReceiverId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ReceiverName.Length != 0) hash ^= ReceiverName.GetHashCode();
      if (ReceiverId != 0) hash ^= ReceiverId.GetHashCode();
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
      if (ReceiverName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ReceiverName);
      }
      if (ReceiverId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ReceiverId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ReceiverName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReceiverName);
      }
      if (ReceiverId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ReceiverId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CallResp other) {
      if (other == null) {
        return;
      }
      if (other.ReceiverName.Length != 0) {
        ReceiverName = other.ReceiverName;
      }
      if (other.ReceiverId != 0) {
        ReceiverId = other.ReceiverId;
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
            ReceiverName = input.ReadString();
            break;
          }
          case 16: {
            ReceiverId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
