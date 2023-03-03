```csharp
void Main()
{
    List<LocationModel> locationList = new List<LocationModel>
    {
    new LocationModel() { LocationId = 01, City = "Lisboa", Country = "Portugal", Lat = 38.736946D, Long = -9.142685D },
    new LocationModel() { LocationId = 02, City = "Porto", Country = "Portugal", Lat = 41.14961D, Long = -8.61099D },
    new LocationModel() { LocationId = 03, City = "Evora", Country = "Portugal", Lat = 38.34001D, Long = -7.54000D }
    };

    List<LocationTemperatureModel> temperatureList = new List<LocationTemperatureModel>
    {
    new LocationTemperatureModel(){ LocationId = 1, Date = DateTime.Now, Temperature = 15, Summary = "sun"},
    new LocationTemperatureModel(){ LocationId = 2, Date = DateTime.Now, Temperature = 11, Summary = "rain"}
    };


    var viewModels = (from l in locationList
                            join t in temperatureList
                                on l.LocationId equals t.LocationId into locations
                            from loc in locations.DefaultIfEmpty()
                            select new LocationViewModel()
                            {
                                City = l.City,
                                Country = l.Country,
                                Lat = l.Lat,
                                Long = l.Long,
                                Date = (loc.Date != null ? loc.Date : DateTime.Now),
                                Temperature = (loc.Temperature != null ? loc.Temperature : 0),
                                Summary = (loc.Summary != null ? loc.Summary : "Data Not available") 
                            }).ToList();


    foreach(var x in viewModels)
    {
    Console.WriteLine(x);
    }
}

// You can define other methods, fields, classes and namespaces here
public class LocationModel
{
    public int LocationId { get; set; }
    public string City { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public double? Long { get; set; }        
    public double? Lat { get; set; }

    public LocationModel(){}

}

public class LocationViewModel
{
    public string City { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public double? Long { get; set; }
    public double? Lat { get; set; }
    public DateTime? Date { get; set; }
    public double? Temperature { get; set; }
    public string Summary { get; set; } = string.Empty;


    public LocationViewModel(){}
}


public class LocationTemperatureModel 
{
    public int LocationId { get; set; }
    public DateTime? Date { get; set; }
    public double? Temperature { get; set; }
    public string Summary { get; set; } = string.Empty;

    public LocationTemperatureModel(){}
}
```
