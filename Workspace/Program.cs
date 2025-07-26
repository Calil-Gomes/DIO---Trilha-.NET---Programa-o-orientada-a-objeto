using Workspace.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia: ");
        Nokia nokiaCellphone = new Nokia(numero: "8282821", modelo: "Tijolão", imei: "2222", memoria: 12);
        nokiaCellphone.Ligar();
        nokiaCellphone.InstalarAplicativo("Instagram");
        Console.WriteLine("\n");

        Console.WriteLine("Smartphone iphone: ");
        Iphone iphoneCellphone = new Iphone(numero: "9191912", modelo: "18 Pro max", imei: "1111", memoria: 240);
        iphoneCellphone.ReceberLigacao();
        iphoneCellphone.InstalarAplicativo("YouTube");
    }
}