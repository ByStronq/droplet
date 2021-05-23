using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int ParentId { get; set; }
        public string Author { get; set; }
        public string AuthorEmail { get; set; }
        public string AuthorUrl { get; set; }
        public string AuthorIP { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public int Karma { get; set; }
        public string Approved { get; set; }
        public string Agent { get; set; }
    }
}
