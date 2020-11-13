using Microsoft.EntityFrameworkCore;
using px_m2_nguyenthanhdat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace px_m2_nguyenthanhdat.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Fantasy" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Adventure" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Romance" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 4, CategoryName = "Mystery" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 5, CategoryName = "Horror" });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1, 
                ImageUrl = "https://i.imgur.com/4TlVQX1.jpg",
                Name = "How to be a Bawse",
                Author = "Đẹt",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Lorem Ipsum has been the book.", 
                YearReleased = 2000,
                Stock=500, 
                CategoryId=1
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 2,
                ImageUrl = "https://i.imgur.com/S7yeWSZ.jpg",
                Name = "Keepers of the kalachakara",
                Author = "Đẹt",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Lorem Ipsum has been the book.",
                YearReleased = 2000,
                Stock = 500,
                CategoryId = 2
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 3,
                ImageUrl = "https://i.imgur.com/DljpL5t.jpg",
                Name = "Zero Sum",
                Author = "Đẹt",
                Description = "Bla bla bla bla",
                YearReleased = 2000,
                Stock = 500,
                CategoryId = 3
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 4,
                ImageUrl = "https://i.imgur.com/3mTNfXC.jpg",
                Name = "Harry Porter",
                Author = "Đẹt",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Lorem Ipsum has been the book.",
                YearReleased = 2000,
                Stock = 500,
                CategoryId = 4
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 5,
                ImageUrl = "https://i.imgur.com/Ck6vqFT.jpg",
                Name = "PS From Paris",
                Author = "Đạt",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Lorem Ipsum has been the book.",
                YearReleased = 2000,
                Stock = 500,
                CategoryId = 5
            });
        }
    }
}
