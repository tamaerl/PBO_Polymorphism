using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBO1
{
    public class Buaya : Reptil
    {
        public Buaya(string nama, int umur, int panjangTubuh) : base(nama, umur, panjangTubuh) { }
        public override string Suara()
        {
            return "rrrrrrrrr";
        }
    }
}