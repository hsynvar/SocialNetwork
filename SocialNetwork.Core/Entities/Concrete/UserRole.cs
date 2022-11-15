using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialNetwork.Core.Entities.Concrete;

namespace SocialNetwork.Core.Entities.Concrete
{
    public class UserRole : IEntity
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public Guid RoleId { get; set; }

        public Role Role { get; set; }
    }
}
