using COMSPECSDATA;

namespace COMSPECSBUSINESS
{
    public class Userinfo
    {
        public bool VerifyUser(string Userid)
        {
            UserData data = new UserData();
            var result = data.GetUser(Userid);

            return result.Userid != null ? true : false;
        }
    }
}