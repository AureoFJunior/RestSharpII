using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RestSharpII;

namespace APItestee
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerifyUsers()
        {
            RestSs demo = new RestSs();
            var response = demo.GetUser();
            Assert.AreEqual(2, response.id);
            Assert.AreEqual("quis ut nam facilis et officia qui", response.title);

        }

        [TestMethod]
        public void CreateNewUser()
        {
            string payload = @"{""userId"": 120,
                                ""id"": null,
                                ""title"": ""Arquimedes"",
                                ""completed"": true}";
            APIHelper<FtClass> user = new APIHelper<FtClass>();
            var url = user.SetUrl("posts");
            var request = user.CreatePostRequest(payload);
            var response = user.GetResponse(url, request);
            FtClass model = user.GetContent<FtClass>(response);

            Assert.AreEqual(101, model.id);
            Assert.AreEqual("Arquimedes", model.title);
        }
    }
}
