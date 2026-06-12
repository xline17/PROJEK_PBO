using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS
{
    internal class SimulasiAnalisis
    {
        public string NamaTanaman { get; set; }
        private double _luasLahan;

        public double LuasLahan
        {
            get => _luasLahan;
            set { if (value >= 0) _luasLahan = value; }
        }
        public double HitungKebutuhanPupuk(double dosisPerM2)
        {
            return _luasLahan * dosisPerM2;
        }
        public decimal HitungEstimasiBiaya(double kebutuhanKg, decimal hargaPerKg)
        {
            return (decimal)kebutuhanKg * hargaPerKg;
        }
    }
}
