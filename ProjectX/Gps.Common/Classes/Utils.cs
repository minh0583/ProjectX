using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gps.Common
{
    public static class Utils
    {
        //private const string urlService = @"http://localhost:24773/Service.svc";

        private static string urlService = @"http://www.minh0583.somee.com/service.svc";

        public static void SetUrl(string urlReplace)
        {
            urlService = urlReplace;
        }

        public static bool DoPostData<T>(T data, string functionName)
        {
            var ser = new DataContractJsonSerializer(typeof(T));
            var stream = new MemoryStream();
            ser.WriteObject(stream, data);
            string postData = Encoding.UTF8.GetString(stream.ToArray(), 0, (int)stream.Length);
            var webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString(string.Format("{0}/{1}", urlService, functionName), "POST", postData);

            return true;
        }

        public static T DoGetData<T>(string funtionName, string parameter)
        {
            WebClient proxy = new WebClient();
            byte[] data = proxy.DownloadData(string.Format("{0}/{1}/{2}", urlService, funtionName, parameter));
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(T));
            var result = (T)obj.ReadObject(stream);

            return result;
        }


        public static List<T> DoGetDataList<T>(string funtionName)
        {
            WebClient proxy = new WebClient();
            byte[] data = proxy.DownloadData(string.Format("{0}/{1}", urlService, funtionName));
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<T>));
            var result = obj.ReadObject(stream) as List<T>;

            return result;
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

    }
}
