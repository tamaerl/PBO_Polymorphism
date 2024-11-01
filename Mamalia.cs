using PBO1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBO1
{
    public class Mamalia : Hewan
    {
        public int JumlahKaki;
        public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
        {
            this.JumlahKaki = jumlahKaki;
        }

        public override string Suara()
        {
            return "Mamalia ini bersuara";
        }
    }
}

    