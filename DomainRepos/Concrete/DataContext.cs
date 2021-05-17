using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainRepos.Entities
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options):base(options)
		{
		}
		public DbSet<Category> Category {get;set;}
		public DbSet<Product> Product {get;set;}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().ToTable("Category");
			modelBuilder.Entity<Product>().ToTable("Product");

			//modelBuilder.Entity<Category>()
			//.Navigation(p => p.Products)
			//.UsePropertyAccessMode(PropertyAccessMode.Property);
		}
	}
}
