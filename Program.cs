using DesafioPOO.Models;

Console.WriteLine("No Iphone:");
Smartphone i1 = new Iphone(numero: "11966666666", modelo: "XR", imei: "1111111111", memoria: 64);

i1.InstalarAplicativo("Whatsapp");
i1.Ligar();
Console.WriteLine("\n");

Console.WriteLine("No Nokia:");
Smartphone n1 = new Nokia(numero: "11968686866", modelo: "Modelo 1", imei: "212121121", memoria: 128);

i1.InstalarAplicativo("Whatsapp Business");
n1.ReceberLigacao();



