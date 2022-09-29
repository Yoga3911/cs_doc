namespace Komposisi
{
    class Mobil
    {
        public uint id;
        public string nama;
        public string warna;
        public Mesin mesin = new Mesin("Abal - abal", 1);
        // public Database mesin = new Database();
        public Mobil(string nama, string warna, uint id)
        {
            this.id = id;
            this.nama = nama;
            this.warna = warna;
        }

        public void cekMesin() {
            Console.WriteLine($"Mesin mobil {this.nama} diproduksi oleh perusahaan {mesin.nama_perusahaan}");
        }
    }

    class Mesin
    {
        public uint id;
        public string nama_perusahaan;
        public Mesin(string nama_perusahaan, uint id)
        {
            this.id = id;
            this.nama_perusahaan = nama_perusahaan;
        }
    }
}