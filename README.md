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