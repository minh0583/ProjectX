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
    public interface IServiceRepository
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

        [OperationContract]
        [WebInvoke(UriTemplate = "/PushLocation", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool PushLocation(LocationViewModel data);

        [OperationContract]
        [WebGet(UriTemplate = "/GetLocation/{ID}", ResponseFormat = WebMessageFormat.Json)]
        LocationViewModel GetLocation(string ID);

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllLocation", ResponseFormat = WebMessageFormat.Json)]
        List<LocationViewModel> GetAllLocation();
    }
}
