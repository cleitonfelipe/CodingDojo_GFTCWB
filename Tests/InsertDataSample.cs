using System;
using Xunit;
using API.Model;

namespace Tests
{
    public class InsertDataSample
    
    {
        public Vehicle vehicle;

        [Fact]
        public void PassingTestInsert()
        {
            Assert.Equal("Criado", Insert("abc-9898", "carro", "newoppg", "tradeoog", "123", "321", true,  DateTime.Now, true));
        }

        [Fact]
        public void FailingTestInsert()
        {
            Assert.NotEqual("Nao Criado", Insert("", "", "", "", "", "", true, DateTime.Now, true));
        }

        string Insert(string newMpg, string tradeMpg, string newPpg, string tradePpg, string milesDriven, 
        string milesDrivenTimeframe, bool displayResult, DateTime dateModified, bool necessaryDataIsProvidedToCalculateSavings)
        {
            vehicle = new Vehicle();
            vehicle.newMpg = newMpg;
            vehicle.tradeMpg = tradeMpg;
            vehicle.newPpg = newPpg;
            vehicle.tradePpg = tradePpg;
            vehicle.milesDriven = milesDriven;
            vehicle.milesDrivenTimeframe = milesDrivenTimeframe;
            vehicle.displayResult = displayResult;
            vehicle.dateModified = dateModified;
            vehicle.necessaryDataIsProvidedToCalculateSavings = necessaryDataIsProvidedToCalculateSavings;



            return "Criado";
        }
    }
}
