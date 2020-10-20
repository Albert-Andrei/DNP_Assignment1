using System.Collections.Generic;
using Assignment.Model;

namespace Assignment.Data
{
    public interface IAdultService
    {
        void SaveChanges();
        IList<Adult> GetAdults();
        void AddAdult(Adult person);
        void RemoveAdult(int personId);
        void Update(Adult person);
    }
}