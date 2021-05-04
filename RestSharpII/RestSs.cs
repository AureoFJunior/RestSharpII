using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpII
{
    public class RestSs
    {
        public FtClass GetUser()
        {
            var restClient = new RestClient("https://jsonplaceholder.typicode.com");
            var restRequest = new RestRequest("todos/2", Method.GET);
            restRequest.AddHeader("Accept", "application/json");

            restRequest.RequestFormat = DataFormat.Json;


            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var users = JsonConvert.DeserializeObject<FtClass>(content);

            return users;


        }

        /*public RestRequest CreateUser()
        {
            var restClient = new RestClient("https://jsonplaceholder.typicode.com");
            var restRequest = new RestRequest("posts", Method.POST);
            restRequest.AddHeader("Accept", "application/json");

            return restRequest;
        }*/
    }
}
