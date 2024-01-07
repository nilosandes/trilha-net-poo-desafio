using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "81 123456789", modelo: "1100", imei: "111111111", memoria: 2);
Smartphone iphone = new Iphone(numero: "87 987654321", modelo: "13 Pro Max", imei: "222222222", memoria: 256);

// Smartphone Nokia
Console.WriteLine("\nSmartphone Nokia: ");
await Task.Delay(1000);
nokia.Ligar(iphone.Numero);
await Task.Delay(3000);
nokia.InstalarAplicativo("Snake");
await Task.Delay(1000);
nokia.DesinstalarAplicativo("Brick Game");
await Task.Delay(2000);

//Smartphone iPhone
Console.WriteLine("\nSmartphone iPhone: ");
await Task.Delay(1000);
iphone.ReceberLigacao(nokia.Numero);
await Task.Delay(3000);
iphone.InstalarAplicativo("Whatsapp");
await Task.Delay(1000);
iphone.DesinstalarAplicativo("Subway Surfers");
await Task.Delay(1000);