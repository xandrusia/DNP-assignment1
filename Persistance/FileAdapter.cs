using System.Collections.Generic;
using System.Linq;
using Assignment1.Models;

namespace Assignment1.Persistance
{
    //here will be all necessary checking for restricted access
    public class FileAdapter : IFileAdapter
    {
        private FileContext myFileContext = new FileContext();

        public void AddAdult(Adult a)
        {
            int max = myFileContext.Adults.Max(a => a.Id);
            //giving unique id
            a.Id = (++max);
            myFileContext.Adults.Add(a);
            myFileContext.SaveChanges();
        }

        public Adult FilterById(int id)
        {
            return (Adult)myFileContext.Adults.Where(p => p.Id == id);  
        }

        public IList<Adult> FilterByFirstName(string name)
        {
            return myFileContext.Adults.Where(p => p.FirstName == name).ToList();
        }
        
        public IList<Adult> FilterByLastName(string name)
        {
            return myFileContext.Adults.Where(p => p.LastName == name).ToList();
        }
        
        public IList<Adult> FilterByHairColor(string color)
        {
            return myFileContext.Adults.Where(p => p.HairColor == color).ToList();
        }
        
        public IList<Adult> FilterByEyeColor(string color)
        {
            return myFileContext.Adults.Where(p => p.EyeColor == color).ToList();
        }
        
        public IList<Adult> FilterByAge(int age)
        {
            return myFileContext.Adults.Where(p => p.Age == age).ToList();
        }
        
        public IList<Adult> FilterByAgeOlderThan(int age)
        {
            return myFileContext.Adults.Where(p => p.Age > age).ToList();
        }
        
        public IList<Adult> FilterByAgeYoungerThan(int age)
        {
            return myFileContext.Adults.Where(p => p.Age < age).ToList();
        }

        public IList<Adult> FilterBySex(char s)
        {
            return myFileContext.Adults.Where(p => char.Parse(p.Sex) == s).ToList();
        }
        
        public IList<Adult> FilterByJobTitle(string name)
        {
            return myFileContext.Adults.Where(p => p.JobTitle.JobTitle == name).ToList();
        }
        
        public IList<Adult> FilterBySalaryBiggerThan(int s)
        {
            return myFileContext.Adults.Where(p => p.JobTitle.Salary > s).ToList();
        }
        
        public IList<Adult> FilterBySalarySmallerThan(int s)
        {
            return myFileContext.Adults.Where(p => p.JobTitle.Salary < s).ToList();
        }
        
        public void RemovePerson(Person p)
        {
            myFileContext.Adults.RemoveAt(p.Id);
            myFileContext.SaveChanges();
        }

        public void RemoveLastPerson()
        {
            myFileContext.Adults.RemoveAt(myFileContext.Adults.Count-1);
            myFileContext.SaveChanges();
        }

        public void UpdateAdult(Adult p)
        {
            myFileContext.Adults.Insert(p.Id, p);
            myFileContext.SaveChanges();
        }

        public IList<Adult> GetAdults()
        {
            List<Adult> tmp = new List<Adult>(myFileContext.Adults);
            return tmp;
        }
    }
}