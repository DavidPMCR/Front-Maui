using MauiAppMovil.Services;

namespace MauiAppMovil.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Schedule { get; set; } = string.Empty;
        public string Professor { get; set; } = string.Empty;
        public string ImageUrl { get; set; }
        public string FullImageUrl => $"{AppConstants.BaseUrl}{ImageUrl ?? ""}";

    }
}
