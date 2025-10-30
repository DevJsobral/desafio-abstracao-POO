using DesafioPOO.Models;

Iphone iphone13 = new Iphone("81992720222", "iPhone 13", "IMEI1234567890", 128);
Nokia nokinha = new Nokia("819128763172", "Nokia C20", "IMEI1234567890", 256);

Console.WriteLine("Testes do Iphone:");
iphone13.Ligar();
iphone13.ReceberLigacao();
iphone13.InstalarAplicativo("WhatsApp"); 

Console.WriteLine("------------------------------------------------------");

Console.WriteLine("Testes do Nokia:");
nokinha.Ligar();
nokinha.ReceberLigacao();
nokinha.InstalarAplicativo("Instagram"); 


