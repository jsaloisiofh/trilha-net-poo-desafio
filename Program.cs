using DesafioPOO.Models;

// implementado: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "Modelo 1", "11111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatApp");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("789101112", "Modelo 2", "22222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

