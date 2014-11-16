using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonDeserializer restSharpObject = new JsonDeserializer();

            var json = "{ \"has_title\": true, \"title\": \"GoodLuck\", \"entries\": [ [ \"/getting " +
                        " started. pdf\", { \"thumb_exists\": false, \"path\": \"/Getting " +
                        " Started. pdf\", \"client_mtime\": \"Wed, 08 Jan 2014 18: 00: 54" + " +0000\", \"bytes\": 249159} ] ," +
                        " [ \"/task.jpg\", {\"thumb_exists\": true, \"path\": \"/Ta" + " sk.jpg\", \"client_mtime\": \"Tue, 14 Jan 2014 05: 53: 570000\", \"bytes\": 207696} ] ] }";

            var response = new RestResponse { Content = json };

            var sampleObject = restSharpObject.Deserialize<SampleTask>(response);
            Console.WriteLine(sampleObject.Title);
        }
    }
}
