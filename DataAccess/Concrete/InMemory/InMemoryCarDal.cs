using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=3,ModelYear=2011,DailyPrice=25000,Description="sıfır"},
                new Car{Id=2,BrandId=3,ColorId=4,ModelYear=2015,DailyPrice=80000,Description="ikinci el"},
                new Car{Id=3,BrandId=4,ColorId=4,ModelYear=2016,DailyPrice=120000,Description="sıfır"},
                new Car{Id=4,BrandId=6,ColorId=1,ModelYear=2012,DailyPrice=45000,Description="ikinci el"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(deleteCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.Id == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car updateCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updateCar.ColorId = car.ColorId;
            updateCar.BrandId = car.BrandId;
            updateCar.DailyPrice = car.DailyPrice;
            updateCar.Description = car.Description;
            updateCar.ModelYear = car.ModelYear;
            
        }
    }
    
}
