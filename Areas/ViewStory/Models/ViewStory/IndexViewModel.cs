using Microsoft.AspNetCore.Mvc.Rendering;
using truyenchu.Models;

namespace truyenchu.Area.ViewStory.Model 
{
    public class IndexViewModel
    {
        public List<ReadingStory> ReadingStories { get; set; } 
        public SelectList SelectListItems { get; set; }
    }
}