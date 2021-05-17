using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIService.Helpers;
using APIService.Models;
using DomainRepos.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
	//[ApiController]
	public class HomeController : Controller
	{
		private readonly DataContext _db;

		public HomeController(DataContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{

			return View();
		}


		#region ApiGETMethods

		[HttpGet]
		public List<ProductModel> ReturnFeaturedProducts(string SKU1, string SKU2, string SKU3)
		{
			List<ProductModel> productList = new List<ProductModel>();
			DataFetch dataFetch = new DataFetch(this._db);

			List<CategoryModel> SKUData = new List<CategoryModel>();
			SKUData.AddRange(dataFetch.ReturnCategoryModel(dataFetch.ReturnCategories(SKU1)));
			SKUData.AddRange(dataFetch.ReturnCategoryModel(dataFetch.ReturnCategories(SKU2)));
			SKUData.AddRange(dataFetch.ReturnCategoryModel(dataFetch.ReturnCategories(SKU3)));

			foreach (CategoryModel category in SKUData)
			{
				productList.AddRange(category.relatedProducts);
			}

			return productList;
		}

		[HttpGet]
		public List<ProductModel> ReturnProduct(string Identifier)
		{

			List<ProductModel> productList = new List<ProductModel>();
			DataFetch dfetch = new DataFetch(this._db);
			productList = dfetch.ReturnProductModel(dfetch.ReturnProducts(Identifier));

			return productList;
		}

		[HttpGet]
		public List<CategoryModel> ReturnCategory(string Identifier)
		{
			List<CategoryModel> categoryList = new List<CategoryModel>();
			DataFetch dfetch = new DataFetch(this._db);
			categoryList = dfetch.ReturnCategoryModel(dfetch.ReturnCategories(Identifier));

			return categoryList;
		}
		#endregion
	}
}
