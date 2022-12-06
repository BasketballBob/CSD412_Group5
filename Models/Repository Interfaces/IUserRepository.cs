using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment.Models.Repositories
{
    public interface IUserRepository
    {
        User AddUser(User user);
        User GetUser(Guid Id);
        User UpdateUser(User userChanges);
        void DeleteUser(User user);
    }
}
