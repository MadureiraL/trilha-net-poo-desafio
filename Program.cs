using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "123456", modelo: "1", imei:"1212121212", memoria: 124  );
iphone.Ligar();
iphone.InstalarAplicativo("Tinder");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "7891011", modelo: "2", imei: "3434343434", memoria: 256);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
