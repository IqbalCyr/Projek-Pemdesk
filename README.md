# Aplikasi Manajemen Laundry (Purple Laundry TEST)

![Visual Basic .NET](https://img.shields.io/badge/Visual_Basic_.NET-%23512BD4.svg?style=for-the-badge&logo=dotnet&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-%235C2D91.svg?style=for-the-badge&logo=dotnet&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-%235C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

Sebuah aplikasi desktop berbasis Visual Basic .NET (VB.NET) untuk mengelola operasional bisnis laundry. Proyek ini dibangun menggunakan arsitektur MVC (Model-View-Controller) yang memisahkan logika antarmuka pengguna, pemrosesan data, dan interaksi dengan basis data.

## 🚀 Fitur Utama
* **Autentikasi Pengguna:** Akses *login* untuk kasir/karyawan.
* **Manajemen Pesanan:** Fasilitas untuk membuat dan mengelola pesanan laundry dari antarmuka pengguna.
* **Manajemen Pelanggan:** Fitur untuk menambah dan mencatat data pelanggan baru ke dalam sistem.
* **Antarmuka Grafis (GUI):** Dibangun menggunakan sistem *Windows Forms* agar interaktif dan mudah dioperasikan oleh kasir.

## 📂 Struktur Direktori Proyek

```text
Projek-Pemdesk/
├── Purple Laundry TEST/
│   ├── Config/
│   │   └── Koneksi.vb                  # Konfigurasi koneksi ke basis data
│   ├── Controller/
│   │   ├── KasirController.vb          # Logika bisnis untuk entitas Kasir
│   │   └── PesananController.vb        # Logika bisnis pemrosesan pesanan
│   ├── Data/
│   │   ├── KasirDAO.vb                 # Data Access Object untuk kueri tabel Kasir
│   │   └── pesananDAO.vb               # Data Access Object untuk kueri tabel Pesanan
│   ├── Model/
│   │   ├── KasirModel.vb               # Representasi data (atribut & properti) Kasir
│   │   └── Sesi.vb                     # Pengelolaan status sesi login pengguna aktif
│   ├── View/
│   │   ├── formlogin.vb                # Antarmuka form login kasir
│   │   ├── MainMenu.vb                 # Antarmuka dashboard utama aplikasi
│   │   ├── FormBuatPesanan.vb          # Antarmuka form pembuatan pesanan baru
│   │   ├── TambahPelanggan.vb          # Antarmuka form pendaftaran pelanggan
│   │   └── design1.vb                  # Komponen utilitas desain UI tambahan
│   ├── My Project/                     # Konfigurasi bawaan sistem VB.NET (Resources)
│   ├── ApplicationEvents.vb            # Event handler utama siklus hidup aplikasi
│   └── Purple Laundry TEST.vbproj      # Berkas proyek utama IDE Visual Studio
├── Form 4.slnx                         # Solution file Visual Studio (.slnx)
├── .gitignore
└── .gitattributes
```

## 🏗️ Arsitektur & Teknologi
* **Bahasa Pemrograman:** Visual Basic .NET (VB.NET) <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" width="20" height="20" />
* **Platform UI:** Windows Forms (WinForms)
* **Pola Arsitektur:** Model-View-Controller (MVC) terintegrasi dengan pola lapisan data (DAO / *Data Access Object*) untuk memisahkan logika aplikasi dan kueri basis data secara modular.
* **IDE Lingkungan Kerja:** Microsoft Visual Studio <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/visualstudio/visualstudio-plain.svg" width="20" height="20" />

## ⚙️ Persyaratan Sistem
* **Microsoft Visual Studio** (versi 2019 atau lebih baru sangat disarankan untuk kompatibilitas *framework*).
* **.NET Framework** yang mendukung *runtime* aplikasi Windows.
* **Server Basis Data** aktif (seperti MySQL atau SQL Server; parameter koneksi dapat disesuaikan pada fail `Koneksi.vb`).

## 🚀 Cara Menjalankan Aplikasi
1. Lakukan *clone* atau unduh ZIP dari repositori ini ke dalam direktori komputer Anda.
2. Buka *folder* proyek tersebut, lalu klik ganda pada fail `Purple Laundry TEST.vbproj` atau `Form 4.slnx` untuk membukanya menggunakan **Microsoft Visual Studio**.
3. Masuk ke direktori `Config` dan buka fail `Koneksi.vb`. Pastikan URL server, nama *database*, serta kredensial *user* & *password* sudah sesuai dengan konfigurasi server lokal Anda.
4. Tekan **F5** atau klik tombol **▶ Start** pada panel atas Visual Studio untuk melakukan *build* dan menjalankan program.
5. Aplikasi akan langsung memunculkan antarmuka dari `formlogin` sebagai pintu masuk utama operasional.
