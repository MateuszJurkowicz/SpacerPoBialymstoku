using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpacerPoBialymstoku.Interfaces;
using SpacerPoBialymstoku.Models;

namespace SpacerPoBialymstoku.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IFileUploadService _fileUploadService;
        public string FilePath { get; set; }
        public Place place { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IFileUploadService fileUploadService)
        {
            _logger = logger;
            _fileUploadService = fileUploadService;
        }

        public void OnGet()
        {

        }
        public async void OnPost(IFormFile file)
        {
            if (file != null)  
            {
                FilePath = await _fileUploadService.UploadFileAsync(file);
            }
        }
    }
}