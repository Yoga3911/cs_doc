namespace Asosiasi
{
    class Karyawan
    {
        public uint id;
        public string nama;
        public uint gaji;
        public Karyawan(string nama, uint gaji, uint id)
        {
            this.id = id;
            this.nama = nama;
            this.gaji = gaji;
        }

        public void cekGaji(Manajer manajer)
        {
            Console.WriteLine($"Gaji karyawan {this.nama} diberikan oleh {manajer.nama}");
        }

        public void cekGaji2(Manajer manajer)
        {
            Console.WriteLine($"Gaji karyawan {this.nama} diberikan oleh {manajer.nama}");
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