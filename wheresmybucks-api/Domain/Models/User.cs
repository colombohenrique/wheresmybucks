using Domain.Models.Base;
using System.Net;

namespace Domain.Models
{
    public class User : Entity
    {
        protected User(string name, string email)
        {
            Name = name;
            Email = email;
            IsActive = true;
        }

        public string Name { get; protected set; }
        public string Email { get; protected set; } 
        public bool IsActive { get; protected set; }
    }
}
