using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBO1
{
    public class Hewan
    {
        public string Nama;
        public int Umur;

        public Hewan(string nama, int umur)
        {
            this.Nama = nama;
            this.Umur = umur;
        }

        public virtual string Suara()
        {
            return "Hewan ini bersuara";
        }

        public virtual string InfoHewan()
        {
            return $"Nama: {Nama}, \nUmur: {Umur}";
        }
   
    }
}