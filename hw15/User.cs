using System;
using System.Collections.Generic;
using System.Text;

namespace hw15
{
    class User : Guest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private string password;
        private string login;
        public User()
        {

        }
        public User(string Name, string Surname, string password, string login)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.password = password;
            this.login = login;
        }
    }
}
