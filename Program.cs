﻿// See https://aka.ms/new-console-template for more information
using JurnalMod4_103022300097;

Console.WriteLine("\n====Cek Kode Barang====");
Console.Write("Masukkan Nama Produk: ");

String namaProduk = Console.ReadLine();

string kodeProduk = KodeProduk.getKodeProduk(namaProduk);

    if (kodeProduk != null)
    {
        Console.WriteLine($"Kode Produk {namaProduk} adalah {kodeProduk}");
    }
    else
    {
        Console.WriteLine("Produk tidak ditemukan");
    }

    Console.WriteLine("\n====Fan Laptop====");
    FanLaptop fanlaptop = new FanLaptop();


    fanlaptop.activateMode(FanLaptop.Mode.ModeUp);
    fanlaptop.activateMode(FanLaptop.Mode.ModeDown);
    fanlaptop.activateMode(FanLaptop.Mode.TurboShorcut);




