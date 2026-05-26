using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Text;

namespace projek_PBOSQL.MODELS.Pengguna
{
    internal class Admin : User
    {
        public Admin(string pass, string username, string role) : base(pass, username, "Admin")
        {
            username = "admin";
            pass = "admin123";
        }
        //public override void Dapatkanhakakses()
        //{
        //    Console.WriteLine("Admin memiliki akses penuh ke sistem.");
        //}
    }
}
