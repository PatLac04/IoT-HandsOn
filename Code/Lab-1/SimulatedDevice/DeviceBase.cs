using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SimulatedDevice
{
    [DataContract]
    public class DeviceBase
    {
        [DataMember]
        public string GatewayId { get; set; }

        [DataMember]
        public long DeviceId { get; set; }

        [DataMember]
        public string DeviceSN { get; set; }

        [DataMember]
        public double? Temperature { get; set; }

        [DataMember]
        public double? Humidity { get; set; }

        [DataMember]
        public string PointInfo { get; set; }

        [DataMember]
        public long? SiteId { get; set; }

    }
}
