// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/gaming/v1beta/game_server_configs_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Gaming.V1Beta {

  /// <summary>Holder for reflection information generated from google/cloud/gaming/v1beta/game_server_configs_service.proto</summary>
  public static partial class GameServerConfigsServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/gaming/v1beta/game_server_configs_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameServerConfigsServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvY2xvdWQvZ2FtaW5nL3YxYmV0YS9nYW1lX3NlcnZlcl9jb25m",
            "aWdzX3NlcnZpY2UucHJvdG8SGmdvb2dsZS5jbG91ZC5nYW1pbmcudjFiZXRh",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGhdnb29nbGUvYXBpL2Ns",
            "aWVudC5wcm90bxo0Z29vZ2xlL2Nsb3VkL2dhbWluZy92MWJldGEvZ2FtZV9z",
            "ZXJ2ZXJfY29uZmlncy5wcm90bxojZ29vZ2xlL2xvbmdydW5uaW5nL29wZXJh",
            "dGlvbnMucHJvdG8yvggKGEdhbWVTZXJ2ZXJDb25maWdzU2VydmljZRLmAQoV",
            "TGlzdEdhbWVTZXJ2ZXJDb25maWdzEjguZ29vZ2xlLmNsb3VkLmdhbWluZy52",
            "MWJldGEuTGlzdEdhbWVTZXJ2ZXJDb25maWdzUmVxdWVzdBo5Lmdvb2dsZS5j",
            "bG91ZC5nYW1pbmcudjFiZXRhLkxpc3RHYW1lU2VydmVyQ29uZmlnc1Jlc3Bv",
            "bnNlIliC0+STAkkSRy92MWJldGEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0",
            "aW9ucy8qL2dhbWVTZXJ2ZXJEZXBsb3ltZW50cy8qfS9jb25maWdz2kEGcGFy",
            "ZW50EtMBChNHZXRHYW1lU2VydmVyQ29uZmlnEjYuZ29vZ2xlLmNsb3VkLmdh",
            "bWluZy52MWJldGEuR2V0R2FtZVNlcnZlckNvbmZpZ1JlcXVlc3QaLC5nb29n",
            "bGUuY2xvdWQuZ2FtaW5nLnYxYmV0YS5HYW1lU2VydmVyQ29uZmlnIlaC0+ST",
            "AkkSRy92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9nYW1l",
            "U2VydmVyRGVwbG95bWVudHMvKi9jb25maWdzLyp92kEEbmFtZRKcAgoWQ3Jl",
            "YXRlR2FtZVNlcnZlckNvbmZpZxI5Lmdvb2dsZS5jbG91ZC5nYW1pbmcudjFi",
            "ZXRhLkNyZWF0ZUdhbWVTZXJ2ZXJDb25maWdSZXF1ZXN0Gh0uZ29vZ2xlLmxv",
            "bmdydW5uaW5nLk9wZXJhdGlvbiKnAYLT5JMCXSJHL3YxYmV0YS97cGFyZW50",
            "PXByb2plY3RzLyovbG9jYXRpb25zLyovZ2FtZVNlcnZlckRlcGxveW1lbnRz",
            "Lyp9L2NvbmZpZ3M6EmdhbWVfc2VydmVyX2NvbmZpZ9pBGXBhcmVudCxnYW1l",
            "X3NlcnZlcl9jb25maWfKQSUKEEdhbWVTZXJ2ZXJDb25maWcSEU9wZXJhdGlv",
            "bk1ldGFkYXRhEvIBChZEZWxldGVHYW1lU2VydmVyQ29uZmlnEjkuZ29vZ2xl",
            "LmNsb3VkLmdhbWluZy52MWJldGEuRGVsZXRlR2FtZVNlcnZlckNvbmZpZ1Jl",
            "cXVlc3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIn6C0+STAkkq",
            "Ry92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9nYW1lU2Vy",
            "dmVyRGVwbG95bWVudHMvKi9jb25maWdzLyp92kEEbmFtZcpBJQoQR2FtZVNl",
            "cnZlckNvbmZpZxIRT3BlcmF0aW9uTWV0YWRhdGEaT8pBG2dhbWVzZXJ2aWNl",
            "cy5nb29nbGVhcGlzLmNvbdJBLmh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29t",
            "L2F1dGgvY2xvdWQtcGxhdGZvcm1CZAoeY29tLmdvb2dsZS5jbG91ZC5nYW1p",
            "bmcudjFiZXRhUAFaQGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvY2xvdWQvZ2FtaW5nL3YxYmV0YTtnYW1pbmdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Cloud.Gaming.V1Beta.GameServerConfigsReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code