using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123", modelo: "Modelo 1", imei: "111", memoria: 64);
nokia.Ligar();
nokia.DeletarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Whatsapp");
nokia.DeletarAplicativo("Whatsapp");
Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123123", modelo: "Modelo 2", imei: "222", memoria: 32);
iphone.Ligar();
iphone.DeletarAplicativo("X");
iphone.InstalarAplicativo("X");
iphone.InstalarAplicativo("X");
iphone.DeletarAplicativo("X");
Console.WriteLine();