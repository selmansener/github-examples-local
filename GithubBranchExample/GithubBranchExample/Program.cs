namespace GithubBranchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hesapMakinasi = new HesapMakinesi();
            Console.WriteLine("3 ve 5 toplamı");
            int sonuc = hesapMakinasi.Topla(3, 5);
            Console.WriteLine(sonuc);
            // bende yorum ekledim
            Console.WriteLine("5 eksi 3 sonucu");
            sonuc = hesapMakinasi.Cikar(5, 3);
            Console.WriteLine(sonuc);
        }
    }
}
