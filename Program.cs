
public class Program
{ 
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Lütfen bir sayı giriniz: ");
                string userInput = Console.ReadLine();
                     int squareRoot = Convert.ToInt32(userInput);

             Console.WriteLine($"Girdiğiniz sayı: {squareRoot} karesi: {squareRoot * squareRoot}");
        }

        catch (Exception ex)
        {
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
    }
}
































