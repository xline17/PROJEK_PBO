using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS.Pengguna
{
    internal class Petani : User
    {
        public Petani(int id, string username, string role) : base(id, username, "Petani")
        {
        }
        public override void Dapatkanhakakses()
        {
            Console.WriteLine("Petani memiliki akses terbatas ke sistem.");
        }
    }
}
