using System;

namespace Uzduotis.Backend.Users
{
    public class User
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public DateTime BirthDate { get; private set; }

        public User(int id, string name, string surname, string username, string password, DateTime birthDate)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            BirthDate = birthDate;
        }
    }
}
