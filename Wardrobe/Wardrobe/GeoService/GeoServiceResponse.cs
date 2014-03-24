using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wardrobe.GeoService
{
    public class GeoServiceResponse
    {
        public string city;
        public float lat;
        public float lng;
        public string state;
        public Timezone timezone;
        public int zip_code;

    }
    public class Timezone
    {
        public string is_dst;
        public string timezone_abbr;
        public string timezone_identifier;
        public string utc_offset_sec;
    }
}