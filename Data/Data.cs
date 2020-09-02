using SprintZero.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SprintZero.Data
{
    public static class Data
    {
        public static List<Product> Products => allProducts;
        static List<Product> allProducts = new List<Product>()
    {
        new Product()
        {
            Id=1,
            Name="Vienna, Austria",
            Description="Vienna, is one the most beautiful cities in Austria and in Europe as well. Other than the Operas for which it is well known, Vienna also has many beautiful parks..."
        },      
        new Product()
        {
            Id=2,
            Name="Carpinteria, CA, USA",
            Description="Carpinteria is a city located on the central coast of California, just south of Santa Barbara. It has many beautiful beaches as well as a popular Avocado Festival which takes place every year in October..."
        },
        new Product()
        {
            Id=3,
            Name="San Francisco, CA, USA",
            Description="San Francisco is a metropolitan area located on the west coast of the United States. Some popular tourist features include the Golden Gate Bridge, Chinatown, and Fisherman's Wharf. There are a variety of popular food options..."
        },
        new Product()
        {
            Id=4,
            Name="Tucson, AZ, USA",
            Description="Tucson is a southwestern city in Arizona that is home to the University of Arizona. It was recently named a world gastronomy city, and is well known for its desert landscape and various bike races..."
        },
        new Product()
        {
            Id=5,
            Name="Albuquerque, NM, USA",
            Description="Albuquerque is a city located in New Mexico that is famous for its balloon festivals, picturesque views and references to TV shows."
        },
        new Product()
        {
            Id=7,
            Name="Munich, Germany",
            Description="Munich is an important city in Germany, located in the heart of Bavaria. It's famous for its traditional Oktoberfest annual festival, and many nice lakes and parks..."
        }
    };
    }
}
