using APIAutomationConcepts.Support;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace TestProject1
{
    public class Demo1FinPetByIdTest
    {

        [Test]
        public void Demo1FindPetByIdTest()
        {
            var client = new RestClient(baseUrl: "https://petstore.swagger.io/v2");

            var request = new RestRequest("pet/5", Method.Get);

            var response=client.ExecuteGet(request);

            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.Headers);
            Console.WriteLine(response.Content);
        }

        [Test]
        public void Demo2FindValidPetByIdTest()
        {
            var client = new RestClient(baseUrl: "https://petstore.swagger.io/v2");

            var request = new RestRequest("pet/{petId}", Method.Get);
            //use below method for sending path parameter
            request.AddUrlSegment("petId", 5);

            var response = client.ExecuteGet(request);

            Console.WriteLine(response.StatusCode);
            //Console.WriteLine(response.Headers);
            Console.WriteLine(response.Content);
            Console.WriteLine(HttpStatusCode.OK);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            //Assertion is fine but validating as a string is not recommended
            Assert.That(response.Content, Does.Contain("5"));
        }

        /// <summary>
        /// Option 1 - Proper way to validate the response data using dynamic
        /// </summary>
        [Test]
        public void Demo3FindValidPetById3Test()
        {
            var client = new RestClient(baseUrl: "https://petstore.swagger.io/v2");

            var request = new RestRequest("pet/{petId}", Method.Get);
            request.AddUrlSegment("petId", 5);
            var response = client.ExecuteGet(request);

            dynamic jsonBody= JsonConvert.DeserializeObject(response.Content);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            //Console.WriteLine(jsonBody);
            Console.WriteLine(jsonBody.id);
            Console.WriteLine(jsonBody.name);
            Console.WriteLine(jsonBody.status);
            Console.WriteLine(jsonBody.category);
            Console.WriteLine(jsonBody.category.id);
            Console.WriteLine(jsonBody.category.name);
            //Console.WriteLine(jsonBody.category["name"]);
            Console.WriteLine(jsonBody.tags);
            Console.WriteLine(jsonBody.tags[0]);
            Console.WriteLine(jsonBody.tags[0].id);
            Console.WriteLine(jsonBody.tags[0].name);

            Assert.That(Convert.ToInt32(jsonBody.id), Is.EqualTo(5));
        }

        /// <summary>
        /// Option 2 - Proper way to validate the response data using its own datatype (Pet Model)
        /// </summary>
        [Test]
        public void Demo4FindValidPetById3Test()
        {
            var client = new RestClient(baseUrl: "https://petstore.swagger.io/v2");

            var request = new RestRequest("pet/{petId}", Method.Get);
            request.AddUrlSegment("petId", 5);
            var response = client.ExecuteGet(request);

            Pet jsonBody = JsonConvert.DeserializeObject<Pet>(response.Content);

            Console.WriteLine(jsonBody.Id);
            Console.WriteLine(jsonBody.Name);
            Console.WriteLine(jsonBody.Status);
            Console.WriteLine(jsonBody.Category.Id);
            Console.WriteLine(jsonBody.Tags[0].Id);
        }

        [Test]
        public void Demo5FindInValidPetByIdTest()
        {
            var client = new RestClient(baseUrl: "https://petstore.swagger.io/v2");

            var request = new RestRequest("pet/{petId}", Method.Get);
            request.AddUrlSegment("petId", 545555);
            var response = client.ExecuteGet(request);

            dynamic jsonBody = JsonConvert.DeserializeObject(response.Content);


            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
            Assert.That(Convert.ToString(jsonBody.message), Is.EqualTo("Pet not found"));
        }
    }
}