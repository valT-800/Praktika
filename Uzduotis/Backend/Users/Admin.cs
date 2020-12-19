using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis.Backend.Users
{
    class Admin:User
    {
        public Admin(int id, string name, string surname, string username, string password, DateTime birthDate)
            : base(id, name, surname, username, password, birthDate)
        {

        }
    }
}
