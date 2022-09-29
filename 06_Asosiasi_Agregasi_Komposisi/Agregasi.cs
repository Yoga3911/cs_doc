namespace Agregasi
{
    class Karyawan
    {
        public uint id;
        public string nama;
        public uint gaji;
        public Manajer manajer;
        public Karyawan(string nama, uint gaji, uint id, Manajer manajer)
        {
            this.id = id;
            this.nama = nama;
            this.gaji = gaji;
            this.manajer = manajer;
        }

        public void cekGaji()
        {
            Console.WriteLine($"Gaji karyawan {this.nama} diberikan oleh {this.manajer.nama}");
        }

        public void cekGaji2()
        {
            Console.WriteLine($"Gaji karyawan {this.nama} diberikan oleh {this.manajer.nama}");
        }
    }

    class Manajer
    {
        public uint id;
        public string nama;
        public uint gaji;
        public Manajer(string nama, uint gaji, uint id)
        {
            this.id = id;
            this.nama = nama;
            this.gaji = gaji;
        }
    }
}