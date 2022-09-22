# PRAKTIKUM 4

```c#
// Pewarisan / Penurunan Sifat sebuah class
// Polimorphism -> Method pada class turunan memiliki behavior yang berbeda.

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

    // Virtual -> Mengizinkan bahwa method ini bisa di override di child class
    public virtual void bersuara()
    {

    }
}
```

```c#
// Child Class
class Kucing : Hewan
{
    public Kucing(string name) : base(name)
    {

    }

    // Overriding -> denga keyword override
    public override void bersuara()
    {
        Console.WriteLine("Meong meong");
    }

    // Overloading -> Tanpa keyword override
    public void bersuara(string warna)
    {
        Console.WriteLine($"Kucing bewarna {warna} bersuara Meong meong");
    }

    // Overloading
    public void bersuara(string warna, string ekor)
    {
        Console.WriteLine($"Kucing bewarna {warna} dan berekor {ekor} bersuara Meong meong");
    }
}
```

```c#
// Child Class
class Tikus : Hewan
{
    public Tikus(string name) : base(name)
    {

    }

    public override void bersuara()
    {
        Console.WriteLine("Cit cit");
    }

}
```

```c#
class Program
{
    static void Main()
    {
        Kucing kucing1 = new Kucing("Tomang");

        // Tikus tikus1 = new Tikus("Jerry");

        // Method 1 -> Method dari override
        kucing1.bersuara();

        // Method 2 -> Method dari overload
        kucing1.bersuara("Oren");
        
        // Method 3 -> Method dari overload
        kucing1.bersuara("Oren", "Pendek");
        // tikus1.bersuara();
    }
}
```