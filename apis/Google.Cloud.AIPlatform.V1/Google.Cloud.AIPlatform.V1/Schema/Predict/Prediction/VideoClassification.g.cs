// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/schema/predict/prediction/video_classification.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/schema/predict/prediction/video_classification.proto</summary>
  public static partial class VideoClassificationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/schema/predict/prediction/video_classification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VideoClassificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck9nb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvcHJlZGljdC9w",
            "cmVkaWN0aW9uL3ZpZGVvX2NsYXNzaWZpY2F0aW9uLnByb3RvEjRnb29nbGUu",
            "Y2xvdWQuYWlwbGF0Zm9ybS52MS5zY2hlbWEucHJlZGljdC5wcmVkaWN0aW9u",
            "Gh5nb29nbGUvcHJvdG9idWYvZHVyYXRpb24ucHJvdG8aHmdvb2dsZS9wcm90",
            "b2J1Zi93cmFwcGVycy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5w",
            "cm90byLyAQojVmlkZW9DbGFzc2lmaWNhdGlvblByZWRpY3Rpb25SZXN1bHQS",
            "CgoCaWQYASABKAkSFAoMZGlzcGxheV9uYW1lGAIgASgJEgwKBHR5cGUYAyAB",
            "KAkSNQoSdGltZV9zZWdtZW50X3N0YXJ0GAQgASgLMhkuZ29vZ2xlLnByb3Rv",
            "YnVmLkR1cmF0aW9uEjMKEHRpbWVfc2VnbWVudF9lbmQYBSABKAsyGS5nb29n",
            "bGUucHJvdG9idWYuRHVyYXRpb24SLwoKY29uZmlkZW5jZRgGIAEoCzIbLmdv",
            "b2dsZS5wcm90b2J1Zi5GbG9hdFZhbHVlQvECCjhjb20uZ29vZ2xlLmNsb3Vk",
            "LmFpcGxhdGZvcm0udjEuc2NoZW1hLnByZWRpY3QucHJlZGljdGlvbkIoVmlk",
            "ZW9DbGFzc2lmaWNhdGlvblByZWRpY3Rpb25SZXN1bHRQcm90b1ABWl5nb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Nsb3VkL2FpcGxh",
            "dGZvcm0vdjEvc2NoZW1hL3ByZWRpY3QvcHJlZGljdGlvbjtwcmVkaWN0aW9u",
            "qgI0R29vZ2xlLkNsb3VkLkFJUGxhdGZvcm0uVjEuU2NoZW1hLlByZWRpY3Qu",
            "UHJlZGljdGlvbsoCNEdvb2dsZVxDbG91ZFxBSVBsYXRmb3JtXFYxXFNjaGVt",
            "YVxQcmVkaWN0XFByZWRpY3Rpb27qAjpHb29nbGU6OkNsb3VkOjpBSVBsYXRm",
            "b3JtOjpWMTo6U2NoZW1hOjpQcmVkaWN0OjpQcmVkaWN0aW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.VideoClassificationPredictionResult), global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.VideoClassificationPredictionResult.Parser, new[]{ "Id", "DisplayName", "Type", "TimeSegmentStart", "TimeSegmentEnd", "Confidence" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Prediction output format for Video Classification.
  /// </summary>
  public sealed partial class VideoClassificationPredictionResult : pb::IMessage<VideoClassificationPredictionResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VideoClassificationPredictionResult> _parser = new pb::MessageParser<VideoClassificationPredictionResult>(() => new VideoClassificationPredictionResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VideoClassificationPredictionResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.VideoClassificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VideoClassificationPredictionResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VideoClassificationPredictionResult(VideoClassificationPredictionResult other) : this() {
      id_ = other.id_;
      displayName_ = other.displayName_;
      type_ = other.type_;
      timeSegmentStart_ = other.timeSegmentStart_ != null ? other.timeSegmentStart_.Clone() : null;
      timeSegmentEnd_ = other.timeSegmentEnd_ != null ? other.timeSegmentEnd_.Clone() : null;
      Confidence = other.Confidence;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VideoClassificationPredictionResult Clone() {
      return new VideoClassificationPredictionResult(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// The resource ID of the AnnotationSpec that had been identified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// The display name of the AnnotationSpec that had been identified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private string type_ = "";
    /// <summary>
    /// The type of the prediction. The requested types can be configured
    /// via parameters. This will be one of
    /// - segment-classification
    /// - shot-classification
    /// - one-sec-interval-classification
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time_segment_start" field.</summary>
    public const int TimeSegmentStartFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Duration timeSegmentStart_;
    /// <summary>
    /// The beginning, inclusive, of the video's time segment in which the
    /// AnnotationSpec has been identified. Expressed as a number of seconds as
    /// measured from the start of the video, with fractions up to a microsecond
    /// precision, and with "s" appended at the end. Note that for
    /// 'segment-classification' prediction type, this equals the original
    /// 'timeSegmentStart' from the input instance, for other types it is the
    /// start of a shot or a 1 second interval respectively.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration TimeSegmentStart {
      get { return timeSegmentStart_; }
      set {
        timeSegmentStart_ = value;
      }
    }

    /// <summary>Field number for the "time_segment_end" field.</summary>
    public const int TimeSegmentEndFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Duration timeSegmentEnd_;
    /// <summary>
    /// The end, exclusive, of the video's time segment in which the
    /// AnnotationSpec has been identified. Expressed as a number of seconds as
    /// measured from the start of the video, with fractions up to a microsecond
    /// precision, and with "s" appended at the end. Note that for
    /// 'segment-classification' prediction type, this equals the original
    /// 'timeSegmentEnd' from the input instance, for other types it is the end
    /// of a shot or a 1 second interval respectively.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration TimeSegmentEnd {
      get { return timeSegmentEnd_; }
      set {
        timeSegmentEnd_ = value;
      }
    }

    /// <summary>Field number for the "confidence" field.</summary>
    public const int ConfidenceFieldNumber = 6;
    private static readonly pb::FieldCodec<float?> _single_confidence_codec = pb::FieldCodec.ForStructWrapper<float>(50);
    private float? confidence_;
    /// <summary>
    /// The Model's confidence in correction of this prediction, higher
    /// value means higher confidence.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float? Confidence {
      get { return confidence_; }
      set {
        confidence_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VideoClassificationPredictionResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VideoClassificationPredictionResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Type != other.Type) return false;
      if (!object.Equals(TimeSegmentStart, other.TimeSegmentStart)) return false;
      if (!object.Equals(TimeSegmentEnd, other.TimeSegmentEnd)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.Equals(Confidence, other.Confidence)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (timeSegmentStart_ != null) hash ^= TimeSegmentStart.GetHashCode();
      if (timeSegmentEnd_ != null) hash ^= TimeSegmentEnd.GetHashCode();
      if (confidence_ != null) hash ^= pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.GetHashCode(Confidence);
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Type);
      }
      if (timeSegmentStart_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(TimeSegmentStart);
      }
      if (timeSegmentEnd_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(TimeSegmentEnd);
      }
      if (confidence_ != null) {
        _single_confidence_codec.WriteTagAndValue(output, Confidence);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Type);
      }
      if (timeSegmentStart_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(TimeSegmentStart);
      }
      if (timeSegmentEnd_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(TimeSegmentEnd);
      }
      if (confidence_ != null) {
        _single_confidence_codec.WriteTagAndValue(ref output, Confidence);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (timeSegmentStart_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TimeSegmentStart);
      }
      if (timeSegmentEnd_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TimeSegmentEnd);
      }
      if (confidence_ != null) {
        size += _single_confidence_codec.CalculateSizeWithTag(Confidence);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VideoClassificationPredictionResult other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.timeSegmentStart_ != null) {
        if (timeSegmentStart_ == null) {
          TimeSegmentStart = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        TimeSegmentStart.MergeFrom(other.TimeSegmentStart);
      }
      if (other.timeSegmentEnd_ != null) {
        if (timeSegmentEnd_ == null) {
          TimeSegmentEnd = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        TimeSegmentEnd.MergeFrom(other.TimeSegmentEnd);
      }
      if (other.confidence_ != null) {
        if (confidence_ == null || other.Confidence != 0F) {
          Confidence = other.Confidence;
        }
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Type = input.ReadString();
            break;
          }
          case 34: {
            if (timeSegmentStart_ == null) {
              TimeSegmentStart = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(TimeSegmentStart);
            break;
          }
          case 42: {
            if (timeSegmentEnd_ == null) {
              TimeSegmentEnd = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(TimeSegmentEnd);
            break;
          }
          case 50: {
            float? value = _single_confidence_codec.Read(input);
            if (confidence_ == null || value != 0F) {
              Confidence = value;
            }
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Type = input.ReadString();
            break;
          }
          case 34: {
            if (timeSegmentStart_ == null) {
              TimeSegmentStart = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(TimeSegmentStart);
            break;
          }
          case 42: {
            if (timeSegmentEnd_ == null) {
              TimeSegmentEnd = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(TimeSegmentEnd);
            break;
          }
          case 50: {
            float? value = _single_confidence_codec.Read(ref input);
            if (confidence_ == null || value != 0F) {
              Confidence = value;
            }
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