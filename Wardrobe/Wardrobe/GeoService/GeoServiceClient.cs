using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;

namespace Wardrobe.GeoService
{
    public class GeoServiceClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address) as HttpWebRequest;
            if (request == null) return null;
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            return request;
        }
    }
}