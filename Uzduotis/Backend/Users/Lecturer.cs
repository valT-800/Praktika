using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzduotis.Backend.Users;

namespace Uzduotis.Backend.Models
{
    class Lecturer:User
    {
        public List<Subject> Subjects { get; private set; }
        public Lecturer(int id, string name, string surname, string username, string password, DateTime birthDate)
            : base(id, name, surname, username, password, birthDate)
        {

        }
        public void SetSubjects(List<Subject> subjects)
        {
            Subjects = subjects;
        }

    }
}
