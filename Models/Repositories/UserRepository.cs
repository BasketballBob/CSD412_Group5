using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment.Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext context;

        public UserRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public User GetUser(Guid Id)
        {
            return context.Users.Find(Id);
        }

        public User AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();

            return user;
        }

        public User UpdateUser(User userChanges)
        {
            var user = context.Users.Attach(userChanges);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return userChanges;
        }

        public void DeleteUser(User userToDelete)
        {
            context.Users.Remove(userToDelete);
            context.SaveChanges();
        }
    }
}
