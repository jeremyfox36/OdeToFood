using System;
using System.Collections.Generic;
using System.Text;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData: IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name="Bob's Pizza", Cuisine=CuisineType.Italian, Location="Birmingham"},
                new Restaurant{Id = 2, Name="Cathy's Chips", Cuisine=CuisineType.None, Location="Edinburgh"},
                new Restaurant{Id = 3, Name="Phil's Curries", Cuisine=CuisineType.Indian, Location="Glasgow"},
                
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    } 
}
