
namespace BaseballPipeline.Server.Data.Entities
{
    public class Tag
    {
        public int TagId { get; set; }
        public string? Value { get; set; }

        public virtual ICollection<EntryTag>? EntryTags { get; set; }

    }
}
