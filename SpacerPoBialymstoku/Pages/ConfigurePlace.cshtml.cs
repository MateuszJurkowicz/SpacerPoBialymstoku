using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpacerPoBialymstoku.Interfaces;
using SpacerPoBialymstoku.Models;

namespace SpacerPoBialymstoku.Pages
{
[Authorize(Roles = "Admin")]
    public class ConfigurePlaceModel : PageModel
    {
        private readonly IPlacesService _placesService;
        [BindProperty]
        public Place place { get; set; }
        public ConfigurePlaceModel(ILogger<IndexModel> logger, IFileUploadService fileUploadService, IPlacesService placesService)
        {
            _placesService = placesService;
        }
        public IActionResult OnGet(int Id)
        {
            place = _placesService.GetPlaceFromDatabase(Id);
            return Page();
        }
        public IActionResult OnPost()
        {
            byte[] bytes = null;
            if (place.OldImageFile != null)
            {
                using (Stream fs = place.OldImageFile.OpenReadStream())
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        bytes = br.ReadBytes((Int32)fs.Length);
                    }
                }
                place.OldImageData = Convert.ToBase64String(bytes, 0, bytes.Length);
            }
            if (place.ActualImageFile != null)
            {
                using (Stream fs = place.ActualImageFile.OpenReadStream())
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        bytes = br.ReadBytes((Int32)fs.Length);
                    }
                }
                place.ActualImageData = Convert.ToBase64String(bytes, 0, bytes.Length);
            }
            _placesService.UpdatePlaceInDatabase(place);
            return RedirectToPage("./PlacesToVisit");
        }
    }
}
