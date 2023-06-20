using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpacerPoBialymstoku.Data;
using SpacerPoBialymstoku.Interfaces;
using SpacerPoBialymstoku.Models;
using SpacerPoBialymstoku.Services;

namespace SpacerPoBialymstoku.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IFileUploadService _fileUploadService;
        private readonly IPlacesService _placesService;
        public string FilePath { get; set; }
        [BindProperty]
        public Place place { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IFileUploadService fileUploadService, IPlacesService placesService)
        {
            _logger = logger;

        }

        public IActionResult OnGet()
        {
            return Page();
        }
        public void OnPost()
        {
            
        }
    }
}