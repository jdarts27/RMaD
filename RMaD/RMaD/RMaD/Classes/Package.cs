using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RMaD.Classes
{
    internal class Package
    {
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Tracking_Number { get; set; }

        public void createPackage()
        {
        }

        public void postShipment()
        {
            var url = "https://api.trackinghive.com/trackings";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer " + "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjYzOGQyMmRmOWM0OGEwMDAyZDk3OTI5MiIsImlhdCI6MTY3MDE5Mzk0N30.NAMYKyQEsLTkHqhgF2DQ4EgAIUNhujCePx30Ze0-Zm0";
            httpRequest.ContentType = "application/json";

            var data = @"{""tracking_number"": ""9361289676090919095393"",
 ""slug"": ""usps""}";

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            Console.WriteLine(httpResponse.StatusCode);
        }
    }
}
