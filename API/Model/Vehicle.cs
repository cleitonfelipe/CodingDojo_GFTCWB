using System;
namespace API.Model
{
    public class Vehicle
    {
        
        public string newMpg { get; set; }
        public string tradeMpg { get; set; }
        public string newPpg { get; set; }
        public string tradePpg { get; set; }
        public string milesDriven { get; set; }
        public string milesDrivenTimeframe { get; set; }
        public bool displayResult { get; set; }
        public DateTime dateModified { get; set; }
        public bool necessaryDataIsProvidedToCalculateSavings { get; set; }
    }
}