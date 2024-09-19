namespace GithubBranchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 ve 5 toplamı");
            int sonuc = Topla(3, 5);
            Console.WriteLine(sonuc);
        }

        static int Topla(int sayi1, int sayi2) 
        { 
            return sayi1 + sayi2;
        }
    }
}
