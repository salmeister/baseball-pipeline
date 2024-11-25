namespace BaseballPipeline.Server.Data.Entities
{
    public class Entry
    {
        public int EntryId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? TweetID { get; set; }
        public string? Handle { get; set; }
        public int Height { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Unavailable { get; set; }

        public virtual ICollection<EntryTag>? EntryTags { get; set; }
    }
}
