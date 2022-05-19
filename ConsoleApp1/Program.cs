using AutoMapper;
using ConsoleApp1.Data;

namespace ConsoleApp1
{
    public class ConsoleApp1
    {
        public static void Main()
        {
            
            User user = new User();
            user.usrName = "Darshan";
            user.usrAddress = "Gandhi Gate";
            user.usrAge = 21;
            user.CreatedDate = DateTime.Now;
            user.usrUserId = 11;

            var config = new MapperConfiguration(
                cfg => { cfg.AddProfile<AppProfile>(); }
            );
            var mapper = new Mapper(config);
           
            Student std = mapper.Map<Student>(user);

            Console.WriteLine(std.StudentId);
            
           
        }

    }
}