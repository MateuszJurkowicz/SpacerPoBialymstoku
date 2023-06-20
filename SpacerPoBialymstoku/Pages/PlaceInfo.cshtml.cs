using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpacerPoBialymstoku.Interfaces;
using SpacerPoBialymstoku.Models;

namespace SpacerPoBialymstoku.Pages
{
    public class PlaceInfoModel : PageModel
    {
        public Place _place { get; set; }
        public IPlacesService _placesService { get; set; }
        public PlaceInfoModel(IPlacesService placesService)
        {
            _placesService = placesService;
        }
        public IActionResult OnPost(Place place)
        {
            _placesService.DeletePlaceFromDatabase(place);
            return RedirectToPage("/PlacesToVisit");
        }
        public IActionResult OnGet(int Id)
        {
            _place = _placesService.GetPlaceFromDatabase(Id);
            return Page();
        }
    }
}
