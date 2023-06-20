using SpacerPoBialymstoku.Models;
using System.Text.Json;


namespace SpacerPoBialymstoku.Services
{
    public class JsonFilePlaceService
    {
        public IWebHostEnvironment _environment { get; set; }

        public JsonFilePlaceService(IWebHostEnvironment environment) 
        {
            _environment = environment;
        }
        private string JsonFileName
        {
            get { return Path.Combine(_environment.WebRootPath, "data", "places.json"); }
        }
        public IEnumerable <Place> GetPlaces()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Place[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
