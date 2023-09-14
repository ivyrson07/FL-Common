namespace FL.Common.Models
{
    public class Comment
    {
        public Guid Id { get; set; }

        public Guid PostId { get; set; }

        public string? Description { get; set; }

        public List<Reaction>? Reactions { get; set; }
    }
}
