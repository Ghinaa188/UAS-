using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Projek UAS Matakuliah Praktikum Pemrograman Berorientasi Objek
/// Semester Genap TA 1920
/// Dosen Pengampu : Galih Ashari R., S.Si., MT., MTA
/// Politeknik Praktisi Bandung
/// 
/// INSTRUKSI:
/// 1. Projek UAS ini belum sepenuhnya lengkap. Tugas anda adalah melengkap 
/// 2. untuk setiap komen dari script yang memiliki format = Nomor dan Perintah 
/// (contoh: **. Login user dengan parameter username dan password menggunakan konsep OOP), isikan scriptnya.
/// 3. Untuk mengerjakan semua soal ini, logika pemrograman anda harus lah baik
/// 4. Untuk beberapa tanda soal, akan diberikan contoh
/// 5. Kerjakan semua soal dengan sejelas mungkin
/// 6. URUTAN PENGERJAAN BEBAS, MANA SAJA YANG SEKIRANYA MASUK LOGIKA BERPIKIR ANDA !!!
/// 7. Soal ditandai dengan tanda 2 bintang, **
/// yang kemudian ditandai dengan barisan // ........................... YOUR CODE IS HERE ------------- 
/// disitulah anda menuliskan kode anda sebagai jawaban ujian
/// </summary>

namespace OOP_UAS_GINA
{
    class Program
    {
        static void Main(string[] args)
        {
        // Inisialisasi Data
            Console.WriteLine("INISIALISASI DATA");
            #region ** (CONTOH)
            // ** (CONTOH) buat 3 teller bank (atribut = kodepegawai, nama, nomorteller)
            // Input by User

            List<Teller> daftarTeller = new List<Teller>();
            Console.WriteLine("Data Teller:");
            for (int i = 0; i < 3; i++)
            {
                // Input User
                Console.WriteLine("Teller #" + (i + 1));
                Console.Write("Nomor KTP: "); string _KTP = Console.ReadLine();
                Console.Write("Nama: "); string _NAMATeller = Console.ReadLine();
                Console.Write("Alamat: "); string _ALAMAT = Console.ReadLine();
                Console.Write("Kode Pegawai: "); string _kodePegawai = Console.ReadLine();
                Console.Write("Nomor Teller: "); string _NOMORTeller = Console.ReadLine();

                // create objek teller
                Teller teller = new Teller(_KTP, _NAMATeller, _ALAMAT, _kodePegawai, _NOMORTeller);
                // masukkan teller ke dalam daftar Teller
                daftarTeller.Add(teller);
               
            }
            #endregion

            #region **
            // ** buat 4 nasabah bank (atribut = nomor rekening, nomor ktp, PIN, nama, alamat, besar setoran
            // Input by User
            List<Nasabah> daftarNasabah = new List<Nasabah>();
            // ........................... YOUR CODE IS HERE -------------
            Console.WriteLine("Data Nasabah:");
            for (int i = 0; i <  4; i++)
            {
                Console.Write("Nomor KTP: "); string _KTP = Console.ReadLine();
                Console.Write("Nama: "); string _Nama = Console.ReadLine();
                Console.Write("Alamat: "); string _Alamat = Console.ReadLine();
                Console.Write("Nomor PIN: "); string _NoPIN = Console.ReadLine();
                Console.Write("Nomor Rekening: "); string _NoRekening = Console.ReadLine();
                Console.WriteLine("Besar Setoran: "); int _besaran = int.Parse(Console.ReadLine());


                // create objek teller
                Nasabah nasabah = new Nasabah(_KTP, _Nama, _Alamat, _NoPIN, _NoRekening,_besaran );
                // masukkan teller ke dalam daftar Teller
                daftarNasabah.Add(nasabah);
            }
            #endregion

            #region ** (CONTOH)
            // **. (CONTOH) Fungsi static untuk Kalimat Pembuka, parameter = nama + npm
            // input by User
            Console.Clear();
            Console.WriteLine("Masukkan Data Aplikasi Anda");
            Console.Write("nama: "); string _nama = Console.ReadLine();
            Console.Write("npm: "); string _npm = Console.ReadLine();
            Constanta.SalamPembuka(_nama, _npm);    // ini adalah fungsi static kalimat pembuka 
            #endregion

            // menu pilihan
            Console.WriteLine("Daftar Menu");
            Console.WriteLine("1. Ubah PIN");
            Console.WriteLine("2. Setoran Tunai");
            Console.WriteLine("3. Tampil Saldo");
            Console.Write("pilihan anda: "); string _pilihanMenu = Console.ReadLine();

            if (_pilihanMenu == "1")
            {
                #region ** (CONTOH)
                // tampilkan daftar nasabah -- dari fungsi static di class Constanta
                Constanta.TampilkanDaftarNasabah(daftarNasabah); 
                #endregion

                // memilih nasabah yang akan diganti PIN
                Console.Write("masukkan nomor urut nasabah yang akan diganti PIN: ");
                string _nomorRekeningPilih = Console.ReadLine();

                // code berikut ini adalah membuat objek nasabah berdasarkan daftar nasabah yang telah dipilih
                Nasabah nasabahPilih = daftarNasabah[int.Parse(_nomorRekeningPilih) - 1];
                
                // konfirmasi nasabah yang telah dipilih
                Console.WriteLine("anda memilih nasabah atas nama: " + nasabahPilih.NAMA);

                // Pengisian PIN lama dan PIN baru
                Console.Write("PIN lama: "); string _pinLama = Console.ReadLine();
                Console.Write("PIN Baru: "); string _pinBaru = Console.ReadLine();

                #region **
                // Fungsi untuk mengganti PIN dari variable nasabahPilih
                nasabahPilih.GantiPIN(_pinLama, _pinBaru);
                #endregion
            }
            else if (_pilihanMenu == "2")
            {
                #region **
                // tampilkan daftar nasabah -- berasal dari class Constanta
                Constanta.TampilkanDaftarNasabah(daftarNasabah); 
                #endregion

                #region **
                // tampilkan daftar teller -- berasal dari class Constanta
                Constanta.TampilkanDaftarTeller(daftarTeller); 
                #endregion

                // memilih nasabah yang akan menyetorkan uang
                Console.Write("masukkan nomor urut nasabah yang akan menyetorkan uang: ");
                string urutNasabah = Console.ReadLine();
                Console.Write("besar setoran tunai: "); int _besaran = int.Parse(Console.ReadLine());

                #region **
                // memilih teller yang akan menerima setoran uang
                Console.Write("masukkan nomor urut teller yang akan menerima uang: ");
                string urutTeller = Console.ReadLine();
                
                #endregion

                // kenakan ke objek nasabah dan teller yang terpilih dari DAFTAR nasabah dan teller
                Nasabah nasabahMenabung = daftarNasabah[int.Parse(urutNasabah) - 1];
                Teller tellerTerpilih = daftarTeller[int.Parse(urutTeller) - 1];

                #region **
                // berikut ini adalah pembuatan objek Menabung, yang terdiri dari nomor transaksi (input by sistem),
                // serta teller yang dipilih
                // a. buat objek dari class Menabung
                
                Console.Write("Nomor Transaksi: "); string _NOTransaksi = Console.ReadLine();
                Console.WriteLine("Teller yang Terpilih" + tellerTerpilih.NAMA);
                // create objek Menabung
                Menabung menabung = new Menabung(_NOTransaksi, tellerTerpilih);
                // b. objek nasabah yang menabung, memanggil fungsi MelakukanAktivitasMenabung
                Console.Write("Masukan Nomor Urut Nasabah yang akan Menyetor uang: "); string nasabahmenabung = Console.ReadLine();
                Console.Write("Besar Setoran Tunai: "); int _Besaran = int.Parse(Console.ReadLine());
                Console.WriteLine("Transaksi Menabung: ");
                Console.WriteLine("Nomor Transaksi: " + _NOTransaksi);
                Console.WriteLine("Teller: " + tellerTerpilih);
                Console.WriteLine("Jumlah Setoran: " + _Besaran);
                
                Console.WriteLine("Saldo Anda: " + _Besaran + saldo);

                
                nasabahMenabung.MelakukanAktivitasMenabung(_NOTransaksi, tellerTerpilih, _Besaran, saldo);
                // dengan parameternya adalah menabung dan besar setoran
                
                #endregion
            }
            else if( _pilihanMenu== "3")
            {
                #region **
                // tampilkan daftar nasabah
                Constanta.TampilkanDaftarNasabah(daftarNasabah);
                #endregion
                // memilih nasabah yang akan ditampilkan saldo
                Console.Write("Masukkan nomor urut nasabah yang akan dilihat saldonya: ");
                string urutNasabah = Console.ReadLine();

                #region **
                // a. lempar nasabah yang terpilih ke dalam objek nasabah yang baru

                Nasabah urutnasabah = new Nasabah(" ");
                // b. tampilkan saldo dari objek nasabah yang telah dipilih
                urutnasabah.TampilkanSaldo();
                #endregion
            }
            else
            {
                Console.WriteLine("Pilihan anda diluar opsi");
            }

            Console.WriteLine("\nTerima kasih telah menggunakan layanan kami");
            
            Console.ReadKey();
        }
        }
    }
