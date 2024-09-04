using patikaflix.Models;

List<Dizi> diziler = new List<Dizi>();

// Kullanıcıdan dizileri alma
bool devamMi = true;
while (devamMi)
{
    Dizi yeniDizi = new Dizi();

    Console.Write("Dizi Adı: ");
    yeniDizi.DiziAdi = Console.ReadLine();

    Console.Write("Yapım Yılı: ");
    yeniDizi.YapimYili = int.Parse(Console.ReadLine());

    Console.Write("Türü: ");
    yeniDizi.Turu = Console.ReadLine();

    Console.Write("Yayınlanmaya Başlama Yılı: ");
    yeniDizi.YayinaBaslamaYili = int.Parse(Console.ReadLine());

    Console.Write("Yönetmen(ler): ");
    yeniDizi.Yonetenler = Console.ReadLine();

    Console.Write("Yayınlandığı İlk Platform: ");
    yeniDizi.YayinlandigiIlkPlatform = Console.ReadLine();

    diziler.Add(yeniDizi);

    Console.Write("Yeni bir dizi eklemek istiyor musunuz? (e/h): ");
    string cevap = Console.ReadLine();
    devamMi = cevap.ToLower() == "e";
}

// 1. İstenen: İlk listedeki komedi dizilerinden yeni bir liste oluşturma
List<Dizi> komediDizileri = diziler.Where(d => d.Turu.ToLower() == "komedi").ToList();

// 2. İstenen: Bu yeni listenin bütün elemanlarını yazdırma
Console.WriteLine("\nKomedi Dizileri:");
foreach (var dizi in komediDizileri.OrderBy(d => d.DiziAdi).ThenBy(d => d.Yonetenler))
{
    Console.WriteLine($"Dizi Adı: {dizi.DiziAdi}, Türü: {dizi.Turu}, Yönetmen(ler): {dizi.Yonetenler}");
}