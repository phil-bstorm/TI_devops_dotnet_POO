using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.demo02notionclass.Models
{
    internal class Person
    {
        public string Email { get; set; }
        public int Age { get; init; }
        private string _Password;

        public string Password
        {
            get
            {
                //return _Password;
                return new string('*', _Password.Length); // "Test" deviendra "****"
            }
        }

        public Person(string email, string password, int age)
        {
            Email = email;
            _Password = password;
            Age = age;
        }

        public bool ComparePassword(string pass)
        {
            return pass == _Password;
        }

        public void Vieillir()
        {
            // Age est marqué comme "init" donc ne peut pas être ré-affecter en dehors de l'initialisation
            // Age += 1;
        }
    }
}
