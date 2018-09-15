using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrianAlexanderPutraCodingTest2
{
    public class AreaParkir
    {
        private int id;
        private string jenisKendaraan;
        private string tempatParkir;

        public AreaParkir (int id, string jenisKendaraan, string tempatParkir)
        {
            this.id = id;
            this.jenisKendaraan = jenisKendaraan;
            this.tempatParkir = tempatParkir;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string JenisKendaraan
        {
            get { return jenisKendaraan; }
            set { jenisKendaraan = value; }
        }
        public string TempatParkir
        {
            get { return tempatParkir; }
            set { tempatParkir = value; }
        }
    }

}
