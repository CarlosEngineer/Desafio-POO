using DesafioPOO.Models;

Console.WriteLine("----- Smarthphone-----\n");

Smartphone nokia1 = new Nokia(Numero: "11-959265852", Modelo:"Nokia 652", IMEI: "jhn62643",Memoria: 6);
nokia1.Ligar();
nokia1.InstalarAplicativo("Standoff"); 

Console.WriteLine("\n----- Smarthphone-----");

Smartphone Iphone = new Iphone(Numero: "11-94815418", Modelo:"Iphone 100", IMEI: "jhn62643",Memoria: 100);
nokia1.Ligar();
nokia1.InstalarAplicativo("Counter strike"); 
