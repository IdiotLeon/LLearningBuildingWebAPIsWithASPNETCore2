using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;

namespace LLearningBuildingWebAPIsWithASPNETCore2.Tests
{
    [TestClass]
    public class CustomerIntegrationTests
    {
        private readonly HttpClient _client;

        public CustomerIntegrationTests()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = server.CreateClient();
        }

        [TestMethod]
        public void CustomerGetAllTest()
        {
            // To arrange
            var request = new HttpRequestMessage(new HttpMethod("GET"), "/api/Customers");

            // To act
            var response = _client.SendAsync(request).Result;

            // To assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        [DataRow(100)]
        public void CustomerGetOneTest(int id)
        {
            // To arrange
            var request = new HttpRequestMessage(new HttpMethod("GET"), $"/api/Customers/{id}");

            // To act
            var response = _client.SendAsync(request).Result;

            // To assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
