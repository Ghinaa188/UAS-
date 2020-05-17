using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_UAS_GINA
{
    class Person
    {
        // ini adalah atribut untuk Person
        private string noKtp;
        private string nama;
        private string alamat;

        #region Properteis
        
        public string NOKTP { get { return this.noKtp; } set { this.noKtp = value; } }
        public string NAMA { get { return this.nama; } set { this.nama = value; } }
        public string ALAMAT { get { return this.alamat; } set { this.alamat = value; } }
        #endregion
    }
}
