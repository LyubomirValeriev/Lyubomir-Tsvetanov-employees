using System.ComponentModel.DataAnnotations;

namespace SirmaTaskCal.Web.Models
{
    using Microsoft.AspNetCore.Http;

    public class FileFormModel
    {
        [Required]
        public IFormFile File { get; set; }
    }
}
