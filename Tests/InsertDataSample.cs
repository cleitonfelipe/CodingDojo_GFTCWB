using System;
using Xunit;
using API.Model;
using API.Repository;

namespace Tests
{
    public class InsertDataSample
    
    {
        public Vehicle vehicle;
        public InsertRepository repository;

        [Fact]
        public void PassingTestInsert()
        {
            repository = new InsertRepository();
            vehicle = new Vehicle
            {
                newMpg = "Test",
                tradeMpg = "Test",
                newPpg = "Test",
                tradePpg = "Test",
                milesDriven = "123",
                milesDrivenTimeframe = "321",
                displayResult = true,
                dateModified = DateTime.Now,
                necessaryDataIsProvidedToCalculateSavings = true
            };        
            

            Assert.Equal("Criado", repository.Insert(vehicle));
        }
    }
}
