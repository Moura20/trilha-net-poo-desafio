using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("testando o nokia");
Nokia meuNokia = new Nokia("987662030", "Nokia Model X", "NOK777", 64);
meuNokia.Ligar();
meuNokia.InstalarAplicativo("Whatsapp");


// Exemplo de uso do iPhone
Console.WriteLine("testando o iphone");
Iphone meuIphone = new Iphone("987654321", "iPhone 15", "APPLE207", 128);
meuIphone.ReceberLigacao();
meuIphone.InstalarAplicativo("Instagram");