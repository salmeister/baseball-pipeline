using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BaseballPipeline.Shared.Models
{
    public class EntryModel
    {
        public int EntryId { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Description { get; set; }
        [Required]
        [DisplayName("Post ID")]
        public string? TweetID { get; set; }
        [Required]
        public string? Handle { get; set; }
        [Required]
        public int Height { get; set; }
        [DisplayName("Date Added")]
        public DateTime DateAdded { get; set; }
        [DefaultValue(false)]
        public bool Unavailable { get; set; }
        public List<MultipleSelectorModel>? Tags { get; set; }
        public List<int>? ExistingTags { get; set; }
    }
}
