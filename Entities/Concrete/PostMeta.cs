using Core.Entities;

namespace Entities.Concrete
{
    public class PostMeta : Meta, IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
    }
}
