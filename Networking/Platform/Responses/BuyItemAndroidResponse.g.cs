// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Platform/Responses/BuyItemAndroidResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Platform.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Platform/Responses/BuyItemAndroidResponse.proto</summary>
  public static partial class BuyItemAndroidResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Platform/Responses/BuyItemAndroidResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuyItemAndroidResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVQT0dPUHJvdG9zL05ldHdvcmtpbmcvUGxhdGZvcm0vUmVzcG9uc2VzL0J1",
            "eUl0ZW1BbmRyb2lkUmVzcG9uc2UucHJvdG8SKFBPR09Qcm90b3MuTmV0d29y",
            "a2luZy5QbGF0Zm9ybS5SZXNwb25zZXMirQEKFkJ1eUl0ZW1BbmRyb2lkUmVz",
            "cG9uc2USVwoGcmVzdWx0GAEgASgOMkcuUE9HT1Byb3Rvcy5OZXR3b3JraW5n",
            "LlBsYXRmb3JtLlJlc3BvbnNlcy5CdXlJdGVtQW5kcm9pZFJlc3BvbnNlLlN0",
            "YXR1cxIWCg5wdXJjaGFzZV90b2tlbhgCIAEoCSIiCgZTdGF0dXMSCwoHVU5L",
            "Tk9XThAAEgsKB1NVQ0NFU1MQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Responses.BuyItemAndroidResponse), global::POGOProtos.Networking.Platform.Responses.BuyItemAndroidResponse.Parser, new[]{ "Result", "PurchaseToken" }, null, new[]{ typeof(global::POGOProtos.Networking.Platform.Responses.BuyItemAndroidResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BuyItemAndroidResponse : pb::IMessage<BuyItemAndroidResponse> {
    private static readonly pb::MessageParser<BuyItemAndroidResponse> _parser = new pb::MessageParser<BuyItemAndroidResponse>(() => new BuyItemAndroidResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BuyItemAndroidResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Platform.Responses.BuyItemAndroidResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuyItemAndroidResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuyItemAndroidResponse(BuyItemAndroidResponse other) : this() {
      result_ = other.result_;
      purchaseToken_ = other.purchaseToken_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuyItemAndroidResponse Clone() {
      return new BuyItemAndroidResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Platform.Responses.BuyItemAndroidResponse.Types.Status result_ = 0;
    /// <summary>
    ///  result
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Platform.Responses.BuyItemAndroidResponse.Types.Status Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "purchase_token" field.</summary>
    public const int PurchaseTokenFieldNumber = 2;
    private string purchaseToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PurchaseToken {
      get { return purchaseToken_; }
      set {
        purchaseToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BuyItemAndroidResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BuyItemAndroidResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (PurchaseToken != other.PurchaseToken) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (PurchaseToken.Length != 0) hash ^= PurchaseToken.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (PurchaseToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PurchaseToken);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (PurchaseToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PurchaseToken);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BuyItemAndroidResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.PurchaseToken.Length != 0) {
        PurchaseToken = other.PurchaseToken;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            result_ = (global::POGOProtos.Networking.Platform.Responses.BuyItemAndroidResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            PurchaseToken = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BuyItemAndroidResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      ///  THESE ARE SOMEWHAT SPECULATED, failed may be 2
      /// </summary>
      public enum Status {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
