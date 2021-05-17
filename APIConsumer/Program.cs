using APIService.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using TestHarness;

namespace APIConsumer
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("I Consume API's!");
			Console.WriteLine("Press Enter To Continue");
			Console.ReadKey();

			ConsumeAPI apihelper = new ConsumeAPI();
			HttpResponseMessage response = apihelper.ReturnReponseMessage("ReturnProduct?Identifier=", "8");
			List<ProductModel> pModel = apihelper.ConvertResult(response);

			if (pModel.Count > 0) 
			{
				foreach (ProductModel pm in pModel) 
				{
					Console.WriteLine(pm.Name);
				}
				Console.ReadLine();
			}
		}
	}
}
