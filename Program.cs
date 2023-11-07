using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// TODO realizado!!!

Console.WriteLine("Lendário porém descontinuado Nokia:");
Smartphone lendárioNokia = new Nokia(numero: "666999", modelo: "Modelo 'Por favor mude de celular'", imei: "123456789", memoria: 32);
lendárioNokia.Ligar();
lendárioNokia.InstalarAplicativo("Grindr");

Console.WriteLine("\n");

Console.WriteLine("iPhone BurguesiaBraileira Pro");
Smartphone iPhone = new Iphone(numero: "666-666-666", modelo: "iPhone SE 4 Pro Mini", imei: "987654321", memoria: 128);
iPhone.Ligar();
iPhone.InstalarAplicativo("Subway Surfers - Vovó Radical Version");