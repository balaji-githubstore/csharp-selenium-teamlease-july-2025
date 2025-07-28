using APIAutomationConcepts.Support;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAutomationConcepts
{
    public class Demo2FindPetByStatus
    {
        public RestClient client = new RestClient(baseUrl: "https://petstore.swagger.io/v2");

        [Test]
        public void Demo1FindPetByStatusTest()
        {

            var request = new RestRequest("pet/findByStatus", Method.Get);
            request.AddQueryParameter("status", "sold");

            var response = client.ExecuteGet(request);

            dynamic jsonBody = JsonConvert.DeserializeObject(response.Content);

            Console.WriteLine(response.StatusCode);
            //Console.WriteLine(jsonBody.Count);
            //Console.WriteLine(jsonBody[0].status);
            //Console.WriteLine(jsonBody[1].status);
            //Console.WriteLine(jsonBody[2].status);

            for (int i = 0; i < jsonBody.Count; i++)
            {
                Console.WriteLine(jsonBody[i].status);
                Assert.That(Convert.ToString(jsonBody[i].status), Is.EqualTo("sold"));
            }

            foreach(var item in jsonBody)
            {
                Console.WriteLine(item.status);
                Assert.That(Convert.ToString(item.status), Is.EqualTo("sold"));
            }
        }


        [Test]
        [TestCase("sold")]
        [TestCase("available")]
        public void Demo2FindPetByStatusTest(string status)
        {

            var request = new RestRequest("pet/findByStatus", Method.Get);
            request.AddQueryParameter("status", status);
            request.AddHeader("x-api-key", "reqres-free-v1");

            var response = client.ExecuteGet(request);

            List<Pet> jsonBody = JsonConvert.DeserializeObject<List<Pet>>(response.Content);

          //  Console.WriteLine(jsonBody[0].Id);

            foreach(Pet item in jsonBody)
            {
                Assert.That(Convert.ToString(item.Status), Is.EqualTo(status));
            }

        }
    }
}
