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
    public interface ILicenseServiceRepository
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/GenerateLicenseKey", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        string GenerateLicenseKey(string randomKey);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ActiveDevice", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        string ActiveDevice(NameValuePair data);

        [OperationContract]
        [WebInvoke(UriTemplate = "/VerifyDevice", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool VerifyDevice(string deviceId);
    }
}
