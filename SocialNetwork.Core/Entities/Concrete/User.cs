using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialNetwork.Core.Entities;
using SocialNetwork.Core.Entities.Concrete;

namespace SocialNetwork.Core.Entities.Concrete
{
    public class User : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public string ProfilPhoto { get; set; }

        public DateTime BirthDay { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsBlocked { get; set; }

        public int FailedLogin { get; set; }

        public bool EmailConfirmed { get; set; }

        public List<UserRole> UserRoles { get; set; }
    }
}
