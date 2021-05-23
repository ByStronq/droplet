using Core.Entities;

namespace Entities.Concrete
{
    public class Term : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int Group { get; set; }
    }
}
