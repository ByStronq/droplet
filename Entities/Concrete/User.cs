using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Nicename { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Registered { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
