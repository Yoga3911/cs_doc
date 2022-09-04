# Pengenalan C#

## Daftar Isi
1. [Tipe Data](#1-tipe-data)
2. [Variabel](#2-variabel)
3. [Operator](#3-operator)
4. [Percabangan](#4-percabangan)
5. [Perulangan](#5-perulangan)
6. [Fungsi](#6-fungsi)
7. [Parameter](#7-parameter)
8. [Return Value](#8-return-value)
9. [Bonus Keyword](#9-bonus-keyword)

## 1. Tipe Data
### Integer
Data angka yang berupa bilangan bulat positif atau negatif. ex: 1, 2, 3, 4, dst
| Alias | .NET Type | Size | Range |
| -------- | --------- | ---- | ----- |
| sbyte | System.SByte | 1 byte | -128 to 127 |
| byte | System.Byte | 1 byte | 0 to 255 |
| short | System.Int16 | 2 bytes | -32,768 to 32,767 |
| ushort | System.UInt16 | 2 bytes | 0 to 65,535 |
| int | System.Int32 | 4 bytes | -2,147,483,648 to 2,147,483,647 |
| uint | System.UInt32 | 4 bytes | 0 to 4,294,967,295 |
| long | System.Int64 | 8 bytes | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 |
| ulong | System.UInt64 | 8 bytes | 0 to 18,446,744,073,709,551,615 |

```c#
byte umur = 20;
short harga = 20000;
long total = 19000000000;

Console.WriteLine(umur);
Console.WriteLine(harga);
Console.WriteLine(total);

Console.WriteLine(umur.GetType());
Console.WriteLine(harga.GetType());
Console.WriteLine(total.GetType());
```

*Kapan menggunakan type short, int, long? "Sesuaikan dengan kebutuhan. Misal perlu tipe data untuk umur maka yang paling cocok digunakan adalah byte (Bernilai Positif dengan nilai 0 - 255). Apabila perlu tipe data untuk transaksi bisa menggunakan tipe int atau long."*

### Float
Data angka yang berupa bilangan desimal. ex: 1.1, 2.2, 3.3, 4.4, dst
| Alias | .NET Type | Size | Precision | Range | Suffix |
| ----- | --------- | ---- | --------- | ----- | ------ |
| float | System.Single | 4 bytes | 7 digits | +-1.5 x 10-45 to +-3.4 x 1038 | F atau f |
| double | System.Double | 8 bytes | 15-16 digits | +-5.0 x 10-324 to +-1.7 x 10308 | D atau d |
| decimal | System.Decimal | 16 bytes | 28-29 decimal places | +-1.0 x 10-28 to +-7.9 x 1028 | M atau m |

```c#
float n1 = 1.234f;
double n2 = 1.234; // Khusus untuk double dapat mengosongkan Suffix
decimal n3 = 1.234m;

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);

Console.WriteLine(n1.GetType());
Console.WriteLine(n2.GetType());
Console.WriteLine(n3.GetType());
```

*"Sama halnya dengan Integer, pilih tipe float sesuai kebutuhan."*

### Boolean
| Value | Description |
| ----- | ----------- |
| true | Ketika kondisi memenuhi atau bernilai benar |
| false | Ketika kondisi tidak memenuhi atau bernilai salah |

```c#
bool benar = true;
bool salah = false;


Console.WriteLine(benar);
Console.WriteLine(salah);

Console.WriteLine(benar.GetType());
Console.WriteLine(salah.GetType());
```
### String
String adalah tipe data yang mewakili data tekstual dalam program komputer.
```c#
string nama = "Budi";

Console.WriteLine(nama);

Console.WriteLine(nama.GetType());
```
*"Sama halnya dengan bahasa pemrograman lain untuk memberi nilai pada sebuah string harus diapit oleh tanda petik."*
### List
```c#
List<string> data = new List<string>();
// Cara menambahkan data kedalam sebuah list
data.Add("oke");

// Membuat sebuah List sekaligus mengisi value nya
List<string> data2 = new List<string>{"apel", "melon"};

List<int> data3 = new List<int>{1, 2, 3, 4};

Console.WriteLine(data[0]);
Console.WriteLine(data2[0]);
Console.WriteLine(data2[1]);
Console.WriteLine(data3[0]);
Console.WriteLine(data3[1]);
```
*"Perlu diperhatikan tipe data perlu diisi ketika ingin membuat sebuah List<Tipe Data>."*
### Dictionary
```c#
// Deklarasi dan inisialisasi
Dictionary<string, int> map = new Dictionary<string, int>();
// Tipe string -> key, int -> value
// Cara menambahkan data kedalam sebuah Dictionary
map.Add("umur", 20);

// Membuat sebuah Dictioanry sekaligus mengisi value nya
Dictionary<string, int> map2 = new Dictionary<string, int>{
    {"a", 1},
    {"b", 2},
    {"c", 3},
};

Console.WriteLine(map["umur"]);
Console.WriteLine(map2["a"]);
Console.WriteLine(map2["b"]);
```
*"Perlu diperhatikan tipe data untuk key dan value perlu diisi ketika ingin membuat sebuah Dictionary<Tipe Data, Tipe Data>."*
## 2. Variabel
### Strongly Type
C# adalah salah satu bahasa pemrograman yang strongly type. Dengan kata lain untuk mendefinisikan sebuah variable kita perlu memberi tipe data dari variable tersebut.
### Cara Deklarasi
```c#
int harga;
// int -> Tipe Data
// harga -> Nama variable
```
### Cara Inisialisasi (Assign Value)
```c#
int harga = 10;
// int -> Tipe Data
// harga -> Nama variable
// = -> Operator Assignment
// 10 -> Nilai dari variable harga
```
## 3. Operator
*"x dan y adalah operand, + - * / % adalah operator"*
### Arithmetic Operators
Digunakan untuk operasi aritmatika.
| Operator | Name | Description |
| -------- | ---- | ----------- |
| + | Addition | Menambahkan nilai dua operand, x + y |
| - | Subtraction | Mengurangi nilai dua operand, x - y |
| * | Multiplication | Mengalikan nilai dua operand, x * y |
| / | Division | Membagi nilai dua operand, x / y |
| % | Modulus | Mendapatkan sisa bagi dua operand, x % y |

```c#
int result;
int x = 10, y = 5;

// Addition
result = (x + y);
Console.WriteLine("Addition Operator: " + result);

// Subtraction
result = (x - y);
Console.WriteLine("Subtraction Operator: " + result);

// Multiplication
result = (x * y);
Console.WriteLine("Multiplication Operator: " + result);

// Division
result = (x / y);
Console.WriteLine("Division Operator: " + result);

// Modulos
result = (x % y);
Console.WriteLine("Modulo Operator: " + result);
```

*"Khusus untuk operator penjumlahan dan pengurangan termasuk kedalam unary operator. Dengan kata lain dapat menggunakan keyword ++ untuk menambahkan nilai dengan 1 dan -- untuk mengurangi nilai dengan 1."*

```c#
int a = 10, b;

b = a++;

Console.WriteLine("a is {0} and b is {1}", a, b);

b = a--;

Console.WriteLine("a is {0} and b is {1}", a, b);

b = ++a;

Console.WriteLine("a is {0} and b is {1}", a, b);

b = --a;

Console.WriteLine("a is {0} and b is {1}", a, b);
```

### Relational Operators
Digunakan untuk membandingkan dua nilai.
| Operator | Name | Description |
| -------- | ---- | ----------- |
| == | Equal To | Membandingkan apakah dua operand memiliki nilai sama, x == y |
| != | Not Equal To | Membandingkan apakah dua operand memiliki nilai yang tidak sama, x != y |
| > | Greater Than | Membandingkan dua operand apakah salah satu operand memiliki nilai lebih besar, x > y |
| < | Less Than | Membandingkan dua operand apakah salah satu operand memiliki nilai lebih kecil, x < y |
| >= | Greater Than Equal To | Membandingkan dua operand apakah salah satu operand memiliki nilai lebih besar sama dengan, x >= y |
| <= | Less Than Equal To | Membandingkan dua operand apakah salah satu operand memiliki nilai lebih kecil sama dengan, x <= y |
### Logical Operators
### Bitwise Operators
### Assignment Operators
### Conditional Operator
## 4. Percabangan
### If, Else If, Else
### Switch
## 5. Perulangan
### For
### While
## 6. Fungsi
### Void
## 7. Parameter
### No Name Parameter
### Named Parameter
## 8. Return Value
### Return String
### Return Integer
### Return Float
### Return Boolean
## 9. Bonus Keyword
### Keyword var
### Keyword const