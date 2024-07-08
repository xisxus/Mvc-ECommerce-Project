using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace FinalProject.Models.DAL
{
    public static class ProjectSeedData
    {
        public static void Seed(AppDbContext context)
        {
            context.Users.AddOrUpdate(e => e.UserId,
                new User
                {
                    UserId = 1,
                    FirstName = "Hulk",
                    LastName = "Hulk",
                    Email = "shehulk@gmail.com",
                    Password = "123",
                    RoleType = 1,
                    PhoneNumber = "123-456-7890",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Address = "123 Main St, City, Country"
                });

            // Seed Catagories
            context.Categories.AddOrUpdate(
            c => c.CategoryId,
            new Category { CategoryId = 1, Name = "Summer Fruit" },
            new Category { CategoryId = 2, Name = "Winter Fruit" },
            new Category { CategoryId = 3, Name = "Exotic Fruit" },
            new Category { CategoryId = 4, Name = "Indigenous Fruit" },
            new Category { CategoryId = 5, Name = "All Season Fruit" }
        );

            // Seed Invoices
            context.Invoices.AddOrUpdate(i => i.InvoiceId,
                new Invoice
                {
                    InvoiceId = 1,
                    UserId = 2,
                    Bill = 99,
                    DeliveryCharge = 100.00m,
                    TotalBill = 199.00m,
                    Payment = "cash",
                    InvoiceDate = DateTime.Parse("2024-06-25T00:49:01.310"),
                    Status = 0
                },
                new Invoice
                {
                    InvoiceId = 2,
                    UserId = 13,
                    Bill = 190,
                    DeliveryCharge = 100.00m,
                    TotalBill = 290.00m,
                    Payment = "cash",
                    InvoiceDate = DateTime.Parse("2024-06-25T02:18:19.193"),
                    Status = 0
                }
            );

            // Seed Orders
            context.Orders.AddOrUpdate(o => o.OrderId,
                new Order
                {
                    OrderId = 1,
                    ProductId = 2,
                    Contact = "98541221",
                    Address = "Mirpur",
                    Unit = 99,
                    Qty = 1,
                    Total = 99,
                    OrderDate = DateTime.Parse("2024-06-25T00:49:01.483"),
                    InvoiceId = 1
                },
                new Order
                {
                    OrderId = 2,
                    ProductId = 6,
                    Contact = "0144",
                    Address = "Agargaon",
                    Unit = 190,
                    Qty = 1,
                    Total = 190,
                    OrderDate = DateTime.Parse("2024-06-25T02:18:19.210"),
                    InvoiceId = 2
                }
            );

            // Seed Photos
            context.Photos.AddOrUpdate(p => p.Id,
                new Photo
                {
                    Id = 1,
                    Title = "ProductPage",
                    Description = "This is Dynamic",
                    ImagePath = "~/Uploads/WhatsApp-Image-2022-04-16-at-3.02.00-AM.jpeg"
                },
                new Photo
                {
                    Id = 2,
                    Title = "HomePage2",
                    Description = "This is Dynamic",
                    ImagePath = "~/Uploads/a.jpg"
                },
                new Photo
                {
                    Id = 3,
                    Title = "SingleProduct",
                    Description = "This is Dynamic",
                    ImagePath = "~/Uploads/cover-for-website-1000x278.png"
                }
            );

            // Seed Products
            context.Products.AddOrUpdate(p => p.ProductId,
                new Product
                {
                    ProductId = 1,
                    Name = "Banana",
                    Description = "A Banana a day keeps the doctor away",
                    Unit = 10.00m,
                    Image = "Bananas-218094b-scaled.jpg",
                    CategoryId = 5,
                    Discount = 9.00m,
                    FinalRate = 9.10m,
                    Popularity = 22
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Alphonsos Mango",
                    Description = "Fruits are an excellent source of essential vitamins and minerals...",
                    Unit = 99.00m,
                    Image = "product6-300x300.jpg",
                    CategoryId = 1,
                    Discount = 9.00m,
                    FinalRate = 90.09m,
                    Popularity = 13
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Apple",
                    Description = "Fruits are an excellent source of essential vitamins and minerals...",
                    Unit = 160.00m,
                    Image = "product8-300x300.jpg",
                    CategoryId = 3,
                    Discount = 15.00m,
                    FinalRate = 136.00m,
                    Popularity = 11
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Avocado",
                    Description = "Fruits are an excellent source of essential vitamins and minerals...",
                    Unit = 250.00m,
                    Image = "product7-300x300.jpg",
                    CategoryId = 3,
                    Discount = 16.00m,
                    FinalRate = 210.00m,
                    Popularity = 2
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Grapes Black Globe",
                    Description = "Fruits are an excellent source of essential vitamins and minerals...",
                    Unit = 260.00m,
                    Image = "product13-300x300.jpg",
                    CategoryId = 3,
                    Discount = 19.00m,
                    FinalRate = 210.60m,
                    Popularity = 1
                },
                new Product
                {
                    ProductId = 6,
                    Name = "Grapes Green Globe",
                    Description = "Fruits are an excellent source of essential vitamins and minerals...",
                    Unit = 190.00m,
                    Image = "product20-300x300.jpg",
                    CategoryId = 3,
                    Discount = 35.00m,
                    FinalRate = 123.50m,
                    Popularity = 1
                },
                new Product
                {
                    ProductId = 7,
                    Name = "Grapes Red Globe",
                    Description = "Fruits are an excellent source of essential vitamins and minerals...",
                    Unit = 370.00m,
                    Image = "product11-300x300.jpg",
                    CategoryId = 2,
                    Discount = 34.00m,
                    FinalRate = 244.20m,
                    Popularity = 1
                },
                new Product
                {
                    ProductId = 8,
                    Name = "Green Apple",
                    Description = "Fruits are an excellent source of essential vitamins and minerals...",
                    Unit = 160.00m,
                    Image = "product9.jpg",
                    CategoryId = 2,
                    Discount = 9.00m,
                    FinalRate = 145.60m,
                    Popularity = 1
                },
                new Product
                {
                    ProductId = 9,
                    Name = "Kiwi",
                    Description = "Fruits are an excellent source of essential vitamins and minerals...",
                    Unit = 360.00m,
                    Image = "product5.jpg",
                    CategoryId = 3,
                    Discount = 14.00m,
                    FinalRate = 309.60m,
                    Popularity = 1
                },
                new Product
                {
                    ProductId = 10,
                    Name = "Mango (Deshi)",
                    Description = "Fruits are an excellent source of essential vitamins and minerals...",
                    Unit = 90.00m,
                    Image = "product21.jpg",
                    CategoryId = 1,
                    Discount = 14.00m,
                    FinalRate = 77.40m,
                    Popularity = 2
                }
            );

            // Seed Users
            context.Users.AddOrUpdate(u => u.UserId,
                new User
                {
                    UserId = 2,
                    FirstName = "Shefain",
                    LastName = "Ahmed",
                    Email = "shefain42@gmail.com",
                    Password = "123",
                    RoleType = 2,
                    PhoneNumber = "123-456-7890",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Address = "123 Main St, City, Country"
                },
                new User
                {
                    UserId = 3,
                    FirstName = "Monsour",
                    LastName = "Rahman",
                    Email = "monsour@gmail.com",
                    Password = "123",
                    RoleType = 2,
                    PhoneNumber = "123-456-7891",
                    DateOfBirth = new DateTime(1988, 2, 2),
                    Address = "456 Elm St, City, Country"
                },
                new User
                {
                    UserId = 4,
                    FirstName = "Ashik",
                    LastName = "Hossain",
                    Email = "ashik@gmail.com",
                    Password = "123",
                    RoleType = 2,
                    PhoneNumber = "123-456-7892",
                    DateOfBirth = new DateTime(1985, 3, 3),
                    Address = "789 Pine St, City, Country"
                },
                new User
                {
                    UserId = 5,
                    FirstName = "Rakib",
                    LastName = "Uddin",
                    Email = "rakib@gmail.com",
                    Password = "123",
                    RoleType = 2,
                    PhoneNumber = "123-456-7893",
                    DateOfBirth = new DateTime(1992, 4, 4),
                    Address = "101 Maple St, City, Country"
                },
                new User
                {
                    UserId = 6,
                    FirstName = "Rayhan",
                    LastName = "Khan",
                    Email = "rayhan@gmail.com",
                    Password = "123",
                    RoleType = 2,
                    PhoneNumber = "123-456-7894",
                    DateOfBirth = new DateTime(1987, 5, 5),
                    Address = "202 Oak St, City, Country"
                },
                new User
                {
                    UserId = 7,
                    FirstName = "Shohana",
                    LastName = "Begum",
                    Email = "sohana@gmail.com",
                    Password = "123",
                    RoleType = 2,
                    PhoneNumber = "123-456-7895",
                    DateOfBirth = new DateTime(1991, 6, 6),
                    Address = "303 Cedar St, City, Country"
                },
                new User
                {
                    UserId = 8,
                    FirstName = "Mohiuddin",
                    LastName = "Mahmud",
                    Email = "mohiuddin@gmail.com",
                    Password = "123",
                    RoleType = 2,
                    PhoneNumber = "123-456-7896",
                    DateOfBirth = new DateTime(1989, 7, 7),
                    Address = "404 Birch St, City, Country"
                },
                new User
                {
                    UserId = 9,
                    FirstName = "Shisir",
                    LastName = "Roy",
                    Email = "shisir@gmail.com",
                    Password = "123",
                    RoleType = 2,
                    PhoneNumber = "123-456-7897",
                    DateOfBirth = new DateTime(1986, 8, 8),
                    Address = "505 Spruce St, City, Country"
                },
                new User
                {
                    UserId = 10,
                    FirstName = "Mridul",
                    LastName = "Islam",
                    Email = "mridul@gmail.com",
                    Password = "123",
                    RoleType = 2,
                    PhoneNumber = "123-456-7898",
                    DateOfBirth = new DateTime(1993, 9, 9),
                    Address = "606 Willow St, City, Country"
                },
                new User
                {
                    UserId = 11,
                    FirstName = "Monir",
                    LastName = "Chowdhury",
                    Email = "monir@gmail.com",
                    Password = "123",
                    RoleType = 2,
                    PhoneNumber = "123-456-7899",
                    DateOfBirth = new DateTime(1984, 10, 10),
                    Address = "707 Ash St, City, Country"
                },
                new User
                {
                    UserId = 12,
                    FirstName = "Sapla",
                    LastName = "Nahar",
                    Email = "sapla@gmail.com",
                    Password = "123",
                    RoleType = 2,
                    PhoneNumber = "123-456-7800",
                    DateOfBirth = new DateTime(1990, 11, 11),
                    Address = "808 Chestnut St, City, Country"
                },
                new User
                {
                    UserId = 13,
                    FirstName = "Sorna",
                    LastName = "Akter",
                    Email = "sorna@gmail.com",
                    Password = "123",
                    RoleType = 2,
                    PhoneNumber = "123-456-7801",
                    DateOfBirth = new DateTime(1994, 12, 12),
                    Address = "909 Redwood St, City, Country"
                }
            );

        }
    }
}