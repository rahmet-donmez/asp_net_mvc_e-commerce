using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserMan: IUserService
    {
        IUser ıuser;
        public UserMan(IUser ı_user)
        {
            ıuser = ı_user;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> ListAll()
        {
            throw new NotImplementedException();
        }

        public void TAdd(User t)
        {
            ıuser.Insert(t);
        }

        public void TDelete(User t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(User t)
        {
            throw new NotImplementedException();
        }

        
    }
}
