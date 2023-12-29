using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(modelo: "novo modelo", imei: "123456", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Nokia: ");
Smartphone iphone = new Iphone(modelo: "novo modelo", imei: "123456", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Saúde");

