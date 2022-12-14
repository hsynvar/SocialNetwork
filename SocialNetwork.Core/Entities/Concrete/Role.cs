using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialNetwork.Core.Entities.Concrete;

namespace SocialNetwork.Core.Entities.Concrete
{
    public class Role : IEntity
    {
        public Guid Id { get; set; }

        public string RoleName { get; set; }

        public List<UserRole> UserRoles { get; set; }
    }
}
