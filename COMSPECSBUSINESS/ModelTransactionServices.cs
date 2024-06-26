using COMSPECSDATA;
using COMSPECSMODEL;

namespace COMSPECSBUSINESS
{
    public class ModelTransactionServices
    {
        ModelValidationServices validationServices = new ModelValidationServices();
        CompData compData = new CompData();

        public bool CreateUser(User users)
        {
            bool result = false;

            if (validationServices.CheckIfUserExists(users.Userid))
            {
                result = compData.AddModel(users) > 0;
            }

            return result;
        }

        public bool CreateUser(string Userid)
        {
            User users = new User { Userid = Userid};

            return CreateUser(users);
        }

        public bool UpdateSongMap(User users)
        {
            bool result = false;

            if (validationServices.CheckIfUserExists(users.Userid))
            {
                result = compData.UpdateModel(users) > 0;
            }

            return result;
        }

        public bool UpdateModel(string Userid)
        {
            User users = new User { Userid = Userid};

            return UpdateModel(Userid);
        }

        public bool DeleteSongMap(User users)
        {
            bool result = false;

            if (validationServices.CheckIfUserExists(users.Userid))
            {
                result = compData.DeleteModel(users) > 0;
            }

            return result;
        }
    }
}