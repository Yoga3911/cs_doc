class Program
{
    static void Main()
    {
        // ! ASOSIASI
        Asosiasi.Manajer manajer1 = new Asosiasi.Manajer(nama: "Budi", gaji: 2000, id: 1);
        Asosiasi.Karyawan karyawan1 = new Asosiasi.Karyawan(nama: "Mamat", gaji: 1000, id: 1);

        karyawan1.cekGaji(manajer1);

        Asosiasi.Karyawan karyawan2 = new Asosiasi.Karyawan(nama: "Ali", gaji: 1000, id: 1);
        Asosiasi.Manajer manajer2 = new Asosiasi.Manajer(nama: "Sugeng", gaji: 2000, id: 1);

        karyawan2.cekGaji(manajer1);

        // ! AGREGASI
        Agregasi.Manajer manajer3 = new Agregasi.Manajer(nama: "Budi", gaji: 2000, id: 1);
        Agregasi.Karyawan karyawan3 = new Agregasi.Karyawan(nama: "Mamat", gaji: 1000, id: 1, manajer: manajer3);

        karyawan3.cekGaji();

        Agregasi.Manajer manajer4 = new Agregasi.Manajer(nama: "Sugeng", gaji: 2000, id: 1);
        Agregasi.Karyawan karyawan4 = new Agregasi.Karyawan(nama: "Ali", gaji: 1000, id: 1, manajer: manajer3);

        karyawan4.cekGaji();

        // ! KOMPOSISI
        Komposisi.Mobil mobil1 = new Komposisi.Mobil("Kayu", "merah", 1);
        mobil1.cekMesin();

        Komposisi.Mobil mobil2 = new Komposisi.Mobil("Kaleng", "biru", 2);
        mobil2.cekMesin();
    }
}