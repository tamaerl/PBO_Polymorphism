using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBO1
{
    public class Ular : Reptil
    {
        public Ular(string nama, int umur, int panjangTubuh) : base(nama, umur, panjangTubuh){ }
      
        public void Merayap()
        {
            Console.WriteLine("Ular iini merayap");
        }
        public override string Suara()
        {
            return "sksksksk";
        }
    }
}