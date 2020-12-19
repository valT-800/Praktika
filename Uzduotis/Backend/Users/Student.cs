using System;
using System.Collections.Generic;
using Uzduotis.Backend.Users;

namespace Uzduotis.Backend.Models
{
    public class Student:User
    {
		public Student(int id, string name, string surname, string username, string password, DateTime birthDate)
			:base(id, name, surname, username, password, birthDate)
		{

		}
	}
}
