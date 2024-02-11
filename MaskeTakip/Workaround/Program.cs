using Business.Concrete;
using Entities.Concrete;

SelamVer("Engin");
SelamVer("Yusuf");
SelamVer();

int sonuc = Topla(3, 5);

//Diziler
string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "ali";
ogrenciler[2] = "veli";
ogrenciler = new string[4]; // artık 4 elemanlı ve newlendiği için onceki elemanlar gitti (referans tip)
ogrenciler[3] = "Yusuf"; // Yeni bir liste oluştugu için sadece 4. elemanı yusuf olan bir liste oluştu diğer elemanlar BOŞ
for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

Person person1 = new Person();
person1.FirstName = "test";
person1.LastName = "test";
person1.DateOfBirthYear = 2000;
person1.NationalIdentity = 12345;

Person person2 = new Person();
person2.FirstName = "Hacı";

string[] sehirler1 = ["Ankara", "İstanbul", "izmir"];
string[] sehirler2 = ["bursa", "antalya", "diyarbakır"];

// foreach dongusuyle dizi formatını dönüyoruz ("sehirler1" bir dizi)
foreach (string sehir in sehirler1)
{
    //Console.WriteLine(sehir);
}

// Artık array yerine generic collection kullanıyoruz (kendine özgü methodları vs var. Daha kullanışlı)
List<string> yeniSehirler1 = new List<string> { "trabzon", "kars", "artvin" };
yeniSehirler1.Add("antalya");
// Daha kısası da var: List<string> yeniSehirler1 = ["trabzon", "kars", "artvin", "antalya"];

foreach (var sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);







//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// parametreli Method (Ek olarak default parametresi de var)
static void SelamVer(string isim = "user")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1 = 0, int sayi2 = 0)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc);
    return sayi1 + sayi2;
}
