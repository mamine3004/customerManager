using corelayer;
using datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceLayer
{
    public class UserServise : IUser
    {
        UserContext _context;

        public UserServise(UserContext context)
        {
            _context = context;
        }

        public int addUser(User user)
        {
            _context.Users.Add(user);
            int nb = _context.SaveChanges();
            return nb;
        }

        public List<User> findAll()
        {
            return _context.Users.ToList();
        }

        public User findById(int id)
        {
            User u  = _context.Users.Find(id);
            return u;
        }

        public User findByName(string name)
        {
            return null;
        }
    }
}
