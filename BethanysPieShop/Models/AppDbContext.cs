using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCardItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit pies", CategoryDescription = "pies"});
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cheese cakes", CategoryDescription = "cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal pies", CategoryDescription = "pies" });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                Name = "Apple pie",
                Price = 13,
                ShortDescription = "Apple pie!",
                LongDescription = "Long Apple pie!!!",
                CategoryId = 1,
                ImageUrl = "https://icons.iconarchive.com/icons/treetog/junior/128/folder-blue-pictures-icon.png",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumnailUrl = "https://icons.iconarchive.com/icons/treetog/junior/128/folder-blue-pictures-icon.png",
                AllergyInformation = ""

            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                Name = "Cheese cake",
                Price = 19,
                ShortDescription = "Cheese cake!",
                LongDescription = "Long Cheese cake!!!",
                CategoryId = 2,
                ImageUrl = "https://icons.iconarchive.com/icons/babasse/old-school/128/dossier-ardoise-images-icon.png",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumnailUrl = "https://icons.iconarchive.com/icons/babasse/old-school/128/dossier-ardoise-images-icon.png",
                AllergyInformation = ""

            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 3,
                Name = "Strawberry pie",
                Price = 14,
                ShortDescription = "Strawberry pie!",
                LongDescription = "Long Strawberry pie!!!",
                CategoryId = 1,
                ImageUrl = "https://icons.iconarchive.com/icons/gartoon-team/gartoon-mimetype/128/image-x-lws-icon.png",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumnailUrl = "https://icons.iconarchive.com/icons/gartoon-team/gartoon-mimetype/128/image-x-lws-icon.png",
                AllergyInformation = ""

            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 4,
                Name = "Seasonal pie",
                Price = 14,
                ShortDescription = "Seasonal pie!",
                LongDescription = "Long Seasonal pie!!!",
                CategoryId = 3,
                ImageUrl = "https://icons.iconarchive.com/icons/hopstarter/scrap/128/Picture-PNG-icon.png",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumnailUrl = "https://icons.iconarchive.com/icons/hopstarter/scrap/128/Picture-PNG-icon.png",
                AllergyInformation = ""

            });
        }
    }
}
