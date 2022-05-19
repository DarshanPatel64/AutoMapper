using AutoMapper;
using ConsoleApp1.Data;

namespace ConsoleApp1
{
    public class ConsoleApp1
    {
        public static void Main()
        {
            
            User user = new User();
            user.Name = "Darshan";
            user.Address = "Gandhi Gate";
            user.Age = 21;
            user.CreatedDate = DateTime.Now;
            user.UserId = 11;
            var config = new MapperConfiguration(
             cfg =>
            {
                cfg.CreateMap<User,Student>()
                .ForMember(s => s.StudentId, u => u.MapFrom(u => u.UserId));
            });
            var mapper = new Mapper(config);
            Student std = mapper.Map<Student>(user);

            Console.WriteLine(std.StudentId);
            
           
        }

    }
}