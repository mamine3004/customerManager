using corelayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceLayer
{
    public interface IUser
    {
        int addUser(User user);
        List<User> findAll();
        User findById(int id);
        User findByName(string name);
    }
}
