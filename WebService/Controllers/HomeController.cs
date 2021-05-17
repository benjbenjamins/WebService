using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebService.Models;

namespace WebService.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			return View();
		}

		[HttpGet]
		public List<Product> ReturnProduct(string parameter = "") 
		{
			bool allProds = false;

			if (String.IsNullOrWhiteSpace(parameter))
				allProds = true;

			List<Product> productList = new List<Product>();

			return productList;
		}

		[HttpGet]
		public List<Category> ReturnCategory(int Id = 0)
		{
			bool allCat = false;

			if (Id == 0)
				allCat = true;

			List<Category> categoryList = new List<Category>();

			return categoryList;
		}
	}
}
