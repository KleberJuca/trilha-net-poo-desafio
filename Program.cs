using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        // Instância de Nokia
        Smartphone nokia = new Nokia("123456789", "3310", "000111222333444", 32);
        Console.WriteLine($"Modelo: {nokia.Modelo}, Memória: {nokia.Memoria}GB, Número: {nokia.Numero}, IMEI: {nokia.Imei}");
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Instância de iPhone
        Smartphone iphone = new Iphone("987654321", "13 Pro Max", "555666777888999", 256);
        Console.WriteLine($"Modelo: {iphone.Modelo}, Memória: {iphone.Memoria}GB, Número: {iphone.Numero}, IMEI: {iphone.Imei}");
        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");
    }
}