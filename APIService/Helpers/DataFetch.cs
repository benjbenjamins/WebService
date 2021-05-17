using APIService.Models;
using DomainRepos;
using DomainRepos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.ModelBinding;

namespace APIService.Helpers
{
	public class DataFetch
	{
		private readonly DataContext db;

		public DataFetch(DataContext _db)
		{
			db =_db;
		}

		public List<Product> ReturnProducts(string parameter)
		{
			List<Product> productData = new List<Product>();

			if (String.IsNullOrWhiteSpace(parameter)) 
			{
				try
				{
					productData = db.Product.ToList();
					return productData;
				}
				catch (Exception ex) 
				{
				}
				
			}
			int IdValue = 0;
			bool IsInt = int.TryParse(parameter.Replace('"', ' '), out IdValue);

			if (IsInt & IdValue < 10000)
			{
				try
				{
					productData = db.Product.Where(x => x.ProductId == IdValue).ToList();
				}
				catch(Exception ex)
				{
				}
			}
			if (IsInt & IdValue >= 10000)
			{
				try
				{
					productData = db.Product.Where(x => x.SKU == parameter).ToList();
				}
				catch 
				{
				}

			}
			if(!IsInt)
			{
				try
				{
					productData = db.Product.Where(x => x.Name == parameter).ToList();
				}
				catch(Exception ex)
				{
				}
			}

			return productData;
		}
		public List<ProductModel> ReturnProductModel(List<Product> dbResult)
		{
			List<ProductModel> result = new List<ProductModel>();
			if (dbResult != null)
			{
				try
				{
					foreach (Product prod in dbResult)
					{
						ProductModel model = new ProductModel();

						model.Id = prod.ProductId;
						model.Name = prod.Name.Trim();
						model.Price = String.Format("£{0}",prod.Price);
						model.Description = prod.Description;
						model.CategoryId = prod.Category.CategoryId;

						result.Add(model);
					}
				}
				catch (Exception ex)
				{

				}

			}
			return result;
		}
		public List<Category> ReturnCategories(string parameter)
		{
			List<Category> categoryData = new List<Category>();

			if (String.IsNullOrWhiteSpace(parameter))
			{
				try
				{
					categoryData = db.Category.ToList();
					return categoryData;
				}
				catch (Exception ex)
				{
				}
				return categoryData;
			}
			int IdValue = 0;
			bool Isid = int.TryParse(parameter.Replace('"', ' '), out IdValue) ;
		
			if (Isid) 
			{
				try
				{
					categoryData = db.Category.Where(x => x.CategoryId == IdValue).ToList();
				}
				catch(Exception ex)
				{
				}
			}
			else
			{
				try
				{
					categoryData = db.Category.Where(x => x.Name == parameter).ToList();
				}
				catch 
				{
				}
			}

			return categoryData;
		}
		public List<CategoryModel> ReturnCategoryModel(List<Category> dbResult)
		{
			List <CategoryModel> result = new List<CategoryModel>();
			if (dbResult != null) 
			{
				try
				{
					foreach (Category cat in dbResult)
					{
						CategoryModel model = new CategoryModel();

						model.Id = cat.CategoryId;
						model.Name = cat.Name.Trim();
						model.SKURange = cat.SKURange.Trim();
						model.relatedProducts = new List<ProductModel>();
						List<Product> prodList = db.Product.Where(x => x.CategoryId == cat.CategoryId).ToList();
						if (prodList != null)
						{
							foreach (Product product in prodList)
							{
								ProductModel prModel = new ProductModel();
								prModel.CategoryId = product.CategoryId;
								prModel.Description = product.Description.Trim();
								prModel.Id = product.ProductId;
								prModel.Name = product.Name.Trim();
								prModel.Price = String.Format("£{0}",product.Price);
								model.relatedProducts.Add(prModel);
							}
						}
						result.Add(model);
					}
				}
				catch (Exception ex)
				{

				}

			}
			return result;
		}



	}
}
