using Models;

Console.WriteLine("Nokia:\n");
Smartphone nokia = new Nokia(numero: "11991078369", modelo: "Modelo 6", imei: "5ge345d", memoria: 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("LinkedIn");

Console.WriteLine("\nIphone:\n");
Smartphone iphone = new Iphone(numero: "11991942709", modelo: "Modelo XS", imei: "437bfh3", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");