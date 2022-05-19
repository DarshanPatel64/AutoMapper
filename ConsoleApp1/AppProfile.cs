using AutoMapper;
using ConsoleApp1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AppProfile: Profile
    {
        public AppProfile()
        {
            RecognizePrefixes("usr");
            CreateMap<User, Student>()
                .ForMember(s => s.StudentId, u => u.MapFrom(u => u.usrUserId));
        }
    }
}
