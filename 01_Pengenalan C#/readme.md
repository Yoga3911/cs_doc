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
10. [Input Output](#10-input-output)
11. [Mengubah Tipe Data](#11-mengubah-tipe-data)

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
| :------: | ---- | ----------- |
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
| :------: | ---- | ----------- |
| == | Equal To | Membandingkan apakah dua operand memiliki nilai sama, x == y |
| != | Not Equal To | Membandingkan apakah dua operand memiliki nilai yang tidak sama, x != y |
| > | Greater Than | Membandingkan dua operand apakah salah satu operand memiliki nilai lebih besar, x > y |
| < | Less Than | Membandingkan dua operand apakah salah satu operand memiliki nilai lebih kecil, x < y |
| >= | Greater Than Equal To | Membandingkan dua operand apakah salah satu operand memiliki nilai lebih besar sama dengan, x >= y |
| <= | Less Than Equal To | Membandingkan dua operand apakah salah satu operand memiliki nilai lebih kecil sama dengan, x <= y |

```c#
bool result;
int x = 5, y = 10;

// Equal to Operator
result = (x == y);
Console.WriteLine("Equal to Operator: " + result);

// Greater than Operator
result = (x > y);
Console.WriteLine("Greater than Operator: " + result);

// Less than Operator
result = (x < y);
Console.WriteLine("Less than Operator: " + result);

// Greater than Equal to Operator
result = (x >= y);
Console.WriteLine("Greater than or Equal to: " + result);

// Less than Equal to Operator
result = (x <= y);
Console.WriteLine("Lesser than or Equal to: " + result);

// Not Equal To Operator
result = (x != y);
Console.WriteLine("Not Equal to Operator: " + result);
```
### Logical Operators
Digunakan untuk operasi aritmatika.
| Operator | Name | Description |
| :------: | :--: | ----------- |
| `&&` | AND | Mengembalikan nilai true jika dua kondisi terpenuhi dan sebaliknya |
| ```||``` | OR | Mengembalikan nilai true jika salah satu kondisi terpenuhi dan false jika tidak ada yang terpenuhi |
| `!` | NOT | Membalikkan suatu nilai boolean, apabila kondisi terpenuhi mengembalikan false dan sebaliknya |

```c#
bool a = true, b = false, result;

// AND operator
result = a && b;
Console.WriteLine("AND Operator: " + result);

// OR operator
result = a || b;
Console.WriteLine("OR Operator: " + result);

// NOT operator
result = !a;
Console.WriteLine("NOT Operator: " + result);
```

### Assignment Operators
| Operator | Name | Description |
| :------: | ---- | ----------- |
| += | Add Assignment | a += b sama dengan a = a + b |
| -= | Subtract Assignment | a -= b sama dengan a = a - b |
| *= | Multiply Assignment | a *= b sama dengan a = a * b |
| /= | Division Assignment | a /= b sama dengan a = a / b |
| %= | Modulus Assignment | a %= b sama dengan a = a % b |

```c#
int x = 15;

x += 10;
Console.WriteLine("Add Assignment Operator: " + x);

// initialize variable
x = 20;

x -= 5;
Console.WriteLine("Subtract Assignment Operator: " + x);

// initialize variable
x = 15;

x *= 5;
Console.WriteLine("Multiply Assignment Operator: " + x);

// initialize variable
x = 25;

x /= 5;
Console.WriteLine("Division Assignment Operator: " + x);

// initialize variable
x = 25;

x %= 5;
Console.WriteLine("Modulo Assignment Operator: " + x);
```

### Conditional Operator
Conditional Operator bisa juga disebut dengan Ternary Operator
*"condition ? first_expression : second_expression;"*

```c#
int x = 5, y = 10, result;

result = x > y ? x : y;

Console.WriteLine("Result: " + result);

result = x < y ? x : y;

Console.WriteLine("Result: " + result);
```

## 4. Percabangan
### If, Else If, Else
```c#
int angka = 10;

if (angka > 10)
{
    Console.WriteLine("Lebih Dari 10");
}
else if (angka < 10)
{
    Console.WriteLine("Kurang Dari 10");
}
else
{
    Console.WriteLine("Sama Dengan 10");
}
```
### Switch
```c#
int angka = 5;
switch (angka)
{
    // Apabila angka == 1
    case 1: // IF
        {
            Console.WriteLine("Senin");
            break;
        }
    // Apabila angka == 2
    case 2: // ELSE IF
        {
            Console.WriteLine("Selasa");
            break;
        }
    // Apabila tidak ada case yang memenuhi
    default: // ELSE
        {
            Console.WriteLine("Selasa");
            break;

        }
}
```

## 5. Perulangan
### For
```c#
// int 1 = 0 -> Deklarasi dan Inisialisasi Variable
// i > 10 -> Kondisi i kurang dari 10
// i++ -> Expression, menambahkan nilai i dengan 1 tiap iterasinya
for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
}

// Penggunaan For untuk menampilkan data dari List dan Dictionary
List<int> data = new List<int> { 1, 2, 3, 4, 5 };

foreach (var i in data)
{
    Console.WriteLine(i);
    Console.WriteLine(i);
}

Console.WriteLine("===========");

Dictionary<string, int> data2 = new Dictionary<string, int> {
    {"a", 1},
    {"b", 2},
    {"c", 3},
};

foreach (var i in data2)
{
    Console.WriteLine(i.Key);
    Console.WriteLine(i.Value);
}
```
### While
```c#
int angka = 2;
while (angka < 10)
{
    Console.WriteLine(angka);
    angka += 2;
}
```

## 6. Fungsi
### Void
Fungsi dengan keyword void memiliki arti fungsi yang tidak mengembalikan nilai apapun (tidak ada return).
```c#
void sayHello() {
    Console.WriteLine("Hello");
}

sayHello();
```

## 7. Parameter
### No Name Parameter
Fungsi yang ketika memberikan nilai pada parameter (attribute) ketika dipanggil tidak memerlukan key.
```c#
void sayHello(string name) {
    Console.WriteLine("Hello " + name);
}

sayHello("Mamat");
```
### Named Parameter
Fungsi yang ketika memberikan nilai pada parameter (attribute) ketika dipanggil memerlukan key.
```c#
void sayHello(string name) {
    Console.WriteLine("Hello " + name);
}

sayHello(name: "Eko");
```

## 8. Return Value
Fungsi yang mengembalikan suatu nilai (return) ketika dipanggil.
```c#
// Mengembalikan Tipe data String
string sayHello(string name) {
    return "Hello " + name;
}

Console.WriteLine(sayHello(name: "Eko"));

// Mengembalikan Tipe data int
int penjumlahan(int a, int b) {
    return a + b;
}

Console.WriteLine(penjumlahan(10, 5));
```

## 9. Bonus Keyword
### Keyword var
Dengan keyword var kita bisa tidak memberika tipe data pada variable yang ingin kita buat.

```c#
var nama = "Sugeng";
var umur = 20;

Console.WriteLine(nama);
Console.WriteLine(umur);

Console.WriteLine(nama.GetType());
Console.WriteLine(umur.GetType());
```

### Keyword const
Apabila kita ingin membuat sebuah variable dengan nilai yang konstan kita dapat menggunakan keyword const. *Perlu diingat apabila membuat variable dengna keyword const kita tidak dapat melakukan reassign pada variable tersebut.*

```c#
const double PI = 3.14;

Console.WriteLine(PI);
Console.WriteLine(PI.GetTypeCode());
```

*Dengan memberikan keyword const maka variable tersebut akan dibuat ketika compile time, sebaliknya jika tidak diberikan keyword const maka variable tersebut akan dibuat ketika running time. Plus nya adalah variable dengan keyword const tidak memerlukan alokasi memori ketika running time.*

## 10. Input Output
```c#
// Menampilkan pesan Hallo
Console.WriteLine("Hallo"); // Output

// Menampilkan pesan sesuai inputan user
var inputan = Console.ReadLine(); // Input
Console.WriteLine(inputan);
```
## 11. Mengubah Tipe Data
```c#
string angka = "12";
Console.WriteLine(angka);
Console.WriteLine(angka.GetTypeCode());
Console.WriteLine(Convert.ToInt32(angka));
Console.WriteLine(Convert.ToInt32(angka).GetType());
```
*Dengan lib Convert kalian dapat mengubah tipe data sesuai yang kalian inginkan. Namun perlu diperhatikan kecocokannya. Apabila terdapat sebuah text dengan nilai berupa huruf maka tentu saja tidak bisa di convert kedalam bentuk integer, float dan boolean.*