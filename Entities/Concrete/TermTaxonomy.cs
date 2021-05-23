using Core.Entities;

namespace Entities.Concrete
{
    public class TermTaxonomy : IEntity
    {
        public int Id { get; set; }
        public int TermId { get; set; }
        public int ParentId { get; set; }
        public string Taxonomy { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
    }
}
