using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlantApp.Data;
using PlantApp.Domain;

namespace PlantApp.Test
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void CanInsertPlantIntoDatabase()
        {
            using(var context=new PlantContext("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PlantTestData", false))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                var plant = new Plant();
                context.Plants.Add(plant);
                context.SaveChanges();

                Assert.AreNotEqual(0, plant.Id);
            }
        }
    }
}
