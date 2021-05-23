using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Link : IEntity
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Target { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public DateTime Updated { get; set; }
        public string Rel { get; set; }
        public string Notes { get; set; }
        public string Rss { get; set; }
        public bool Visible { get; set; }
    }
}
