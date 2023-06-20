using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpacerPoBialymstoku.Interfaces;
using SpacerPoBialymstoku.Models;

namespace SpacerPoBialymstoku.Pages
{
    public class AddNewPlaceModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IFileUploadService _fileUploadService;
        private readonly IPlacesService _placesService;
        public string FilePath { get; set; }
        [BindProperty]
        public Place place { get; set; }
        public AddNewPlaceModel(ILogger<IndexModel> logger, IFileUploadService fileUploadService, IPlacesService placesService)
        {
            _logger = logger;
            _fileUploadService = fileUploadService;
            _placesService = placesService;
        }

        public IActionResult OnGet()
        {
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
            _placesService.SavePlace(place);
            return RedirectToPage("./PlacesToVisit");
            /* if (file != null)  
             {
                 FilePath = await _fileUploadService.UploadFileAsync(file);
             }*/
        }
    }
}
