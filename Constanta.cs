using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_UAS_GINA
{
    class Constanta
    {
        #region ** (CONTOH)
        // **. (CONTOH) Membuat fungsi static untuk salam pembuka
        // dengan dua parameter - nama & npm
        public static void SalamPembuka(string nama, string npm)
        {
            Console.Clear();
            Console.WriteLine("============================");
            Console.WriteLine("Selamat Datang di Projek UAS");
            Console.WriteLine("Nama Developer: " + nama);
            Console.WriteLine("NPM: " + npm);
            Console.WriteLine("============================");
        }
        #endregion

        #region ** (CONTOH)
        // **. (CONTOH) membuat fungsi static untuk menampilkan daftar teller dari suatu list
        public static void TampilkanDaftarTeller(List<Teller> _teller)
        {
            Console.WriteLine("Daftar Teller");
            for (int i = 0; i < _teller.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + _teller[i].KODEPEGAWAI + "-" + _teller[i].NAMA);
            }
        }
        #endregion

        #region **
        // **. Buat fungsi static untuk menampilkan daftar nasabah dari list
        public static void TampilkanDaftarNasabah(List<Nasabah> _nasabah)
        {
            Console.WriteLine("Daftar Nasabah");
            for (int i = 0; i < _nasabah.Count; i++)
            {
                Console.WriteLine((i + 1) + ". Norek: " + _nasabah[i].NOREKENING
                    + ", atas nama " + _nasabah[i].NAMA + ", saldo saat ini: "
                    + _nasabah[i].SALDO);
            }
        }
        #endregion
    }
}
