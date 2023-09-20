using LearningWebAPI.Models;

namespace LearningWebAPI
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities {get; set;}
        public static CitiesDataStore Current {get;} = new CitiesDataStore();
        public CitiesDataStore(){
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "The one big city"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Dhaka",
                    Description = "The one big city"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Delhi",
                    Description = "The one big city"
                },
                new CityDto()
                {
                    Id = 4,
                    Name = "Qualalumpur",
                    Description = "The one big city"
                }
            };
        }
    }
}