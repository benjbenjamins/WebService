using DomainRepos.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainRepos
{
	public class Category
	{

		//[Key]
		public int CategoryId { get; set; }
		public string Name { get; set; }
		public string SKURange { get; set; }

		//[InverseProperty("ProductCategory")]
		public List<Product> Products { get; set; }

	}
}
