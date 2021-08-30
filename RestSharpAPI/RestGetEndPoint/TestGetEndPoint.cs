/*
 * project = Doing RESTSharpAPI
 * Author = Lavanya Gollapudi
 * Created Date = 19/08/2021
 */


using System;
using RestSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace RestSharpAPI.RestGetEndPoint
{
    [TestClass]
    public class TestGetEndPoint
    {
        
        private string getUrl = "https://reqres.in/api/users/2";

        [TestMethod]
        public void TestGetUsingRestSharp()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(getUrl);
            IRestResponse restResponse = restClient.Get(restRequest);

            if (restResponse.IsSuccessful)
            {
                Console.WriteLine("StatusCode : " + restResponse.StatusCode);
                Console.WriteLine("Response : " + restResponse.Content);

            }
            Console.WriteLine(restResponse.ErrorMessage);
            Console.WriteLine(restResponse.ErrorException);


            //Console.WriteLine(JsonConvert.SerializeObject(restResponse.Content, Formatting.Intendend));

        }
    }
}
