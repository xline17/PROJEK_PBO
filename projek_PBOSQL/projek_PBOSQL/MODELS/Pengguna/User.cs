using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS.Pengguna
{
    public class User
    {
        private string _pass;
        private string _username;
        protected string _role;

        public string Pass { get => _pass; set => _pass = value; }
        public string Username { get => _username; set => _username = value; }
        public string Role { get => _role; set => _role = value; }

        protected User(string pass, string username, string role)
        {
            _pass = pass;
            _username = username;
            _role = role;
        }
        //public abstract void Dapatkanhakakses();

    }
}
