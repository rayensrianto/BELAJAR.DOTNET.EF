# BELAJAR.DOTNET.EF
 
## ENTITY FRAMEWORK BASIC 

### Apa itu Entity Framework?
EF adalah framework open source ORM untuk .Net apps yang memungkinan programmer berkerja dengan realtional data menggunakan domain-specific object tanpa harus fokus ke table dan kolom dimana data itu di simpan.
EF mengurangin code yang biasanya di tulis oleh programmer untuk akses database.

### Apa itu ORM?
ORM adalah Object Relational Mapping (ORM) Framework yang secara otomatis akan meng-generate class berdasarkan table pada database atau sebalik nya.

### Contoh Kasus
Untuk menampilkan data, misal menampilkan data Department dan Employee, kita harus:
1. membuat class Department dan Employee
2. kita harus menulis code ADO.NET untuk memanggil dan menampilkan data dari database.
3. setelah data di panggil, kita harus membuat object Department dan Emplyee lalu mengisi object2 tersebut dengan data yang sudah di panggil.

Tetapi, EF dapat melakukan itu semua dengan otomatis.

### Feature-Feature EF
1. Cross Platform : bisa jalan di windows, linux atau mac os.
2. Modeling : EF mambuat EDM berdasarkan POCO entities dengan property get/set dari berbagai tipe data, ini juga di gunakan utuk melakukan query atau simpan data ke database.
3. Querying :

## DATABASE FIRST APPROACH
