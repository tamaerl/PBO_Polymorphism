using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBO1
{
    public class KebunBinatang
    {
        public List<Hewan> KoleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
        {
            KoleksiHewan.Add(hewan);

        }
        public void DaftarHewan()
        {
            foreach (var hewan in KoleksiHewan)
            {
                Console.WriteLine(hewan.InfoHewan());
            }
        }
    }
}