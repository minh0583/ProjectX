using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Gps.Common
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public string LicenseNumber { get; set; }
    }
}
