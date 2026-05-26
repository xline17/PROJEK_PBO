using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS.Pengguna
{
    internal class Petani : User
    {
        public Petani(string pass, string username, string role) : base(pass, username, "Petani")
        {
            pass = "petani123";
            username = "petani";
        }
        //public override void Dapatkanhakakses()
        //{
        //    Console.WriteLine("Petani memiliki akses terbatas ke sistem.");
        //}
    }
}
