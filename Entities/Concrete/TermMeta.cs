using Core.Entities;

namespace Entities.Concrete
{
    public class TermMeta : Meta, IEntity
    {
        public int Id { get; set; }
        public int TermId { get; set; }
    }
}
