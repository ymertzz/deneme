Console.ForegroundColor = ConsoleColor.Green;
#region int ile 4 işlem

int intsayi1 = 145;
int intsayi2 = 125;
Console.WriteLine("Bu 2 sayinin toplamı=" + (intsayi1 + intsayi2));

int intsayi3 = 94;
int intsayi4 = 47;
Console.WriteLine("Bu 2 sayinin çıkartması=" + (intsayi3  - intsayi4));

int intsayi5 = 150;
int intsayi6 = 5;
Console.WriteLine("Bu 2 sayinin bölünmesi=" + (intsayi5 / intsayi6));

int intsayi7 = 50;
int intsayi8 = 9;
Console.WriteLine("Bu 2 sayinin çarpımı=" + (intsayi7 * intsayi8));


#endregion
Console.ForegroundColor = ConsoleColor.Red;
#region double ile 4 işlem

double doublesayi1 = 97.65;
double doublesayi2 = 76.98;
Console.WriteLine("\nBu 2 double sayinin toplamı=" + (doublesayi1 + doublesayi2));

double doublesayi3 = 78.34;
double doublesayi4 = 43.97;
Console.WriteLine("Bu 2 double sayinin çıkartması=" + (doublesayi3 - doublesayi4));

double doublesayi5 = 56.32;
double doublesayi6 = 7.85;
Console.WriteLine("Bu 2 double sayinin çarpımı=" + (doublesayi5 * doublesayi6));

double doublesayi7 = 96.23;
double doublesayi8 = 4.32;
Console.WriteLine("Bu 2 double sayinin bölünmesi=" + (doublesayi7 / doublesayi8));


#endregion

#region String ile kendim.

var varYas = "18,";
var varAdSoyad = "\nMert YILMAZ,";
var varCinsiyet = " ,";
var varCinsiyetKontrol = true;
var varKiloBilgisi = "60,";
var varMaasBilgisi = "0m,";
var varBoyBilgisi = "170,";
var varDogumTarihi = "27.03.2007,";
var varBurcBilgisi = "KOÇ,";
var varMemleketi = "ANKARA,";
var varHobiBilgisi = "Bilgisayarla Oyun Oynamak,";
var varUyumaSaatleriBilgisi = "24.00 - 02.00,";
var varUyanmaSaatleriBilgisi = "09.00 - 11.00,";
var varOynamayiSevdigiOyunlar = "Rocket League,Counter Strike2,LeagueOfLegends,Valorant,";
var varKahvaltıdaYedikleriBilgisi = "Çay,Peynir,Zeytin,Ceviz,Bal,Ekmek,";
var varFavoriOyunBilgisi = "Rocket League,";
var varUyanıncaYaptıklarıBilgisi = "Tuvaletini Yapıp Elini Yüzünü Yıkamak,";

if (varCinsiyetKontrol == true) 
{
    varCinsiyet = "ERKEK,";
}

else
{
    varCinsiyet = " KADIN";
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(varAdSoyad +
    " Cinsiyeti:" + varCinsiyet +
    " Yaşı:" + varYas +
    " Memleketi:" + varMemleketi +
    " Boyu:" + varBoyBilgisi +
    " Kilosu:" + varKiloBilgisi +
    " MaaşBilgisi:" + varMaasBilgisi +
    " Dogum Tarihi:" + varDogumTarihi +
    "  Burcu:" + varBurcBilgisi +
    " Hobisi: " + varHobiBilgisi +
    " Oynamayı Sevdiği Oyunlar:" + varOynamayiSevdigiOyunlar +
    " Favori Oyunu:" + varFavoriOyunBilgisi +
    " Uyuma Saatleri:" + varUyumaSaatleriBilgisi +
    " Uyanma Saatleri:" + varUyanmaSaatleriBilgisi +
    " Uyanınca Yaptıkları:" + varUyanıncaYaptıklarıBilgisi +
    " Kahvaltı'da Yedikleri:" + varKahvaltıdaYedikleriBilgisi);

#endregion