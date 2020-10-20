using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Assignment.Model;
using Assignment.Persistence;

namespace Assignment.Data
{
    public class AdultService : IAdultService
    {
        private string adultFile = "Json/adults.json";
        private FileContext context;
        private IList<Adult> adults;

        public AdultService()
        {
         
            context = new FileContext();
            adults = context.Adults;
        }
        
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public void WriteToFile()
        {
            string productsAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(adultFile, productsAsJson);
        }

        public IList<Adult> GetAdults()
        {
            List<Adult> tmp = new List<Adult>(adults);
            return tmp;
        }

        public void AddAdult(Adult person)
        {
            int max = adults.Max(person => person.Id);
            person.Id = (++max);
            adults.Add(person);
            // WriteToFile();
            SaveChanges();
        }

        public void RemoveAdult(int personId)
        {
            Adult toRemove = adults.First(t => t.Id == personId);
            adults.Remove(toRemove);
            WriteToFile();
        }

        public void Update(Adult person)
        {
            Adult toUpdate = adults.First(t => t.Id == person.Id);
            toUpdate.Update(person);
            WriteToFile();
        }
    }
}