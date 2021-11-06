using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Data.Models;


namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car{
                        Name = "Tesla Model S",
                        ShortDescription = "Быстрый автомобиль",
                        LongDescription = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Img= "/img/tesla.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()},
                    new Car
                    {
                        Name = "Ford Fiesta",
                        ShortDescription = "Тихий и спокойный",
                        LongDescription = "Удобный автомобиль для городской жизни",
                        Img= "/img/ford.jpg",
                        Price = 11000,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car
                    {
                        Name = "BMW M3",
                        ShortDescription = "Дерзкий и стильный",
                        LongDescription = "Удобный автомобиль для городской жизни",
                        Img= "/img/bmw.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car
                    {
                        Name = "Mercedes C class",
                        ShortDescription = "Уютный и большой",
                        LongDescription = "Удобный автомобиль для городской жизни",
                        Img= "/img/merc.jpg",
                        Price = 40000,
                        IsFavourite = false,
                        Available = false,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car
                    {
                        Name = "Nissan Leaf",
                        ShortDescription = "Бесшумный и экономный",
                        LongDescription = "Удобный автомобиль для городской жизни",
                        Img= "/img/nissan.jpg",
                        Price = 14000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()}
                    };
            }
        }

        public IEnumerable<Car> GetFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
        
    


