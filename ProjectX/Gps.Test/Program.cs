using Gps.Data.Handler;
using Gps.Data.License;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gps.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var b = new ServiceRepository();
            //b.GenerateLicenseKey("");

            var a = new ServiceRepository();
            a.GenerateLicenseKey("abc");
        }
    }
}
