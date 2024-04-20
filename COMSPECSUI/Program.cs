using COMSPECSBUSINESS;
using COMSPECSDATA;
using COMSPECSMODEL;

namespace COMSPECSUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Desired Computer: ");
            string Userid = Console.ReadLine();


            UserData userdataservice = new UserData();
            User user = userdataservice.GetUser(Userid);

            if (user.Userid == "Asus")
            {
                User Asus = new User();
                Console.WriteLine("Brand: Asus");
                Console.WriteLine("Motherboad: ATX");
                Console.WriteLine("Processor: AMD Ryzen 9");
                Console.WriteLine("Ram: DDR4 32GB");
                Console.WriteLine("Storage: SSD 1TB");
                Console.WriteLine("Gpu: RTX 3090");
            }
            else if (user.Userid == "Alienware")
            {
                User Alienware = new User();
                Console.WriteLine("Brand: ALIENWARE AURORA R12");
                Console.WriteLine("Motherboad: ALIENWARE");
                Console.WriteLine("Processor: INTEL CORE i9");
                Console.WriteLine("Ram: DDR5 64GB");
                Console.WriteLine("Storage: PCIe NVMe SSD 2TB");
                Console.WriteLine("Gpu: NVIDIA GeForce RTX 3090");
            }
            else
            {
                Console.WriteLine("Computer Not Found");
            }
        }
    }
}