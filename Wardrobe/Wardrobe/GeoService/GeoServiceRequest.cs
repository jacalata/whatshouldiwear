using System;
using System.Net;
using System.Text;
using Newtonsoft.Json;


namespace Wardrobe.GeoService
{
    public static class GeoServiceRequest
    {
        public static float[] Get(int ZIP)
        {
            var url = String.Format("https://zipcodedistanceapi.redline13.com/rest/{0}/info.{1}/{2}/{3}", GeoServiceWrapper.API_KEY, "json", ZIP, "degrees");
            GeoServiceClient client = new GeoServiceClient();
            client.Encoding = Encoding.UTF8;
            string result = client.DownloadString(url);

            System.IO.StringReader reader = new System.IO.StringReader(result);
            JsonTextReader json = new JsonTextReader(reader);

            JsonSerializer serializer = JsonSerializer.Create();
            GeoServiceResponse response = serializer.Deserialize<GeoServiceResponse>(json) as GeoServiceResponse;

            float[] location = {response.lat, response.lng};

            return location;
        }
    }
}