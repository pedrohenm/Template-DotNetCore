using System.Collections.Generic;
using Template.Data.Context;
using Template.Domain.Entities;
using Template.Domain.Interfaces;

namespace Template.Data.Repositories
{
    public class UserRepository : 
        Repository<User>,
        IUserRepository
    {
        public UserRepository(TemplateContext context)
            : base(context) { }

        public IEnumerable<User> GetAll()
        {
            return Query(user => !user.IsDeleted);
        }
    }
}
