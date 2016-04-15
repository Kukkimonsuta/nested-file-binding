using Microsoft.AspNetCore.Http;

namespace HelloMvc.Models
{
    public class HomeIndexModel
    {
        public string Text { get; set; }
        public IFormFile File { get; set; }
        
        public SomeDataModel Data { get; set; }
    }
}