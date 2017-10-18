using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B4.Entity;

namespace B4.Data
{
    public class UserDao
    {
        Bai4TTNEntities db = null;
        public UserDao()
        {
            db = new Bai4TTNEntities();
        }
        public User GetById(String userName)
        {
            return db.Users.SingleOrDefault(x => x.Name == userName);
        }
        public int Login(string userName, string passWord)
        {
            var result = db.Users.SingleOrDefault(x => x.Name == userName);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.Pass == passWord)
                    return 1;
                else
                    return -2;
            }
        }
    }
}
