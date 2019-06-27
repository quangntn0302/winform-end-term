using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class CityBUS
    {
        QLNVDataContext CTB = new QLNVDataContext();
        public IEnumerable<City> GetAllCity()
        {
            IEnumerable<City> city = (from ct in CTB.Cities
                                      select ct);
            return city;
        }
        public bool CheckCitytExits(string citycode)
        {
            int city = (from ct in CTB.Cities
                        where ct.CityCode == citycode
                        select ct).Count();
            if (city == 1)
                return false;
            else
                return true;
        }
        public void AddCity(string citycode, string cityname)
        {
            City city = new City();
            city.CityCode = citycode;
            city.NameCity = cityname;
            CTB.Cities.InsertOnSubmit(city);
            CTB.SubmitChanges();
        }
        public void EditCity(string citycode, string cityname)
        {
            City city = (from ac in CTB.Cities
                         select ac).Single(a => a.CityCode == citycode);
            city.CityCode = citycode;
            city.NameCity = cityname;
            CTB.SubmitChanges();
        }
        public void DeleteCity(string citycode)
        {
            City city = (from ac in CTB.Cities
                         select ac).Single(a => a.CityCode == citycode);
            CTB.Cities.DeleteOnSubmit(city);
            CTB.SubmitChanges();
        }
    }
}
