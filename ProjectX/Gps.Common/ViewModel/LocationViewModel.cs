﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Gps.Common
{
    [DataContract]
    public class LocationViewModel : BaseModel
    {
        [DataMember]
        public Guid ID { get; set; }

        [DataMember]
        public double? Longitude { get; set; }

        [DataMember]
        public double? Latitude { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public DateTime? LastChanged { get; set; }

        [DataMember]
        public Guid? LastChangedBy { get; set; }
    }
}
