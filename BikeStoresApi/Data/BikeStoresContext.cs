using System;
using System.Collections.Generic;
using BookStoreApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Data;

public partial class BikeStoresContext : DbContext
{
    public BikeStoresContext()
    {
    }

    public BikeStoresContext(DbContextOptions<BikeStoresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Staff> Staffs { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

   

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new BrandConfiguration().Configure(modelBuilder);
        new CategoryConfiguration().Configure(modelBuilder);
        new CustomerConfiguration().Configure(modelBuilder);    
        new OrderConfiguration().Configure(modelBuilder);
        new OrderItemConfiguration().Configure(modelBuilder);
        new ProductConfiguration().Configure(modelBuilder); 
        new StaffConfiguration().Configure(modelBuilder);
        new StockConfiguration().Configure(modelBuilder);   
        new StoreConfiguration().Configure(modelBuilder);
    }
}
