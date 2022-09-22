// Contoh penggunaan Polimorphism
// Tabel Produk -> CRUD
// Tabel Komen -> CRUD

// ! Insert
// ! GetAll
// ! Update
// ! Delete


// Parent Class
class Hewan
{
    public string nama;
    public Hewan(string nama)
    {
        this.nama = nama;
    }

    // Mengizinkan bahwa method ini bisa di override di child class
    public virtual void bersuara()
    {

    }
}

// Child Class
class Kucing : Hewan
{
    public Kucing(string name) : base(name)
    {

    }

    // Overriding
    public override void bersuara()
    {
        Console.WriteLine("Meong meong");
    }

    // Overloading
    public void bersuara2(Tikus tikus, string nama)
    {
        tikus.nama = nama;
        // Console.WriteLine($"Kucing bewarna {warna} bersuara Meong meong");
    }

    // Overloading
    public void bersuara(string warna, string ekor)
    {
        Console.WriteLine($"Kucing bewarna {warna} dan berekor {ekor} bersuara Meong meong");
    }
}

// Child Class
class Tikus : Hewan
{
    public Tikus(string name) : base(name)
    {

    }

    public override void bersuara()
    {
        Console.WriteLine($"Cit cit -> {this.nama}");
    }

}

class Program
{
    static void Main()
    {
        Kucing kucing1 = new Kucing("Tomang");

        Tikus tikus1 = new Tikus("Jerry");


        // kucing1.bersuara();

        kucing1.bersuara2(tikus1, "TOM");

        tikus1.bersuara();
        
        // kucing1.bersuara("Oren", "Pendek");
        // tikus1.bersuara();
    }
}