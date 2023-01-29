using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo:"j1", imei:"skffk", memoria: 20);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "879653", modelo:"12", imei:"dgdsh", memoria: 30);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");