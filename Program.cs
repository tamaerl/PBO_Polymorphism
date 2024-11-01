using System.Diagnostics.Contracts;

namespace PBO1
{
    public class Program
    {
        static void Main(string[] args)
        {
            KebunBinatang kebunBinatang = new KebunBinatang();
            Singa singa = new Singa("Simba", 3, 4);
            Gajah gajah = new Gajah("Rafky", 5, 4);
            Ular ular = new Ular("Orochimaru", 25, 10);
            Buaya buaya = new Buaya("Ijo", 19, 11);

            Reptil reptil = new Buaya("Shayrial",19,171);

            //kebunBinatang.TambahHewan(buaya);
            //kebunBinatang.TambahHewan(singa);
            //kebunBinatang.TambahHewan(gajah);
            //kebunBinatang.TambahHewan(ular);

            //kebunBinatang.DaftarHewan();

            //singa.Suara();
            //singa.Mengaum();
            Console.WriteLine($"jumlah kaki = {singa.JumlahKaki} umur = {singa.Umur} nama = {singa.Nama}");
        }
    }
}

