using System.Collections.Generic;

namespace PlantApp.Domain
{
    public class PlantType
    {
        public int PlantTypeId { get; set; }
        public string Name { get; set; }
        public List<Plant> Plants { get; set; } = new List<Plant>();
    }
}
