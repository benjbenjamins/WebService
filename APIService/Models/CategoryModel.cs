using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIService.Models
{
	public class CategoryModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<ProductModel> relatedProducts{get;set;}
		public string SKURange {get;set;}
	}
}