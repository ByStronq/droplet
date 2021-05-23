using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public int AuthorId { get; set; }
        public int ParentId { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string PostPassword { get; set; }
        public string PostName { get; set; }
        public string PostStatus { get; set; }
        public string CommentStatus { get; set; }
        public string PingStatus { get; set; }
        public string ToPing { get; set; }
        public string Pinged { get; set; }
        public string ContentFiltered { get; set; }
        public int MenuOrder { get; set; }
        public DateTime Modified { get; set; }
    }
}
