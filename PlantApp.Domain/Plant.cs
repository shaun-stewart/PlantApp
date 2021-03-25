using System.Collections.Generic;

namespace PlantApp.Domain
{

 
    public class Plant
    {
        public int Id { get; set; }
        public string CommonName { get; set; }
        public List<PlantType> PlantTypes { get; set; } = new List<PlantType>();


        //public string BotanicalName { get; set; }
        //public string Family { get; set; }
        //public string Description { get; set; }
        //public float UltimateHeight { get; set; }
        //public float UltimateWidth { get; set; }
        //public string TimeToUltimateHeight { get; set; }
        //public Colour FoliageColour { get; set; }
        //public Colour FlowerColour { get; set; }
        //public Colour FruitColour { get; set; }
        //public List<SoilType> SoilTypes { get; set; } = new List<SoilType>();
        //public List<SunExposure> SunExposures { get; set; } = new List<SunExposure>();
        //public Hardiness Hardiness { get; set; }
        //public List<ToxicTo> ToxicTo { get; set; } = new List<ToxicTo>();


    }
}
