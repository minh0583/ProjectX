using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Gps.Common
{
    [ServiceContract]
    public interface IGpsRepository
    {
        [OperationContract]
        string GetMessage();

        [OperationContract]
        bool InsertGpsData(GpsViewModel gpsViewModel);

        [OperationContract]
        GpsViewModel GetGpsData();
    }
}
