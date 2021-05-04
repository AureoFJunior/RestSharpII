using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpII
{
    public class APIHelper<T>
    {
        public RestClient restClient;
        public RestRequest restRequest;
        public string baseUrl = "https://jsonplaceholder.typicode.com/";

        public RestClient SetUrl(string endpoint)
        {
            var url = Path.Combine(baseUrl, endpoint);
            var restClient = new RestClient(url);

            return restClient;
        }

        public RestRequest CreatePostRequest(string payload)
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);

            return restRequest;


        }

        public RestRequest CreateGetRequest(string payload)
        {
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;


        }

        public IRestResponse GetResponse(RestClient client, RestRequest request)
        {
            return client.Execute(request);
        }

        public FtClass GetContent<FtClass>(IRestResponse response)
        {
            var content = response.Content;
            var users = JsonConvert.DeserializeObject<FtClass>(content);

            return users;
        }



    }
}
