using Core.Entities;

namespace Entities.Concrete
{
    public class TermRelationship : IEntity
    {
        public int Id { get; set; }
        public int TermTaxonomyId { get; set; }
        public int Order { get; set; }
    }
}
