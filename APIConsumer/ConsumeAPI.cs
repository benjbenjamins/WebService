using APIService.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestHarness
{
	public class ConsumeAPI
	{
		public string APIUrl = "https://localhost:44317/Home/";
		static HttpClient client = null;

		public ConsumeAPI()
		{
			client = new HttpClient();
			client.BaseAddress = new Uri(APIUrl);
		}

		public HttpResponseMessage ReturnReponseMessage(string MethodName, string identifier)
		{
			HttpResponseMessage response = new HttpResponseMessage();
			response = client.GetAsync(client.BaseAddress + MethodName + identifier).Result;
			return response;
		}

		public List<ProductModel> ConvertResult(HttpResponseMessage response)
		{
			List<ProductModel> responseModel = new List<ProductModel>();
			string APIResult = response.Content.ReadAsStringAsync().Result;
			responseModel = JsonConvert.DeserializeObject<List<ProductModel>>(APIResult);

			return responseModel;
		}
	}
}

