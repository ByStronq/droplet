using Core.Entities;

namespace Entities.Concrete
{
    public class Option : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Autoload { get; set; }
    }
}
