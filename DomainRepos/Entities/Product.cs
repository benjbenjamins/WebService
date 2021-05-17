using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainRepos.Entities
{
	public class Product
	{
		//[Key]
		public int ProductId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }

		[ForeignKey("Category")]
		//[Column(Order=1)]
		public int CategoryId { get; set; }
		public Category Category { get; set; }
		public string SKU { get; set; }
	}
}
