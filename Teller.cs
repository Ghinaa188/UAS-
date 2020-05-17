using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_UAS_GINA
{
    class Teller : Person
    {
        private string kodePegawai;
        private string nomorTeller;

        #region Properties
        public string KODEPEGAWAI { get { return this.kodePegawai; } set { this.kodePegawai = value; } }
        public string NOMORTELLER { get { return this.nomorTeller; } set { this.nomorTeller = value; } }
        #endregion

        #region Construktor
        public Teller(string _nomorKTP, string _namateller, string _alamat, string _nomorteller, string _kodePegawai)
        {
            this.NOKTP = _nomorKTP;
            this.NAMA = _namateller;
            this.ALAMAT = _alamat;
            this.NOMORTELLER = _nomorteller;
            this.KODEPEGAWAI = _kodePegawai;
        }
        #endregion
    }
}
