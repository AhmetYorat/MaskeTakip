// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Merhaba");

static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("Selam" + " " + isim);
}

    SelamVer("Ahnet");
    SelamVer("İlker");
    SelamVer();

static int Topla(int sayi1, int sayi2)
{
    int sonuc=sayi1 + sayi2;
    Console.WriteLine("Toplam: " + sonuc);
    return sonuc;
}

Topla(3, 6);


string[] sehirler1 = { "Adana", "Mersin", "Balıkesir" };

foreach (string s in sehirler1)
{
    Console.WriteLine(s);
}

List<string> yeniSehirler = new List<string> {"Adana1", "Mersin1", "Balıkesir1" };// üstteki dizi oluşturmayla bu aynı
yeniSehirler.Add("Bursa1");

foreach (string s in yeniSehirler)
{
    Console.WriteLine(s);
}
Person person1 = new Person();
person1.FirstName = "Ahmet";
person1.LastName = "Yorat";
person1.Id = 10382387316;
person1.DateOfBirthYear = 2005;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);