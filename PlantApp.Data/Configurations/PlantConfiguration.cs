using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlantApp.Domain;

namespace PlantApp.Data.Configurations
{
    class PlantConfiguration : IEntityTypeConfiguration<Plant>
    {
        public void Configure(EntityTypeBuilder<Plant> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
