// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/channel/v1/customers.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Channel.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/channel/v1/customers.proto</summary>
  public static partial class CustomersReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/channel/v1/customers.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomersReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidnb29nbGUvY2xvdWQvY2hhbm5lbC92MS9jdXN0b21lcnMucHJvdG8SF2dv",
            "b2dsZS5jbG91ZC5jaGFubmVsLnYxGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2",
            "aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGiRnb29nbGUv",
            "Y2xvdWQvY2hhbm5lbC92MS9jb21tb24ucHJvdG8aH2dvb2dsZS9wcm90b2J1",
            "Zi90aW1lc3RhbXAucHJvdG8aIGdvb2dsZS90eXBlL3Bvc3RhbF9hZGRyZXNz",
            "LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvItEECghDdXN0",
            "b21lchIRCgRuYW1lGAEgASgJQgPgQQMSHQoQb3JnX2Rpc3BsYXlfbmFtZRgC",
            "IAEoCUID4EECEjsKEm9yZ19wb3N0YWxfYWRkcmVzcxgDIAEoCzIaLmdvb2ds",
            "ZS50eXBlLlBvc3RhbEFkZHJlc3NCA+BBAhJCChRwcmltYXJ5X2NvbnRhY3Rf",
            "aW5mbxgEIAEoCzIkLmdvb2dsZS5jbG91ZC5jaGFubmVsLnYxLkNvbnRhY3RJ",
            "bmZvEhcKD2FsdGVybmF0ZV9lbWFpbBgFIAEoCRITCgZkb21haW4YBiABKAlC",
            "A+BBAhI0CgtjcmVhdGVfdGltZRgHIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5U",
            "aW1lc3RhbXBCA+BBAxI0Cgt1cGRhdGVfdGltZRgIIAEoCzIaLmdvb2dsZS5w",
            "cm90b2J1Zi5UaW1lc3RhbXBCA+BBAxIeChFjbG91ZF9pZGVudGl0eV9pZBgJ",
            "IAEoCUID4EEDEhoKDWxhbmd1YWdlX2NvZGUYCiABKAlCA+BBARJMChNjbG91",
            "ZF9pZGVudGl0eV9pbmZvGAwgASgLMiouZ29vZ2xlLmNsb3VkLmNoYW5uZWwu",
            "djEuQ2xvdWRJZGVudGl0eUluZm9CA+BBAxIaChJjaGFubmVsX3BhcnRuZXJf",
            "aWQYDSABKAk6UupBTwokY2xvdWRjaGFubmVsLmdvb2dsZWFwaXMuY29tL0N1",
            "c3RvbWVyEidhY2NvdW50cy97YWNjb3VudH0vY3VzdG9tZXJzL3tjdXN0b21l",
            "cn0igQEKC0NvbnRhY3RJbmZvEhIKCmZpcnN0X25hbWUYASABKAkSEQoJbGFz",
            "dF9uYW1lGAIgASgJEhkKDGRpc3BsYXlfbmFtZRgEIAEoCUID4EEDEg0KBWVt",
            "YWlsGAUgASgJEhIKBXRpdGxlGAYgASgJQgPgQQESDQoFcGhvbmUYByABKAlC",
            "bwobY29tLmdvb2dsZS5jbG91ZC5jaGFubmVsLnYxQg5DdXN0b21lcnNQcm90",
            "b1ABWj5nb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Ns",
            "b3VkL2NoYW5uZWwvdjE7Y2hhbm5lbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.Channel.V1.CommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Type.PostalAddressReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Channel.V1.Customer), global::Google.Cloud.Channel.V1.Customer.Parser, new[]{ "Name", "OrgDisplayName", "OrgPostalAddress", "PrimaryContactInfo", "AlternateEmail", "Domain", "CreateTime", "UpdateTime", "CloudIdentityId", "LanguageCode", "CloudIdentityInfo", "ChannelPartnerId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Channel.V1.ContactInfo), global::Google.Cloud.Channel.V1.ContactInfo.Parser, new[]{ "FirstName", "LastName", "DisplayName", "Email", "Title", "Phone" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Entity representing a customer of a reseller or distributor.
  /// </summary>
  public sealed partial class Customer : pb::IMessage<Customer>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Customer> _parser = new pb::MessageParser<Customer>(() => new Customer());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Customer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Channel.V1.CustomersReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Customer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Customer(Customer other) : this() {
      name_ = other.name_;
      orgDisplayName_ = other.orgDisplayName_;
      orgPostalAddress_ = other.orgPostalAddress_ != null ? other.orgPostalAddress_.Clone() : null;
      primaryContactInfo_ = other.primaryContactInfo_ != null ? other.primaryContactInfo_.Clone() : null;
      alternateEmail_ = other.alternateEmail_;
      domain_ = other.domain_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      cloudIdentityId_ = other.cloudIdentityId_;
      languageCode_ = other.languageCode_;
      cloudIdentityInfo_ = other.cloudIdentityInfo_ != null ? other.cloudIdentityInfo_.Clone() : null;
      channelPartnerId_ = other.channelPartnerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Customer Clone() {
      return new Customer(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Resource name of the customer.
    /// Format: accounts/{account_id}/customers/{customer_id}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "org_display_name" field.</summary>
    public const int OrgDisplayNameFieldNumber = 2;
    private string orgDisplayName_ = "";
    /// <summary>
    /// Required. Name of the organization that the customer entity represents.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OrgDisplayName {
      get { return orgDisplayName_; }
      set {
        orgDisplayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "org_postal_address" field.</summary>
    public const int OrgPostalAddressFieldNumber = 3;
    private global::Google.Type.PostalAddress orgPostalAddress_;
    /// <summary>
    /// Required. Address of the organization of the customer entity.
    /// Region and zip codes are required to enforce US laws and embargoes.
    /// Language code is discarded. Use the Customer-level language code to set the
    /// customer's language.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Type.PostalAddress OrgPostalAddress {
      get { return orgPostalAddress_; }
      set {
        orgPostalAddress_ = value;
      }
    }

    /// <summary>Field number for the "primary_contact_info" field.</summary>
    public const int PrimaryContactInfoFieldNumber = 4;
    private global::Google.Cloud.Channel.V1.ContactInfo primaryContactInfo_;
    /// <summary>
    /// Primary contact info.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Channel.V1.ContactInfo PrimaryContactInfo {
      get { return primaryContactInfo_; }
      set {
        primaryContactInfo_ = value;
      }
    }

    /// <summary>Field number for the "alternate_email" field.</summary>
    public const int AlternateEmailFieldNumber = 5;
    private string alternateEmail_ = "";
    /// <summary>
    /// Secondary contact email.
    /// Alternate email and primary contact email are required to have different
    /// domains if primary contact email is present.
    /// When creating admin.google.com accounts, users get notified credentials at
    /// this email. This email address is also used as a recovery email.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AlternateEmail {
      get { return alternateEmail_; }
      set {
        alternateEmail_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "domain" field.</summary>
    public const int DomainFieldNumber = 6;
    private string domain_ = "";
    /// <summary>
    /// Required. Primary domain used by the customer.
    /// Domain of primary contact email is required to be same as the provided
    /// domain.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Domain {
      get { return domain_; }
      set {
        domain_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The time at which the customer is created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 8;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. The time at which the customer is updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "cloud_identity_id" field.</summary>
    public const int CloudIdentityIdFieldNumber = 9;
    private string cloudIdentityId_ = "";
    /// <summary>
    /// Output only. Customer's cloud_identity_id.
    /// Populated only if a Cloud Identity resource exists for this customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CloudIdentityId {
      get { return cloudIdentityId_; }
      set {
        cloudIdentityId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "language_code" field.</summary>
    public const int LanguageCodeFieldNumber = 10;
    private string languageCode_ = "";
    /// <summary>
    /// Optional. The BCP-47 language code, such as "en-US" or "sr-Latn". For more
    /// information, see
    /// https://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LanguageCode {
      get { return languageCode_; }
      set {
        languageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cloud_identity_info" field.</summary>
    public const int CloudIdentityInfoFieldNumber = 12;
    private global::Google.Cloud.Channel.V1.CloudIdentityInfo cloudIdentityInfo_;
    /// <summary>
    /// Output only. Cloud Identity information for the customer.
    /// Populated only if a Cloud Identity account exists for this customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Channel.V1.CloudIdentityInfo CloudIdentityInfo {
      get { return cloudIdentityInfo_; }
      set {
        cloudIdentityInfo_ = value;
      }
    }

    /// <summary>Field number for the "channel_partner_id" field.</summary>
    public const int ChannelPartnerIdFieldNumber = 13;
    private string channelPartnerId_ = "";
    /// <summary>
    /// Cloud Identity ID of the customer's channel partner.
    /// Populated only if a channel partner exists for this customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ChannelPartnerId {
      get { return channelPartnerId_; }
      set {
        channelPartnerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Customer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Customer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (OrgDisplayName != other.OrgDisplayName) return false;
      if (!object.Equals(OrgPostalAddress, other.OrgPostalAddress)) return false;
      if (!object.Equals(PrimaryContactInfo, other.PrimaryContactInfo)) return false;
      if (AlternateEmail != other.AlternateEmail) return false;
      if (Domain != other.Domain) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (CloudIdentityId != other.CloudIdentityId) return false;
      if (LanguageCode != other.LanguageCode) return false;
      if (!object.Equals(CloudIdentityInfo, other.CloudIdentityInfo)) return false;
      if (ChannelPartnerId != other.ChannelPartnerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (OrgDisplayName.Length != 0) hash ^= OrgDisplayName.GetHashCode();
      if (orgPostalAddress_ != null) hash ^= OrgPostalAddress.GetHashCode();
      if (primaryContactInfo_ != null) hash ^= PrimaryContactInfo.GetHashCode();
      if (AlternateEmail.Length != 0) hash ^= AlternateEmail.GetHashCode();
      if (Domain.Length != 0) hash ^= Domain.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (CloudIdentityId.Length != 0) hash ^= CloudIdentityId.GetHashCode();
      if (LanguageCode.Length != 0) hash ^= LanguageCode.GetHashCode();
      if (cloudIdentityInfo_ != null) hash ^= CloudIdentityInfo.GetHashCode();
      if (ChannelPartnerId.Length != 0) hash ^= ChannelPartnerId.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (OrgDisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(OrgDisplayName);
      }
      if (orgPostalAddress_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OrgPostalAddress);
      }
      if (primaryContactInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PrimaryContactInfo);
      }
      if (AlternateEmail.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(AlternateEmail);
      }
      if (Domain.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Domain);
      }
      if (createTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(UpdateTime);
      }
      if (CloudIdentityId.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(CloudIdentityId);
      }
      if (LanguageCode.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(LanguageCode);
      }
      if (cloudIdentityInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(CloudIdentityInfo);
      }
      if (ChannelPartnerId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(ChannelPartnerId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (OrgDisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(OrgDisplayName);
      }
      if (orgPostalAddress_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OrgPostalAddress);
      }
      if (primaryContactInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PrimaryContactInfo);
      }
      if (AlternateEmail.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(AlternateEmail);
      }
      if (Domain.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Domain);
      }
      if (createTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(UpdateTime);
      }
      if (CloudIdentityId.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(CloudIdentityId);
      }
      if (LanguageCode.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(LanguageCode);
      }
      if (cloudIdentityInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(CloudIdentityInfo);
      }
      if (ChannelPartnerId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(ChannelPartnerId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (OrgDisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OrgDisplayName);
      }
      if (orgPostalAddress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OrgPostalAddress);
      }
      if (primaryContactInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PrimaryContactInfo);
      }
      if (AlternateEmail.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AlternateEmail);
      }
      if (Domain.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Domain);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (CloudIdentityId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CloudIdentityId);
      }
      if (LanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LanguageCode);
      }
      if (cloudIdentityInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CloudIdentityInfo);
      }
      if (ChannelPartnerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ChannelPartnerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Customer other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.OrgDisplayName.Length != 0) {
        OrgDisplayName = other.OrgDisplayName;
      }
      if (other.orgPostalAddress_ != null) {
        if (orgPostalAddress_ == null) {
          OrgPostalAddress = new global::Google.Type.PostalAddress();
        }
        OrgPostalAddress.MergeFrom(other.OrgPostalAddress);
      }
      if (other.primaryContactInfo_ != null) {
        if (primaryContactInfo_ == null) {
          PrimaryContactInfo = new global::Google.Cloud.Channel.V1.ContactInfo();
        }
        PrimaryContactInfo.MergeFrom(other.PrimaryContactInfo);
      }
      if (other.AlternateEmail.Length != 0) {
        AlternateEmail = other.AlternateEmail;
      }
      if (other.Domain.Length != 0) {
        Domain = other.Domain;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      if (other.CloudIdentityId.Length != 0) {
        CloudIdentityId = other.CloudIdentityId;
      }
      if (other.LanguageCode.Length != 0) {
        LanguageCode = other.LanguageCode;
      }
      if (other.cloudIdentityInfo_ != null) {
        if (cloudIdentityInfo_ == null) {
          CloudIdentityInfo = new global::Google.Cloud.Channel.V1.CloudIdentityInfo();
        }
        CloudIdentityInfo.MergeFrom(other.CloudIdentityInfo);
      }
      if (other.ChannelPartnerId.Length != 0) {
        ChannelPartnerId = other.ChannelPartnerId;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            OrgDisplayName = input.ReadString();
            break;
          }
          case 26: {
            if (orgPostalAddress_ == null) {
              OrgPostalAddress = new global::Google.Type.PostalAddress();
            }
            input.ReadMessage(OrgPostalAddress);
            break;
          }
          case 34: {
            if (primaryContactInfo_ == null) {
              PrimaryContactInfo = new global::Google.Cloud.Channel.V1.ContactInfo();
            }
            input.ReadMessage(PrimaryContactInfo);
            break;
          }
          case 42: {
            AlternateEmail = input.ReadString();
            break;
          }
          case 50: {
            Domain = input.ReadString();
            break;
          }
          case 58: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 66: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 74: {
            CloudIdentityId = input.ReadString();
            break;
          }
          case 82: {
            LanguageCode = input.ReadString();
            break;
          }
          case 98: {
            if (cloudIdentityInfo_ == null) {
              CloudIdentityInfo = new global::Google.Cloud.Channel.V1.CloudIdentityInfo();
            }
            input.ReadMessage(CloudIdentityInfo);
            break;
          }
          case 106: {
            ChannelPartnerId = input.ReadString();
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            OrgDisplayName = input.ReadString();
            break;
          }
          case 26: {
            if (orgPostalAddress_ == null) {
              OrgPostalAddress = new global::Google.Type.PostalAddress();
            }
            input.ReadMessage(OrgPostalAddress);
            break;
          }
          case 34: {
            if (primaryContactInfo_ == null) {
              PrimaryContactInfo = new global::Google.Cloud.Channel.V1.ContactInfo();
            }
            input.ReadMessage(PrimaryContactInfo);
            break;
          }
          case 42: {
            AlternateEmail = input.ReadString();
            break;
          }
          case 50: {
            Domain = input.ReadString();
            break;
          }
          case 58: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 66: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 74: {
            CloudIdentityId = input.ReadString();
            break;
          }
          case 82: {
            LanguageCode = input.ReadString();
            break;
          }
          case 98: {
            if (cloudIdentityInfo_ == null) {
              CloudIdentityInfo = new global::Google.Cloud.Channel.V1.CloudIdentityInfo();
            }
            input.ReadMessage(CloudIdentityInfo);
            break;
          }
          case 106: {
            ChannelPartnerId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Contact information for a customer account.
  /// </summary>
  public sealed partial class ContactInfo : pb::IMessage<ContactInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ContactInfo> _parser = new pb::MessageParser<ContactInfo>(() => new ContactInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ContactInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Channel.V1.CustomersReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContactInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContactInfo(ContactInfo other) : this() {
      firstName_ = other.firstName_;
      lastName_ = other.lastName_;
      displayName_ = other.displayName_;
      email_ = other.email_;
      title_ = other.title_;
      phone_ = other.phone_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContactInfo Clone() {
      return new ContactInfo(this);
    }

    /// <summary>Field number for the "first_name" field.</summary>
    public const int FirstNameFieldNumber = 1;
    private string firstName_ = "";
    /// <summary>
    /// First name of the contact in the customer account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FirstName {
      get { return firstName_; }
      set {
        firstName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_name" field.</summary>
    public const int LastNameFieldNumber = 2;
    private string lastName_ = "";
    /// <summary>
    /// Last name of the contact in the customer account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LastName {
      get { return lastName_; }
      set {
        lastName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 4;
    private string displayName_ = "";
    /// <summary>
    /// Output only. Display name of the contact in the customer account.
    /// Populated by combining customer first name and last name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 5;
    private string email_ = "";
    /// <summary>
    /// Email of the contact in the customer account.
    /// Email is required for entitlements that need creation of admin.google.com
    /// accounts. The email will be the username used in credentials to access the
    /// admin.google.com account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 6;
    private string title_ = "";
    /// <summary>
    /// Optional. Job title of the contact in the customer account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "phone" field.</summary>
    public const int PhoneFieldNumber = 7;
    private string phone_ = "";
    /// <summary>
    /// Phone number of the contact in the customer account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Phone {
      get { return phone_; }
      set {
        phone_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ContactInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ContactInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FirstName != other.FirstName) return false;
      if (LastName != other.LastName) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Email != other.Email) return false;
      if (Title != other.Title) return false;
      if (Phone != other.Phone) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FirstName.Length != 0) hash ^= FirstName.GetHashCode();
      if (LastName.Length != 0) hash ^= LastName.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Phone.Length != 0) hash ^= Phone.GetHashCode();
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
      if (FirstName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FirstName);
      }
      if (LastName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LastName);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DisplayName);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Email);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Title);
      }
      if (Phone.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Phone);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (FirstName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FirstName);
      }
      if (LastName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LastName);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DisplayName);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Email);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Title);
      }
      if (Phone.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Phone);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FirstName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FirstName);
      }
      if (LastName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastName);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Phone.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Phone);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ContactInfo other) {
      if (other == null) {
        return;
      }
      if (other.FirstName.Length != 0) {
        FirstName = other.FirstName;
      }
      if (other.LastName.Length != 0) {
        LastName = other.LastName;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Phone.Length != 0) {
        Phone = other.Phone;
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
            FirstName = input.ReadString();
            break;
          }
          case 18: {
            LastName = input.ReadString();
            break;
          }
          case 34: {
            DisplayName = input.ReadString();
            break;
          }
          case 42: {
            Email = input.ReadString();
            break;
          }
          case 50: {
            Title = input.ReadString();
            break;
          }
          case 58: {
            Phone = input.ReadString();
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
            FirstName = input.ReadString();
            break;
          }
          case 18: {
            LastName = input.ReadString();
            break;
          }
          case 34: {
            DisplayName = input.ReadString();
            break;
          }
          case 42: {
            Email = input.ReadString();
            break;
          }
          case 50: {
            Title = input.ReadString();
            break;
          }
          case 58: {
            Phone = input.ReadString();
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