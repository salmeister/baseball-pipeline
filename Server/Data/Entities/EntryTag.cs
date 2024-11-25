
namespace BaseballPipeline.Server.Data.Entities
{
    public class EntryTag
    {
        public int EntryId { get; set; } 
        public int TagId { get; set; }

        public Entry? Entry { get; set; }
        public Tag? Tag { get; set; }
    }
}
