using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Console.WriteLine("----------------");
Smartphone nokia = new Nokia(numero: "12345678", modelo:"Modelo 1", imei: "56789", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Console.WriteLine("-----------------");
Smartphone iphone = new Iphone(numero: "98765432", modelo: "XPTO12", imei:"123654", memoria:256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
