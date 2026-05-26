using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS.Pengguna
{
    internal class Admin : User
    {
        public Admin(int id, string username, string role) : base(id, username, "Admin")
        {
        }
        public override void Dapatkanhakakses()
        {
            Console.WriteLine("Admin memiliki akses penuh ke sistem.");
        }
    }
}
