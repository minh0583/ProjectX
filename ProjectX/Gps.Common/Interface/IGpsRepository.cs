using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Gps.Common
{
    [ServiceContract]           
    public interface IGpsRepository
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetMessage", ResponseFormat = WebMessageFormat.Json)]
        string GetMessage();

        [OperationContract]
        [WebInvoke(UriTemplate = "/InsertGpsData", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")] 
        bool InsertGpsData(GpsViewModel gpsViewModel);

        [OperationContract]
        [WebGet(UriTemplate = "/GetGpsData/{ID}", ResponseFormat = WebMessageFormat.Json)]
        GpsViewModel GetGpsData(string ID);
    }
}
