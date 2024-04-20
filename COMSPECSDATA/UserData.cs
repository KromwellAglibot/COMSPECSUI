using COMSPECSMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSPECSDATA
{
    public class UserData
    {
        List<User> userdata = new List<User>();
        public UserData()
        {
            CreateUserData();
        }
        private void CreateUserData()
        {
            User user1 = new User
            {
                Userid = "Asus",
            };
            userdata.Add(user1);

            User user2 = new User
            {
                Userid = "Alienware",
            };
            userdata.Add(user2);
        }
        public User GetUser(string Userid)
        {
            User foundUser = new User();
            foreach (var user in userdata)
            {
                if (Userid == user.Userid)
                {
                    foundUser = user;
                }
            }
            return foundUser;
        }

    }
}