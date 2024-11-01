using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace PBO1
{
    public class Reptil : Hewan
    {
        public int PanjangTubuh;
        public Reptil(string nama, int umur, int panjangTubuh) : base(nama, umur)
        {
            this.PanjangTubuh = panjangTubuh;
        }

        public override string Suara()
        {
            return "Reptil ini bersuara";
        }
        
    }
}