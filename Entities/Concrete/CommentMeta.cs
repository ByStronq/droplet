using Core.Entities;

namespace Entities.Concrete
{
    public class CommentMeta : Meta, IEntity
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
    }
}
