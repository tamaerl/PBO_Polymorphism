using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBO1
{
    public class Gajah : Mamalia
    {
        public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

        public override string Suara()
        {
            return "pawoooooon";
        }
    }

} 