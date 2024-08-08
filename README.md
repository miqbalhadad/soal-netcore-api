# Product API

Product API adalah aplikasi web API sederhana yang memungkinkan operasi CRUD (Create, Read, Update, Delete) pada entitas Product. Aplikasi ini dibangun menggunakan ASP.NET Core dan menggunakan Entity Framework Core dengan In-Memory Database untuk penyimpanan data sementara.

## Fitur

- **Create Product**: Tambahkan produk baru.
- **Read Product**: Dapatkan daftar produk atau produk tertentu berdasarkan ID.
- **Update Product**: Perbarui data produk yang ada.
- **Delete Product**: Hapus produk berdasarkan ID.
- **Swagger UI**: Dokumentasi API interaktif untuk menguji endpoint API.

## Paket yang Digunakan

- [Microsoft.AspNetCore.App](https://www.nuget.org/packages/Microsoft.AspNetCore.App/): Framework dasar untuk aplikasi ASP.NET Core.
- [Microsoft.EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/): ORM untuk berinteraksi dengan database.
- [Microsoft.EntityFrameworkCore.InMemory](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.InMemory/): Penyedia database In-Memory untuk pengujian dan penyimpanan sementara.
- [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore/): Paket untuk mengintegrasikan Swagger UI dengan ASP.NET Core.

## Prasyarat

- [.NET 8.0 SDK atau lebih baru](https://dotnet.microsoft.com/download)

## Cara Menjalankan Proyek

1. **Clone Repository:**
   ```sh
   git clone <repository-url>
   cd ProductApi
