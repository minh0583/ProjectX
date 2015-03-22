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
        bool GenerateLicenseKey(string randomKey);
    }
}
