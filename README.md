## .NET 8 Kurulum Linkleri

Sisteminize göre aşağıdaki versiyonları yükleyiniz.

**Windows**

- x64  :  https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.100-windows-x64-installer
- x86  :  https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.100-windows-x86-installer
- Arm64:  https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.100-windows-arm64-installer

**macOS**

- Arm64:  https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.100-macos-arm64-installer
- x64  :  https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.100-macos-x64-installer

## Entity Framework Core 8 Kurulum Linkleri

**1- Entity Framework Core Tools**

- dotnet tool uninstall --global dotnet-ef
- dotnet tool install --global dotnet-ef --version 8.0.2

**2- Entity Framework Core Packages**

- dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.2
- dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0.2

- dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.2

**3- Proje Referansının Eklenmesi**

- cd StoreApp.Web
- dotnet add reference ../StoreApp.Data/StoreApp.Data.csproj

## Bootstrap ile Asp.NET Uygulamasına Tema Uygulama

 **1- Libman Kurulumu**

- dotnet tool list -g
- dotnet tool uninstall --global Microsoft.Web.LibraryManager.Cli
- dotnet tool install --global Microsoft.Web.LibraryManager.Cli --version 2.1.175

**2- Libman Configuration File**

- cd storeApp.Web
- libman init -p cdnjs

**3- Kütüphane Kurulumu**

- libman install bootstrap@5.3.3 -d wwwroot/lib/bootstrap
- libman install jquery@3.7.1 -d wwwroot/lib/jquery

**4- Bootstrap Css Kütaphanesinin Dahil Edilmesi**

- <link rel="stylesheet" href="/lib/bootstrap/css/bootstrap.min.css">

**5- Bootstrap Js Kütaphanesinin Dahil Edilmesi**

- <script src="~/lib/bootstrap/js/bootstrap.min.js"></script>

**6- jquery Kütaphanesinin Dahil Edilmesi**

- <script src="~/lib/jquery/jquery.min.js"></script>

**7- wwwroot/lib klasörü yoksa meta bilgisinde (libman.json) olan paketleri yükleme**

- libman restore