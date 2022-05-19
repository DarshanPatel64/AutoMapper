using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    internal class User
    {
        public int UserId { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
