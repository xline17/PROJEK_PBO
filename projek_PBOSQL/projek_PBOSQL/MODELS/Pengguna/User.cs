using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS.Pengguna
{
    public class User
    {
        private int _id;
        private string _username;
        protected string _role;

        public int Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Role { get => _role; set => _role = value; }

        protected User(int id, string username, string role)
        {
            _id = id;
            _username = username;
            _role = role;
        }
        //public abstract void Dapatkanhakakses();

    }
}
