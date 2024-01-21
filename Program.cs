using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "987654321", modelo: "G60", imei: "123456789", memoria: 64);
Console.WriteLine($"Nokia: {nokia.ToString()}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Netflix");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "123456789", modelo: "Iphone 11", imei: "987654321", memoria: 256);
Console.WriteLine($"Iphone: {iphone}");
iphone.SetModelo("Iphone XR");
Console.WriteLine($"Iphone: {iphone}");
Console.WriteLine($"Iphone imei: {iphone.GetImei()}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");