using System;
using API.Model;
using MongoDB.Driver;

namespace API.Repository
{
    public class InsertRepository
    {
        public string Insert(Vehicle vehicle)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("CodingDojo");
            var collection = database.GetCollection<Vehicle>("Cars");
            
            var result = "";

            try
            {
                collection.InsertOne(vehicle);
                result = "Criado";
            }
            catch(Exception ex)
            {
                result = $"Error: {ex}";
            }

            return result;
        }
    }
}