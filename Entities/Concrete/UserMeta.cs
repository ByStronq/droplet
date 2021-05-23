using Core.Entities;

namespace Entities.Concrete
{
    public class UserMeta : Meta, IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
