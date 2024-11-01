using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBO1
{
    public class Singa : Mamalia
    {
        public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki){}

        public void Mengaum()
        {
            Console.WriteLine("Singa ini mengaum");
        }
        public override string Suara()
        {
            return "raawerrr";
        }

    }
}