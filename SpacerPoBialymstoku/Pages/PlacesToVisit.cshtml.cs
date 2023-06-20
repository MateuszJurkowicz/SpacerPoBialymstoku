using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpacerPoBialymstoku.Data;
using SpacerPoBialymstoku.Interfaces;
using SpacerPoBialymstoku.Models;
using SpacerPoBialymstoku.Services;

namespace SpacerPoBialymstoku.Pages
{
    public class PlacesToVisitModel : PageModel
    {
        private readonly ILogger<PlacesToVisitModel> _logger;
        public JsonFilePlaceService _jsonFilePlaceService;
        public IPlacesService _placesService { get; set; }
        public IEnumerable<Place> Places { get; set; }
        public IList<Place> PlacesFromDatabase { get; set; }
        public PlacesToVisitModel(ILogger<PlacesToVisitModel> logger, JsonFilePlaceService jsonFilePlaceService, IPlacesService placesService)
        {
            _logger = logger;
            _jsonFilePlaceService = jsonFilePlaceService;
            _placesService = placesService;
        }
        public void OnGet()
        {
            Places = _jsonFilePlaceService.GetPlaces();
            PlacesFromDatabase = _placesService.GetPlacesFromDatabase();
        }
    }
}
