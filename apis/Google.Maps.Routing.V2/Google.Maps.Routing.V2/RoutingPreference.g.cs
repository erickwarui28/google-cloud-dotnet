// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/routing/v2/routing_preference.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Maps.Routing.V2 {

  /// <summary>Holder for reflection information generated from google/maps/routing/v2/routing_preference.proto</summary>
  public static partial class RoutingPreferenceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/routing/v2/routing_preference.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoutingPreferenceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvbWFwcy9yb3V0aW5nL3YyL3JvdXRpbmdfcHJlZmVyZW5jZS5w",
            "cm90bxIWZ29vZ2xlLm1hcHMucm91dGluZy52Mip6ChFSb3V0aW5nUHJlZmVy",
            "ZW5jZRIiCh5ST1VUSU5HX1BSRUZFUkVOQ0VfVU5TUEVDSUZJRUQQABITCg9U",
            "UkFGRklDX1VOQVdBUkUQARIRCg1UUkFGRklDX0FXQVJFEAISGQoVVFJBRkZJ",
            "Q19BV0FSRV9PUFRJTUFMEANCzgEKGmNvbS5nb29nbGUubWFwcy5yb3V0aW5n",
            "LnYyQhZSb3V0aW5nUHJlZmVyZW5jZVByb3RvUAFaPWdvb2dsZS5nb2xhbmcu",
            "b3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvbWFwcy9yb3V0aW5nL3YyO3JvdXRp",
            "bmf4AQGiAgVHTVJWMqoCFkdvb2dsZS5NYXBzLlJvdXRpbmcuVjLKAhZHb29n",
            "bGVcTWFwc1xSb3V0aW5nXFYy6gIZR29vZ2xlOjpNYXBzOjpSb3V0aW5nOjpW",
            "MmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Maps.Routing.V2.RoutingPreference), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// A set of values that specify factors to take into consideration when
  /// calculating the route.
  /// </summary>
  public enum RoutingPreference {
    /// <summary>
    /// No routing preference specified. Default to `TRAFFIC_UNAWARE`.
    /// </summary>
    [pbr::OriginalName("ROUTING_PREFERENCE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Computes routes without taking live traffic conditions into consideration.
    /// Suitable when traffic conditions don't matter or are not applicable.
    /// Using this value produces the lowest latency.
    /// Note: For `RouteTravelMode` DRIVE and TWO_WHEELER choice of route and
    /// duration are based on road network and average time-independent traffic
    /// conditions. Results for a given request may vary over time due to changes
    /// in the road network, updated average traffic conditions, and the
    /// distributed nature of the service. Results may also vary between
    /// nearly-equivalent routes at any time or frequency.
    /// </summary>
    [pbr::OriginalName("TRAFFIC_UNAWARE")] TrafficUnaware = 1,
    /// <summary>
    /// Calculates routes taking live traffic conditions into consideration.
    /// In contrast to `TRAFFIC_AWARE_OPTIMAL`, some optimizations are applied to
    /// significantly reduce latency.
    /// </summary>
    [pbr::OriginalName("TRAFFIC_AWARE")] TrafficAware = 2,
    /// <summary>
    /// Calculates the routes taking live traffic conditions into consideration,
    /// without applying most performance optimizations. Using this value produces
    /// the highest latency.
    /// </summary>
    [pbr::OriginalName("TRAFFIC_AWARE_OPTIMAL")] TrafficAwareOptimal = 3,
  }

  #endregion

}

#endregion Designer generated code
