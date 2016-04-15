using Microsoft.AspNetCore.Http;

namespace HelloMvc.Models
{
    public class SomeDataModel
    {
        public string Text { get; set; }
        public IFormFile File { get; set; }
    }
}