using COMSPECSMODEL;
using COMSPECSDATA;
using COMSPECSBUSINESS;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ModelGetServices getServices = new ModelGetServices();

            var song = getServices.GetAllUsers();

            foreach (var item in song)
            {
                Console.WriteLine(item.Userid);
            }

        }
    }
}
