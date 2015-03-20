using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gps.Common
{
    public class GpsViewModel
    {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime? LastChanged { get; set; }
        public Guid? LastChangedBy { get; set; }
    }
}
