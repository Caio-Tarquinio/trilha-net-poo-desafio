﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456789" ,modelo: "Modelo 1",imei: "111111111",memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero:"123456789", modelo: "modelo 2", imei: "111111111", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
