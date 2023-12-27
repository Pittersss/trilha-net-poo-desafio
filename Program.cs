using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("Iphone 12","Pro Max","3DRTF",128);
iphone.InstalarAplicativo("Facebook");
iphone.ReceberLigacao();
iphone.Ligar();

Nokia nokia = new Nokia("Nokia","Tijolão","4UYH3",10);
iphone.InstalarAplicativo("MSN");
iphone.ReceberLigacao();
iphone.Ligar();