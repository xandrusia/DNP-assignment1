using System.Collections.Generic;
using Assignment1.Models;

namespace Assignment1.Persistance
{
    public interface IFileAdapter
    {
        public void AddAdult(Adult a);
        public Adult FilterById(int id);
        public IList<Adult> FilterByFirstName(string name);
        public IList<Adult> FilterByLastName(string name);
        public IList<Adult> FilterByHairColor(string color);
        public IList<Adult> FilterByEyeColor(string color);
        public IList<Adult> FilterByAge(int age);
        public IList<Adult> FilterByAgeOlderThan(int age);
        public IList<Adult> FilterByAgeYoungerThan(int age);
        public IList<Adult> FilterBySex(char s);
        public IList<Adult> FilterByJobTitle(string name);
        public IList<Adult> FilterBySalaryBiggerThan(int s);
        public IList<Adult> FilterBySalarySmallerThan(int s);
        public void RemovePerson(Person p);
        public void RemoveLastPerson();
        public void UpdateAdult(Adult p);
        public IList<Adult> GetAdults();

    }
}