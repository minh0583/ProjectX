using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gps.Data.Database
{
    public partial class GpsDataEntities : IDisposable
    { 
        void IDisposable.Dispose()
        {
            this.Dispose();
        }
    }
}
