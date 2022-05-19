using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    internal class User
    {
        public int usrUserId { get; set; } 
        public string usrName { get; set; }
        public int usrAge { get; set; }
        public string usrAddress { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
