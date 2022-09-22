// Dalam class perlu access modifier
// Public, Private, Protected
using hero;


namespace manusia
{
    class Program
    {
        static void Main()
        {
            // Objek 
            // Instance
            // Berbeda

            Manusia man = new Manusia("Budi", "20"); // Instansiasi
            Manusia.hallo();
            Console.WriteLine(man.nama);
            Console.WriteLine(man.umur);
            // Console.WriteLine("Mulai");
        }
    }

    // Constructor

    // Public -> bisa diakses dimana saja
    // Private -> Hanya bisa diakses dari kelas yang bersangkutan
    // Protected -> Class yang bersangkutan dan kelas turunannya
    class Manusia
    {
        public string nama;
        public string umur;

        public Manusia(string namaB, string umurB)
        {
            nama = namaB;
            umur = umurB;
            Console.WriteLine(nama);
        }

        public static void hallo()
        {
            List<int> data = new List<int> { 1, 2, 3, 4, 5 };
        }
    }
}

