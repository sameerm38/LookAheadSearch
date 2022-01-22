using AutoMapper;
using LookAheadSearch.Web.Db;
using LookAheadSearch.Web.Implementations;
using LookAheadSearch.Web.Profile;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LookAheadSearch.Tests
{
    public class ProductTest
    {
        [Fact]
        public async Task FindProductSuccess()
        {
            //Arrange
            DbContextOptions options = new DbContextOptionsBuilder()
                .UseInMemoryDatabase("FindProductSuccess")
                .Options;
            var dbContext = new LASDbContext(options);
            CreateProducts(dbContext);
            var dTOProfile = new Profiler();
            var config = new MapperConfiguration(cfg => cfg.AddProfile(dTOProfile));
            var mapper = config.CreateMapper();
            var productService = new ProductService(dbContext, mapper);
            //Act
            var searchResult =await productService.SearchByName("Ac");
            //Assert
            Assert.True(searchResult.IsSuccess);
            Assert.True(searchResult.Products.Any());
            Assert.Null(searchResult.ErrorMessage);

        }
        [Fact]
        public async Task FindProductFailure()
        {
            //Arrange
            DbContextOptions options = new DbContextOptionsBuilder()
                .UseInMemoryDatabase("FindProductFailure")
                .Options;
            var dbContext = new LASDbContext(options);
            CreateProducts(dbContext);
            var dTOProfile = new Profiler();
            var config = new MapperConfiguration(cfg => cfg.AddProfile(dTOProfile));
            var mapper = config.CreateMapper();
            var productService = new ProductService(dbContext, mapper);
            //Act
            var searchResult = await productService.SearchByName("sameer");
            //Assert
            Assert.False(searchResult.IsSuccess);
            Assert.Null(searchResult.Products);
            Assert.NotNull(searchResult.ErrorMessage);

        }

        private void CreateProducts(LASDbContext dbContext)
        {
            dbContext.Products.Add(new Product { Id = 1, Category = "General Medicine", Name = "8X Shampoo", Molecule = "Ciclopirox + Zinc pyrithione", HyperLink = "https://www.ciplamed.com/content/8x-shampoo" });
            dbContext.Products.Add(new Product { Id = 2, Category = "General Medicine", Name = "ABAMUNE Tablets", Molecule = "Abacavir sulfate", HyperLink = "https://www.ciplamed.com/content/abamune-tablets" });
            dbContext.Products.Add(new Product { Id = 3, Category = "General Medicine", Name = "ABAMUNE-L Tablets", Molecule = "Abacavir sulfate + Lamivudine", HyperLink = "https://www.ciplamed.com/content/abamune-l-tablets" });
            dbContext.Products.Add(new Product { Id = 4, Category = "General Medicine", Name = "ACIVIR Cream", Molecule = "Aciclovir", HyperLink = "https://www.ciplamed.com/content/acivir-cream" });
            dbContext.Products.Add(new Product { Id = 5, Category = "General Medicine", Name = "ACIVIR Eye Ointment", Molecule = "Acyclovir 3%", HyperLink = "https://www.ciplamed.com/content/acivir-eye-ointment" });
            dbContext.Products.Add(new Product { Id = 6, Category = "General Medicine", Name = "ACIVIR DT Tablets", Molecule = "Aciclovir", HyperLink = "https://www.ciplamed.com/content/acivir-dt-tablets" });
            dbContext.Products.Add(new Product { Id = 7, Category = "General Medicine", Name = "ACIVIR I.V. Injection", Molecule = "Aciclovir", HyperLink = "https://www.ciplamed.com/content/acivir-iv-injection" });
            dbContext.Products.Add(new Product { Id = 8, Category = "General Medicine", Name = "ACNEDAP Gel", Molecule = "Dapsone", HyperLink = "https://www.ciplamed.com/content/acnedap-gel" });
            dbContext.SaveChanges();
        }
    }
}
