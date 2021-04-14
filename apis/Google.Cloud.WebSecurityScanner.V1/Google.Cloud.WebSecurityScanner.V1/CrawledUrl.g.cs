// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/websecurityscanner/v1/crawled_url.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.WebSecurityScanner.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/websecurityscanner/v1/crawled_url.proto</summary>
  public static partial class CrawledUrlReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/websecurityscanner/v1/crawled_url.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CrawledUrlReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvY2xvdWQvd2Vic2VjdXJpdHlzY2FubmVyL3YxL2NyYXdsZWRf",
            "dXJsLnByb3RvEiJnb29nbGUuY2xvdWQud2Vic2VjdXJpdHlzY2FubmVyLnYx",
            "IjwKCkNyYXdsZWRVcmwSEwoLaHR0cF9tZXRob2QYASABKAkSCwoDdXJsGAIg",
            "ASgJEgwKBGJvZHkYAyABKAlCgwIKJmNvbS5nb29nbGUuY2xvdWQud2Vic2Vj",
            "dXJpdHlzY2FubmVyLnYxQg9DcmF3bGVkVXJsUHJvdG9QAVpUZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC93ZWJzZWN1cml0",
            "eXNjYW5uZXIvdjE7d2Vic2VjdXJpdHlzY2FubmVyqgIiR29vZ2xlLkNsb3Vk",
            "LldlYlNlY3VyaXR5U2Nhbm5lci5WMcoCIkdvb2dsZVxDbG91ZFxXZWJTZWN1",
            "cml0eVNjYW5uZXJcVjHqAiVHb29nbGU6OkNsb3VkOjpXZWJTZWN1cml0eVNj",
            "YW5uZXI6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.WebSecurityScanner.V1.CrawledUrl), global::Google.Cloud.WebSecurityScanner.V1.CrawledUrl.Parser, new[]{ "HttpMethod", "Url", "Body" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A CrawledUrl resource represents a URL that was crawled during a ScanRun. Web
  /// Security Scanner Service crawls the web applications, following all links
  /// within the scope of sites, to find the URLs to test against.
  /// </summary>
  public sealed partial class CrawledUrl : pb::IMessage<CrawledUrl>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CrawledUrl> _parser = new pb::MessageParser<CrawledUrl>(() => new CrawledUrl());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CrawledUrl> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.WebSecurityScanner.V1.CrawledUrlReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CrawledUrl() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CrawledUrl(CrawledUrl other) : this() {
      httpMethod_ = other.httpMethod_;
      url_ = other.url_;
      body_ = other.body_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CrawledUrl Clone() {
      return new CrawledUrl(this);
    }

    /// <summary>Field number for the "http_method" field.</summary>
    public const int HttpMethodFieldNumber = 1;
    private string httpMethod_ = "";
    /// <summary>
    /// Output only. The http method of the request that was used to visit the URL, in
    /// uppercase.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string HttpMethod {
      get { return httpMethod_; }
      set {
        httpMethod_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 2;
    private string url_ = "";
    /// <summary>
    /// Output only. The URL that was crawled.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "body" field.</summary>
    public const int BodyFieldNumber = 3;
    private string body_ = "";
    /// <summary>
    /// Output only. The body of the request that was used to visit the URL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Body {
      get { return body_; }
      set {
        body_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CrawledUrl);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CrawledUrl other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HttpMethod != other.HttpMethod) return false;
      if (Url != other.Url) return false;
      if (Body != other.Body) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HttpMethod.Length != 0) hash ^= HttpMethod.GetHashCode();
      if (Url.Length != 0) hash ^= Url.GetHashCode();
      if (Body.Length != 0) hash ^= Body.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HttpMethod.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(HttpMethod);
      }
      if (Url.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Url);
      }
      if (Body.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Body);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HttpMethod.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(HttpMethod);
      }
      if (Url.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Url);
      }
      if (Body.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Body);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HttpMethod.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HttpMethod);
      }
      if (Url.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      if (Body.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Body);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CrawledUrl other) {
      if (other == null) {
        return;
      }
      if (other.HttpMethod.Length != 0) {
        HttpMethod = other.HttpMethod;
      }
      if (other.Url.Length != 0) {
        Url = other.Url;
      }
      if (other.Body.Length != 0) {
        Body = other.Body;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            HttpMethod = input.ReadString();
            break;
          }
          case 18: {
            Url = input.ReadString();
            break;
          }
          case 26: {
            Body = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            HttpMethod = input.ReadString();
            break;
          }
          case 18: {
            Url = input.ReadString();
            break;
          }
          case 26: {
            Body = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code